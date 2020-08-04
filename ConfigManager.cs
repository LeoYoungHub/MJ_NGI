using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ_NGI
{
	public class ConfigManager
	{
		public static string GetConfig(string key)
		{
			return ConfigurationManager.AppSettings[key];
		}
		public static void SetConfig(string key, string value)
		{
			//修改配置文件中键为keyName的项的值
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			if (!config.AppSettings.Settings.AllKeys.Contains(key))
			{
				config.AppSettings.Settings.Add(new KeyValueConfigurationElement(key, value));
			}
			else
			{
				config.AppSettings.Settings[key].Value = value;
			}
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");

		}
	}
}

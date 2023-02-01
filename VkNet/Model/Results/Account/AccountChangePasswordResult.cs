using Newtonsoft.Json;
using System;

namespace VkNet.Model;

/// <summary>
/// Результат метода account.changePassword
/// </summary>
[Serializable]
public class AccountChangePasswordResult
{
	/// <summary>
	/// Токен.
	/// </summary>
	[JsonProperty("token")]
	public string Token { get; set; }

	/// <summary>
	/// secret в случае, если токен был nohttps.
	/// </summary>
	[JsonProperty("secret")]
	public string Secret { get; set; }
}
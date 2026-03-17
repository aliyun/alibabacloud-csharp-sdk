// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagWifiRequest : TeaModel {
        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b></description></item>
        /// <item><description><b>WPA-PSK</b></description></item>
        /// <item><description><b>WPA2-PSK</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WPA2-PSK</para>
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// <para>The bandwidth of the channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Automatic</b></description></item>
        /// <item><description><b>20 MHz</b></description></item>
        /// <item><description><b>40 MHz</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20 MHz</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The Wi-Fi channel.</para>
        /// <para>Valid values: <b>0 to 11</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The encryption algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AUTO</b>: automatically selects the encryption algorithm.</description></item>
        /// <item><description><b>TKIP</b>: uses the Temporal Key Integrity Protocol (TKIP).</description></item>
        /// <item><description><b>AES</b>: uses the Advanced Encryption Standard authorized by Wi-Fi®.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether wireless security is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables wireless security.</description></item>
        /// <item><description><b>False</b>: disables wireless security.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsAuth")]
        [Validation(Required=false)]
        public string IsAuth { get; set; }

        /// <summary>
        /// <para>Specifies whether broadcast over Wi-Fi is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables broadcast.</description></item>
        /// <item><description><b>False</b>: disables broadcast.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only after you enable broadcast, terminals that support wireless connections can search the Wi-Fi network by its SSID and receive Wi-Fi signals.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsBroadcast")]
        [Validation(Required=false)]
        public string IsBroadcast { get; set; }

        /// <summary>
        /// <para>Specifies whether Wi-Fi is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables Wi-Fi.</description></item>
        /// <item><description><b>False</b>: disables Wi-Fi.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public string IsEnable { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password used to connect to the Wi-Fi network.</para>
        /// <para>The password must be 8 to 32 characters in length, and can contain digits and letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The service set identifier (SSID) of the Wi-Fi network.</para>
        /// <para>The name must be 1 to 31 characters in length, and can contain digits and letters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_sag_123456****</para>
        /// </summary>
        [NameInMap("SSID")]
        [Validation(Required=false)]
        public string SSID { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-whfn****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag32a30****</para>
        /// </summary>
        [NameInMap("SmartAGSn")]
        [Validation(Required=false)]
        public string SmartAGSn { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagWifiResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b>: Authentication is disabled.</description></item>
        /// <item><description><b>WPA-PSK</b>: WPA-PSK authentication is enabled.</description></item>
        /// <item><description><b>WPA2-PSK</b>: WPA2-PSK authentication is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WPA2-PSK</para>
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// <para>The spectrum bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b>.</description></item>
        /// <item><description><b>20MHz</b>.</description></item>
        /// <item><description><b>40MHz</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Automatic</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The channel.</para>
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
        /// <item><description><b>AUTO</b>: Automatic encryption.</description></item>
        /// <item><description><b>TKIP</b>: Temporal Key Integrity Protocol.</description></item>
        /// <item><description><b>AES</b>: Advanced Encryption Standard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AES</para>
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// <para>Indicates whether the wireless security feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The wireless security feature is enabled.</description></item>
        /// <item><description><b>False</b>: The wireless security feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsAuth")]
        [Validation(Required=false)]
        public string IsAuth { get; set; }

        /// <summary>
        /// <para>Indicates whether the Wi-Fi broadcast feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The Wi-Fi broadcast feature is enabled.</description></item>
        /// <item><description><b>False</b>: The Wi-Fi broadcast feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsBroadcast")]
        [Validation(Required=false)]
        public string IsBroadcast { get; set; }

        /// <summary>
        /// <para>Indicates whether the wireless feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Enabled.</description></item>
        /// <item><description><b>False</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public string IsEnable { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E93884AC-6C21-4FEA-8E3A-7377D33B194F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Wi-Fi name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_sag_123456***</para>
        /// </summary>
        [NameInMap("Ssid")]
        [Validation(Required=false)]
        public string Ssid { get; set; }

        /// <summary>
        /// <para>The status of the query task.</para>
        /// </summary>
        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagWifiResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagWifiResponseBodyTaskStates : TeaModel {
            /// <summary>
            /// <para>The time when the query task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586843621000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code. A value of 200 indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. A value of Successful indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of the asynchronous task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initialized</b>: The query task is initialized.</description></item>
            /// <item><description><b>Offline</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will be delivered after the device goes online.</description></item>
            /// <item><description><b>Succeed</b>: The query task is delivered.</description></item>
            /// <item><description><b>Processing</b>: The query task is being delivered.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the Smart Access Gateway device does not support this feature.</description></item>
            /// <item><description><b>BuildRequestError</b>: The management system does not support the operation.</description></item>
            /// <item><description><b>HardwareError</b>: The query task fails to be delivered due to device errors.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The Smart Access Gateway device is offline and the query task is not delivered. The task will not be delivered even after the device goes online.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}

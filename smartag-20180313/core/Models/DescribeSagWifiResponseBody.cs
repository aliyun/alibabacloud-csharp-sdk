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
        /// <item><description><b>NONE</b>: authentication is disabled.</description></item>
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
        /// <para>The bandwidth of the Wi-Fi channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Automatic</b></description></item>
        /// <item><description><b>20 HMz</b></description></item>
        /// <item><description><b>40 MHz</b></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The Wi-Fi channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The encryption algorithm.</para>
        /// <list type="bullet">
        /// <item><description><b>AUTO</b>: automatically selects the encryption algorithm.</description></item>
        /// <item><description><b>TKIP</b>: uses the Temporal Key Integrity Protocol (TKIP).</description></item>
        /// <item><description><b>AES</b>: uses the Advanced Encryption Standard authorized by Wi-Fi®.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AES</para>
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// <para>Indicates whether wireless security is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: wireless security is enabled.</description></item>
        /// <item><description><b>False</b>: wireless security is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsAuth")]
        [Validation(Required=false)]
        public string IsAuth { get; set; }

        /// <summary>
        /// <para>Indicates whether broadcast over Wi-Fi is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: broadcast is enabled.</description></item>
        /// <item><description><b>False</b>: broadcast is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsBroadcast")]
        [Validation(Required=false)]
        public string IsBroadcast { get; set; }

        /// <summary>
        /// <para>Indicates whether wireless connections are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: wireless connections are enabled.</description></item>
        /// <item><description><b>False</b>: wireless connections are disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public string IsEnable { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E93884AC-6C21-4FEA-8E3A-7377D33B194F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service set identifier (SSID) of the Wi-Fi network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_sag_123456***</para>
        /// </summary>
        [NameInMap("Ssid")]
        [Validation(Required=false)]
        public string Ssid { get; set; }

        /// <summary>
        /// <para>The information about the query task.</para>
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
            /// <para>The error code returned for a query task. The 200 error code indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned for a query task. The Successful error message indicates that the query task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The status of the query task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Initialized</b>: The query task has been initialized.</description></item>
            /// <item><description><b>Offline</b>: The query task is not dispatched because the SAG device is disconnected from Alibaba Cloud. The task will be dispatched after the SAG device is connected to Alibaba Cloud.</description></item>
            /// <item><description><b>Succeed</b>: The query task has been dispatched.</description></item>
            /// <item><description><b>Processing</b>: The query task is being dispatched.</description></item>
            /// <item><description><b>VersionNotSupport</b>: The current version of the SAG device does not support query tasks.</description></item>
            /// <item><description><b>BuildRequestError</b>: The SAG control system does not support query tasks.</description></item>
            /// <item><description><b>HardwareError</b>: The query task failed to be dispatched due to device errors.</description></item>
            /// <item><description><b>TaskNotExist</b>: The query task does not exist.</description></item>
            /// <item><description><b>OfflineNotConfiged</b>: The query task is not dispatched because the SAG device is disconnected from Alibaba Cloud. The task will not be dispatched after the device is connected to Alibaba Cloud.</description></item>
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

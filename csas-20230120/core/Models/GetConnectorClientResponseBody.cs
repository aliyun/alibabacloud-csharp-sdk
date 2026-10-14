// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetConnectorClientResponseBody : TeaModel {
        /// <summary>
        /// <para>The ConnectorClient.</para>
        /// </summary>
        [NameInMap("ConnectorClient")]
        [Validation(Required=false)]
        public GetConnectorClientResponseBodyConnectorClient ConnectorClient { get; set; }
        public class GetConnectorClientResponseBodyConnectorClient : TeaModel {
            /// <summary>
            /// <para>The number of CPUs of the ConnectorClient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("CPUSize")]
            [Validation(Required=false)]
            public string CPUSize { get; set; }

            /// <summary>
            /// <para>The connection status of the ConnectorClient. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Connected</b>: The client is connected.</description></item>
            /// <item><description><b>Disconnected</b>: The client is disconnected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>The connector ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-94db94e06b98****</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The version of the connector client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("ConnectorVersion")]
            [Validation(Required=false)]
            public string ConnectorVersion { get; set; }

            /// <summary>
            /// <para>The time when the ConnectorClient was created. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-16 17:18:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the ConnectorClient device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E86266A0-2859-58EF-8F5B-EDE226FF6EB2</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector_client_hostname</para>
            /// </summary>
            [NameInMap("Hosname")]
            [Validation(Required=false)]
            public string Hosname { get; set; }

            /// <summary>
            /// <para>The kernel version of the ConnectorClient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22.3.0</para>
            /// </summary>
            [NameInMap("KernelVersion")]
            [Validation(Required=false)]
            public string KernelVersion { get; set; }

            /// <summary>
            /// <para>The memory size of the ConnectorClient. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32768</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <para>The O&amp;M status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: O&amp;M is in progress.</description></item>
            /// <item><description><b>Failed</b>: O&amp;M failed.</description></item>
            /// <item><description>(Empty string): Not in an O&amp;M state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("OperationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <para>The private IP address of the ConnectorClient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// <para>The runtime of the program. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProcessRunTime")]
            [Validation(Required=false)]
            public int? ProcessRunTime { get; set; }

            /// <summary>
            /// <para>The public IP address of the ConnectorClient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.0.113.1</para>
            /// </summary>
            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <para>The release notes.</para>
            /// </summary>
            [NameInMap("ReleaseNotes")]
            [Validation(Required=false)]
            public List<string> ReleaseNotes { get; set; }

            /// <summary>
            /// <para>The enabling status of the ConnectorClient. You can use this parameter to force the client offline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The upgrade status of the connector. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Latest</b>: The connector is of the latest version.</description></item>
            /// <item><description><b>NewVersionAvailable</b>: A newer version is available for upgrade.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>latest</para>
            /// </summary>
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public string UpgradeStatus { get; set; }

            /// <summary>
            /// <para>The version to roll back to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("VersionToRollback")]
            [Validation(Required=false)]
            public string VersionToRollback { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

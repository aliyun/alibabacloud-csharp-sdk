// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The Cloud Backup clients.</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public DescribeClientsResponseBodyClients Clients { get; set; }
        public class DescribeClientsResponseBodyClients : TeaModel {
            [NameInMap("Client")]
            [Validation(Required=false)]
            public List<DescribeClientsResponseBodyClientsClient> Client { get; set; }
            public class DescribeClientsResponseBodyClientsClient : TeaModel {
                /// <summary>
                /// <para>The alert settings. Valid value: INHERITED, which indicates that the Cloud Backup client sends alert notifications by using the same method configured for the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INHERITED</para>
                /// </summary>
                [NameInMap("AlertSetting")]
                [Validation(Required=false)]
                public string AlertSetting { get; set; }

                /// <summary>
                /// <para>The ID of the Cloud Backup client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-00062uu******2fgj</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The client name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client-20211224-101226</para>
                /// </summary>
                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                /// <summary>
                /// <para>The type of the Cloud Backup client. Valid value: <b>ECS_AGENT</b>, which indicates an SAP HANA backup client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_AGENT</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>The version number of the Cloud Backup client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.11.16</para>
                /// </summary>
                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                /// <summary>
                /// <para>The ID of the SAP HANA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cl-0008c48frr******ncpk</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The time when the Cloud Backup client was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz9b6wya******n8yo</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swh-hbr</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The maximum version number of the Cloud Backup client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.11.23</para>
                /// </summary>
                [NameInMap("MaxVersion")]
                [Validation(Required=false)]
                public string MaxVersion { get; set; }

                /// <summary>
                /// <para>The network type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CLASSIC</b>: the classic network</description></item>
                /// <item><description><b>VPC</b>: the virtual private cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The status of the Cloud Backup client. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>REGISTERED</b>: The backup client is registered.</description></item>
                /// <item><description><b>ACTIVATED</b>: The backup client is activated.</description></item>
                /// <item><description><b>DEACTIVATED</b>: The backup client fails to be activated.</description></item>
                /// <item><description><b>INSTALLING</b>: The backup client is being installed.</description></item>
                /// <item><description><b>INSTALL_FAILED</b>: The backup client fails to be installed.</description></item>
                /// <item><description><b>NOT_INSTALLED</b>: The backup client is not installed.</description></item>
                /// <item><description><b>UPGRADING</b>: The backup client is being upgraded.</description></item>
                /// <item><description><b>UPGRADE_FAILED</b>: The backup client fails to be upgraded.</description></item>
                /// <item><description><b>UNINSTALLING</b>: The backup client is being uninstalled.</description></item>
                /// <item><description><b>UNINSTALL_FAILED</b>: The backup client fails to be uninstalled.</description></item>
                /// <item><description><b>STOPPED</b>: The backup client is out of service.</description></item>
                /// <item><description><b>UNKNOWN</b>: The backup client is disconnected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVATED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The status information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HANA_NOT_SUPPORT</para>
                /// </summary>
                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                /// <summary>
                /// <para>The time when the Cloud Backup client was updated. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// <para>Indicates whether data is transmitted over HTTPS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Data is transmitted over HTTPS.</description></item>
                /// <item><description>false: Data is transmitted over HTTP.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UseHttps")]
                [Validation(Required=false)]
                public bool? UseHttps { get; set; }

                /// <summary>
                /// <para>The ID of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-00029mx6o******n85lg</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17189276-465D-5EF3-8FFD-0FF51B5A41A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

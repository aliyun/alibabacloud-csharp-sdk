// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried backup clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Client\&quot;: []}</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsResponseBodyClients> Clients { get; set; }
        public class DescribeBackupClientsResponseBodyClients : TeaModel {
            /// <summary>
            /// <para>Indicates whether the client is installed on an all-in-one PC that integrates hardware and monitoring program. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The client is installed on an all-in-one PC that integrates hardware and monitoring program.</description></item>
            /// <item><description>false: The client is not installed on an all-in-one PC that integrates hardware and monitoring program.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Appliance")]
            [Validation(Required=false)]
            public bool? Appliance { get; set; }

            /// <summary>
            /// <para>This parameter is valid only if the <b>ClientType</b> parameter is set to <b>ECS_CLIENT</b>. This parameter indicates the system architecture where the backup client resides. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>amd64</b></description></item>
            /// <item><description><b>386</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>amd64</para>
            /// </summary>
            [NameInMap("ArchType")]
            [Validation(Required=false)]
            public string ArchType { get; set; }

            /// <summary>
            /// <para>The protection status of the backup client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UNPROTECTED</b>: The backup client is not protected.</description></item>
            /// <item><description><b>PROTECTED</b>: The backup client is protected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PROTECTED</para>
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// <para>The ID of the backup client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-*********************</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The type of the backup client. Valid value: <b>ECS_CLIENT</b>, which indicates a client for ECS file backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_CLIENT</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>The version number of the backup client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.4.5</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The time when the backup client was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554347313</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The hostname of the backup client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hostname</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// <list type="bullet">
            /// <item><description>If the client is used to back up ECS files, this parameter indicates the ID of an ECS instance.</description></item>
            /// <item><description>If the client is used to back up on-premises files, this parameter indicates the hardware fingerprint that is generated based on the system information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-*********************</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>This parameter is valid only if the <b>ClientType</b> parameter is set to <b>ECS_CLIENT</b>. This parameter indicates the name of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instancename</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The last heartbeat time of the backup client. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554347313</para>
            /// </summary>
            [NameInMap("LastHeartBeatTime")]
            [Validation(Required=false)]
            public long? LastHeartBeatTime { get; set; }

            /// <summary>
            /// <para>The latest version number of the backup client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.4.5</para>
            /// </summary>
            [NameInMap("MaxClientVersion")]
            [Validation(Required=false)]
            public string MaxClientVersion { get; set; }

            /// <summary>
            /// <para>This parameter is valid only if the <b>ClientType</b> parameter is set to <b>ECS_CLIENT</b>. This parameter indicates the operating system type of the backup client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b></description></item>
            /// <item><description><b>linux</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>This parameter is valid only if the <b>ClientType</b> parameter is set to <b>ECS_CLIENT</b>. This parameter indicates the internal IP address of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("PrivateIpV4")]
            [Validation(Required=false)]
            public string PrivateIpV4 { get; set; }

            /// <summary>
            /// <para>The configuration information of the backup client.</para>
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public DescribeBackupClientsResponseBodyClientsSettings Settings { get; set; }
            public class DescribeBackupClientsResponseBodyClientsSettings : TeaModel {
                /// <summary>
                /// <para>Indicates whether alerts are generated for partially completed jobs. This parameter is valid only for on-premises file backup and ECS file backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AlertOnPartialComplete")]
                [Validation(Required=false)]
                public bool? AlertOnPartialComplete { get; set; }

                /// <summary>
                /// <para>The type of the endpoint on the data plane. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PUBLIC</b>: Internet</description></item>
                /// <item><description><b>VPC</b>: virtual private cloud (VPC)</description></item>
                /// <item><description><b>CLASSIC</b>: classic network</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("DataNetworkType")]
                [Validation(Required=false)]
                public string DataNetworkType { get; set; }

                /// <summary>
                /// <para>The proxy configuration on the data plane. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DISABLE</b>: The proxy is not used.</description></item>
                /// <item><description><b>USE_CONTROL_PROXY</b> (default): The configuration is the same as that on the control plane.</description></item>
                /// <item><description><b>CUSTOM</b>: The configuration is customized (HTTP).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USE_CONTROL_PROXY</para>
                /// </summary>
                [NameInMap("DataProxySetting")]
                [Validation(Required=false)]
                public string DataProxySetting { get; set; }

                /// <summary>
                /// <para>The number of CPU cores used by a single backup job. The value 0 indicates that the number is unlimited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxCpuCore")]
                [Validation(Required=false)]
                public string MaxCpuCore { get; set; }

                /// <summary>
                /// <para>The maximum memory that can be used by the client. Unit: bytes. Only V2.13.0 and later are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxMemory")]
                [Validation(Required=false)]
                public long? MaxMemory { get; set; }

                /// <summary>
                /// <para>The number of concurrent backup jobs. The value 0 indicates that the number is unlimited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxWorker")]
                [Validation(Required=false)]
                public string MaxWorker { get; set; }

                /// <summary>
                /// <para>The custom host IP address of the proxy server on the data plane.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.11.100</para>
                /// </summary>
                [NameInMap("ProxyHost")]
                [Validation(Required=false)]
                public string ProxyHost { get; set; }

                /// <summary>
                /// <para>The custom password of the proxy server on the data plane.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("ProxyPassword")]
                [Validation(Required=false)]
                public string ProxyPassword { get; set; }

                /// <summary>
                /// <para>The custom host port of the proxy server on the data plane.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3128</para>
                /// </summary>
                [NameInMap("ProxyPort")]
                [Validation(Required=false)]
                public int? ProxyPort { get; set; }

                /// <summary>
                /// <para>The custom username of the proxy server on the data plane.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("ProxyUser")]
                [Validation(Required=false)]
                public string ProxyUser { get; set; }

                /// <summary>
                /// <para>Indicates whether data on the data plane is transmitted over HTTPS. Valid values:</para>
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
                public string UseHttps { get; set; }

            }

            /// <summary>
            /// <para>The status of the backup client. Valid values:</para>
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
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeBackupClientsResponseBodyClientsTags> Tags { get; set; }
            public class DescribeBackupClientsResponseBodyClientsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the backup vault. Valid values of N: 1 to 20</para>
                /// <list type="bullet">
                /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
                /// <item><description>The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
                /// <item><description>The tag key cannot be an empty string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the backup vault. Valid values of N: 1 to 20</para>
                /// <list type="bullet">
                /// <item><description>The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
                /// <item><description>The tag value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
                /// <item><description>The tag value cannot be an empty string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the backup client was updated. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554347313</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>This parameter is valid only if the <b>ClientType</b> parameter is set to <b>ECS_CLIENT</b>. This parameter indicates the zone of the backup client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-f</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned HBR clients that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

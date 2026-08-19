// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Client\&quot;: []}</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsResponseBodyClients> Clients { get; set; }
        public class DescribeBackupClientsResponseBodyClients : TeaModel {
            /// <summary>
            /// <para>Indicates whether the client is a hardware monitoring appliance client.</para>
            /// <list type="bullet">
            /// <item><description>true: The client is a hardware monitoring appliance client.</description></item>
            /// <item><description>false: The client is not a hardware monitoring appliance client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Appliance")]
            [Validation(Required=false)]
            public bool? Appliance { get; set; }

            /// <summary>
            /// <para>This parameter is valid only when <b>ClientType</b> is set to <b>ECS_CLIENT</b>. The system architecture of the backup client. Valid values:</para>
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
            /// <item><description><b>UNPROTECTED</b>: The server is not protected.</description></item>
            /// <item><description><b>PROTECTED</b>: The server is protected.</description></item>
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
            /// <para>The type of the backup client. The value <b>ECS_CLIENT</b> indicates an ECS File Backup client.</para>
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
            /// <para>The time when the backup client was created. This value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <item><description>If the client type is ECS File Backup client, this parameter indicates the ECS instance ID.</description></item>
            /// <item><description>If the client type is local file backup client, this parameter indicates the hardware fingerprint generated based on system information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-*********************</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>This parameter is valid only when <b>ClientType</b> is set to <b>ECS_CLIENT</b>. The name of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instancename</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The time of the last heartbeat of the backup client. This value is a UNIX timestamp. Unit: seconds.</para>
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
            /// <para>This parameter is valid only when <b>ClientType</b> is set to <b>ECS_CLIENT</b>. The operating system type of the client. Valid values:</para>
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
            /// <para>This parameter is valid only when <b>ClientType</b> is set to <b>ECS_CLIENT</b>. The internal IP address of the ECS instance.</para>
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
                /// <para>Specifies whether to send alerts for partially completed jobs. This setting applies only to File Backup and ECS File Backup Essential Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AlertOnPartialComplete")]
                [Validation(Required=false)]
                public bool? AlertOnPartialComplete { get; set; }

                /// <summary>
                /// <para>The type of the data plane endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PUBLIC</b>: public network.</description></item>
                /// <item><description><b>VPC</b>: VPC network.</description></item>
                /// <item><description><b>CLASSIC</b>: classic network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("DataNetworkType")]
                [Validation(Required=false)]
                public string DataNetworkType { get; set; }

                /// <summary>
                /// <para>The data plane proxy setting. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DISABLE</b>: No proxy is used.</description></item>
                /// <item><description><b>USE_CONTROL_PROXY</b> (default): The same configuration as the control plane is used.</description></item>
                /// <item><description><b>CUSTOM</b>: A custom configuration is used (HTTP protocol).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USE_CONTROL_PROXY</para>
                /// </summary>
                [NameInMap("DataProxySetting")]
                [Validation(Required=false)]
                public string DataProxySetting { get; set; }

                /// <summary>
                /// <para>The number of CPU cores used by a single backup job. A value of 0 indicates no limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxCpuCore")]
                [Validation(Required=false)]
                public string MaxCpuCore { get; set; }

                /// <summary>
                /// <para>The maximum memory that the client can use. Unit: bytes. Only versions 2.13.0 and later are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxMemory")]
                [Validation(Required=false)]
                public long? MaxMemory { get; set; }

                /// <summary>
                /// <para>The number of concurrent workers for a single backup job. A value of 0 indicates no limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxWorker")]
                [Validation(Required=false)]
                public string MaxWorker { get; set; }

                /// <summary>
                /// <para>The IP address of the custom data plane proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.11.100</para>
                /// </summary>
                [NameInMap("ProxyHost")]
                [Validation(Required=false)]
                public string ProxyHost { get; set; }

                /// <summary>
                /// <para>The password of the custom data plane proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("ProxyPassword")]
                [Validation(Required=false)]
                public string ProxyPassword { get; set; }

                /// <summary>
                /// <para>The port of the custom data plane proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3128</para>
                /// </summary>
                [NameInMap("ProxyPort")]
                [Validation(Required=false)]
                public int? ProxyPort { get; set; }

                /// <summary>
                /// <para>The username of the custom data plane proxy server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("ProxyUser")]
                [Validation(Required=false)]
                public string ProxyUser { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTPS is used to transmit data plane data.</para>
                /// <list type="bullet">
                /// <item><description>true: HTTPS is used for transmission.</description></item>
                /// <item><description>false: HTTP is used for transmission.</description></item>
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
            /// <item><description><b>REGISTERED</b>: The client is registered.</description></item>
            /// <item><description><b>ACTIVATED</b>: The client is activated.</description></item>
            /// <item><description><b>DEACTIVATED</b>: The client activation has expired.</description></item>
            /// <item><description><b>INSTALLING</b>: The client is being installed.</description></item>
            /// <item><description><b>INSTALL_FAILED</b>: The client installation failed.</description></item>
            /// <item><description><b>NOT_INSTALLED</b>: The client is not installed.</description></item>
            /// <item><description><b>UPGRADING</b>: The client is being upgraded.</description></item>
            /// <item><description><b>UPGRADE_FAILED</b>: The client upgrade failed.</description></item>
            /// <item><description><b>UNINSTALLING</b>: The client is being uninstalled.</description></item>
            /// <item><description><b>UNINSTALL_FAILED</b>: The client uninstallation failed.</description></item>
            /// <item><description><b>STOPPED</b>: The client service is stopped.</description></item>
            /// <item><description><b>UNKNOWN</b>: The client is disconnected.</description></item>
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
                /// <para>The tag key of the backup vault. Valid values of N: 1 to 20.</para>
                /// <list type="bullet">
                /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>. </description></item>
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
                /// <para>The tag value of the backup vault. Valid values of N: 1 to 20.</para>
                /// <list type="bullet">
                /// <item><description>The tag value cannot start with <c>aliyun</c> or <c>acs:</c>. </description></item>
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
            /// <para>The time when the backup client was last updated. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1554347313</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>This parameter is valid only when <b>ClientType</b> is set to <b>ECS_CLIENT</b>. The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-f</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The response code. 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message. The value &quot;successful&quot; is returned for successful requests. An error message is returned for failed requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Minimum value: 1. Maximum value: 99. Default value: 10.</para>
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of backup clients that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

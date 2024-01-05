// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// The HBR clients.
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsResponseBodyClients> Clients { get; set; }
        public class DescribeBackupClientsResponseBodyClients : TeaModel {
            /// <summary>
            /// Indicates whether the HBR client is installed on an all-in-one PC that integrates hardware and monitoring program. Valid values:
            /// 
            /// *   true: The HBR client is installed on an all-in-one PC that integrates hardware and monitoring program.
            /// *   false: The HBR client is not installed on an all-in-one PC that integrates hardware and monitoring program.
            /// </summary>
            [NameInMap("Appliance")]
            [Validation(Required=false)]
            public bool? Appliance { get; set; }

            /// <summary>
            /// This parameter is valid only if the **ClientType** parameter is set to **ECS_CLIENT**. This parameter indicates the system architecture where the HBR client resides. Valid values:
            /// 
            /// *   **amd64**
            /// *   **386**
            /// </summary>
            [NameInMap("ArchType")]
            [Validation(Required=false)]
            public string ArchType { get; set; }

            /// <summary>
            /// The protection status of the HBR client. Valid values:
            /// 
            /// *   **UNPROTECTED**: The HBR client is not protected.
            /// *   **PROTECTED**: The HBR client is protected.
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// The ID of the HBR client.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The type of the HBR client. Valid value: **ECS_CLIENT**, which indicates an HBR client for ECS file backup.
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// The version number of the HBR client.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The time when the HBR client was created. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The hostname of the HBR client.
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// 
            /// *   If the HBR client is used to back up ECS files, this parameter indicates the ID of an ECS instance.
            /// *   If the HBR client is used to back up on-premises files, this parameter indicates the hardware fingerprint that is generated based on the system information.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// This parameter is valid only if the **ClientType** parameter is set to **ECS_CLIENT**. This parameter indicates the name of the ECS instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The last heartbeat time of the HBR client. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("LastHeartBeatTime")]
            [Validation(Required=false)]
            public long? LastHeartBeatTime { get; set; }

            /// <summary>
            /// The latest version number of the HBR client.
            /// </summary>
            [NameInMap("MaxClientVersion")]
            [Validation(Required=false)]
            public string MaxClientVersion { get; set; }

            /// <summary>
            /// This parameter is valid only if the **ClientType** parameter is set to **ECS_CLIENT**. This parameter indicates the operating system type of the HBR client. Valid values:
            /// 
            /// *   **windows**
            /// *   **linux**
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// This parameter is valid only if the **ClientType** parameter is set to **ECS_CLIENT**. This parameter indicates the internal IP address of the ECS instance.
            /// </summary>
            [NameInMap("PrivateIpV4")]
            [Validation(Required=false)]
            public string PrivateIpV4 { get; set; }

            /// <summary>
            /// The configuration information of the HBR client.
            /// </summary>
            [NameInMap("Settings")]
            [Validation(Required=false)]
            public DescribeBackupClientsResponseBodyClientsSettings Settings { get; set; }
            public class DescribeBackupClientsResponseBodyClientsSettings : TeaModel {
                [NameInMap("AlertOnPartialComplete")]
                [Validation(Required=false)]
                public bool? AlertOnPartialComplete { get; set; }

                /// <summary>
                /// The type of the endpoint on the data plane. Valid values:
                /// 
                /// *   **PUBLIC**: Internet
                /// *   **VPC**: virtual private cloud (VPC)
                /// *   **CLASSIC**: classic network
                /// </summary>
                [NameInMap("DataNetworkType")]
                [Validation(Required=false)]
                public string DataNetworkType { get; set; }

                /// <summary>
                /// The proxy configuration on the data plane. Valid values:
                /// 
                /// *   **DISABLE**: The proxy is not used.
                /// *   \*\*USE_CONTROL_PROXY \*\* (default value): The configuration is the same as that on the control plane.
                /// *   **CUSTOM**: The configuration is customized (HTTP).
                /// </summary>
                [NameInMap("DataProxySetting")]
                [Validation(Required=false)]
                public string DataProxySetting { get; set; }

                /// <summary>
                /// The number of CPU cores used by a single backup job. The value 0 indicates that the number is unlimited.
                /// </summary>
                [NameInMap("MaxCpuCore")]
                [Validation(Required=false)]
                public string MaxCpuCore { get; set; }

                [NameInMap("MaxMemory")]
                [Validation(Required=false)]
                public long? MaxMemory { get; set; }

                /// <summary>
                /// The number of concurrent backup jobs. The value 0 indicates that the number is unlimited.
                /// </summary>
                [NameInMap("MaxWorker")]
                [Validation(Required=false)]
                public string MaxWorker { get; set; }

                /// <summary>
                /// The custom host IP address of the proxy server on the data plane.
                /// </summary>
                [NameInMap("ProxyHost")]
                [Validation(Required=false)]
                public string ProxyHost { get; set; }

                /// <summary>
                /// The custom password of the proxy server on the data plane.
                /// </summary>
                [NameInMap("ProxyPassword")]
                [Validation(Required=false)]
                public string ProxyPassword { get; set; }

                /// <summary>
                /// The custom host port of the proxy server on the data plane.
                /// </summary>
                [NameInMap("ProxyPort")]
                [Validation(Required=false)]
                public int? ProxyPort { get; set; }

                /// <summary>
                /// The custom username of the proxy server on the data plane.
                /// </summary>
                [NameInMap("ProxyUser")]
                [Validation(Required=false)]
                public string ProxyUser { get; set; }

                /// <summary>
                /// Indicates whether data on the data plane is transmitted over HTTPS. Valid values:
                /// 
                /// *   true: Data is transmitted over HTTPS.
                /// *   false: Data is transmitted over HTTP.
                /// </summary>
                [NameInMap("UseHttps")]
                [Validation(Required=false)]
                public string UseHttps { get; set; }

            }

            /// <summary>
            /// The status of the HBR client. Valid values:
            /// 
            /// *   **REGISTERED**: The HBR client is registered.
            /// *   **ACTIVATED**: The HBR client is enabled.
            /// *   **DEACTIVATED**: The HBR client fails to be enabled.
            /// *   **INSTALLING**: The HBR client is being installed.
            /// *   **INSTALL_FAILED**: The HBR client fails to be installed.
            /// *   **NOT_INSTALLED**: The HBR client is not installed.
            /// *   **UPGRADING**: The HBR client is being upgraded.
            /// *   **UPGRADE_FAILED**: The HBR client fails to be upgraded.
            /// *   **UNINSTALLING**: The HBR client is being uninstalled.
            /// *   **UNINSTALL_FAILED**: The HBR client fails to be uninstalled.
            /// *   **STOPPED**: The HBR client is out of service.
            /// *   **UNKNOWN**: The HBR client is disconnected.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag information.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeBackupClientsResponseBodyClientsTags> Tags { get; set; }
            public class DescribeBackupClientsResponseBodyClientsTags : TeaModel {
                /// <summary>
                /// The tag key of the backup vault. Valid values of N: 1 to 20.
                /// 
                /// *   The tag key cannot start with `aliyun` or `acs:`.
                /// *   The tag key cannot contain `http://` or `https://`.
                /// *   The tag key cannot be an empty string.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the backup vault. Valid values of N: 1 to 20.
                /// 
                /// *   The tag value cannot start with `aliyun` or `acs:`.
                /// *   The tag value cannot contain `http://` or `https://`.
                /// *   The tag value cannot be an empty string.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The time when the HBR client was updated. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// This parameter is valid only if the **ClientType** parameter is set to **ECS_CLIENT**. This parameter indicates the zone of the HBR client.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned HBR clients that meet the specified conditions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

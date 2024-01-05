// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeClientsResponseBody : TeaModel {
        /// <summary>
        /// The backup clients.
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
                /// The alert settings. Valid value: INHERITED, which indicates that the backup client sends alert notifications in the same way as the backup vault.
                /// </summary>
                [NameInMap("AlertSetting")]
                [Validation(Required=false)]
                public string AlertSetting { get; set; }

                /// <summary>
                /// The ID of the backup client.
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// The name of the backup client.
                /// </summary>
                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                /// <summary>
                /// The type of the backup client. Valid value:**ECS_AGENT**, which indicates an SAP HANA backup client.
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// The version number of the backup client.
                /// </summary>
                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                /// <summary>
                /// The ID of the SAP HANA instance.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The time when the backup client was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the ECS instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The maximum version number of the backup client.
                /// </summary>
                [NameInMap("MaxVersion")]
                [Validation(Required=false)]
                public string MaxVersion { get; set; }

                /// <summary>
                /// The network type. Valid values:
                /// 
                /// *   **CLASSIC**: classic network
                /// *   **VPC**: virtual private cloud (VPC)
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The status of the backup client. Valid values:
                /// 
                /// *   **REGISTERED**: The backup client is registered.
                /// *   **ACTIVATED**: The backup client is enabled.
                /// *   **DEACTIVATED**: The backup client fails to be enabled.
                /// *   **INSTALLING**: The backup client is being installed.
                /// *   **INSTALL_FAILED**: The backup client fails to be installed.
                /// *   **NOT_INSTALLED**: The backup client is not installed.
                /// *   **UPGRADING**: The backup client is being upgraded.
                /// *   **UPGRADE_FAILED**: The backup client fails to be upgraded.
                /// *   **UNINSTALLING**: The backup client is being uninstalled.
                /// *   **UNINSTALL_FAILED**: The backup client fails to be uninstalled.
                /// *   **STOPPED**: The backup client is out of service.
                /// *   **UNKNOWN**: The backup client is disconnected.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The status information.
                /// </summary>
                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                /// <summary>
                /// The time when the backup client was updated. This value is a UNIX timestamp. Unit: seconds.
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// Indicates whether data is transmitted over HTTPS. Valid values:
                /// 
                /// *   true: Data is transmitted over HTTPS.
                /// *   false: Data is transmitted over HTTP.
                /// </summary>
                [NameInMap("UseHttps")]
                [Validation(Required=false)]
                public bool? UseHttps { get; set; }

                /// <summary>
                /// The ID of the backup vault.
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

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
        /// The number of entries returned per page. Valid values: 1 to 99. Default value: 10.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

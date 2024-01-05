// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateClientSettingsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to generate alert for partially completed jobs. This parameter is valid only for on-premises file backup and ECS file backup.
        /// </summary>
        [NameInMap("AlertOnPartialComplete")]
        [Validation(Required=false)]
        public bool? AlertOnPartialComplete { get; set; }

        /// <summary>
        /// The ID of the HBR client.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

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
        /// *   **DISABLE**: No proxy is used.
        /// *   **USE_CONTROL_PROXY** (default): The configuration is the same as that on the control plane.
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
        public int? MaxCpuCore { get; set; }

        /// <summary>
        /// The maximum memory that can be used by the client. Unit: bytes. Only V2.13.0 and later are supported.
        /// </summary>
        [NameInMap("MaxMemory")]
        [Validation(Required=false)]
        public long? MaxMemory { get; set; }

        /// <summary>
        /// The number of concurrent backup jobs. The value 0 indicates that the number is unlimited.
        /// </summary>
        [NameInMap("MaxWorker")]
        [Validation(Required=false)]
        public int? MaxWorker { get; set; }

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
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to transmit the data on the data plane over HTTPS. Valid values:
        /// 
        /// *   true: Data is transmitted over HTTPS.
        /// *   false: Data is transmitted over HTTP.
        /// </summary>
        [NameInMap("UseHttps")]
        [Validation(Required=false)]
        public bool? UseHttps { get; set; }

        /// <summary>
        /// The ID of the backup vault. This parameter is required for the old HBR client.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}

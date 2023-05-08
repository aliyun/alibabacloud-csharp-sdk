// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetDetailResponseBody : TeaModel {
        /// <summary>
        /// The number of instances in the list of cloud assets returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// An array that consists of the details of the cloud assets.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetCloudAssetDetailResponseBodyInstances> Instances { get; set; }
        public class GetCloudAssetDetailResponseBodyInstances : TeaModel {
            /// <summary>
            /// Indicates whether alerts are generated for the current cloud asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// The subtype of the cloud asset.
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// The subtype name of the cloud asset.
            /// </summary>
            [NameInMap("AssetSubTypeName")]
            [Validation(Required=false)]
            public string AssetSubTypeName { get; set; }

            /// <summary>
            /// The type of the cloud asset. Valid values:
            /// 
            /// *   **0**: ECS
            /// *   **1**: SLB
            /// *   **3**: ApsaraDB RDS
            /// *   **4**: MongoDB
            /// *   **5**: Redis
            /// *   **6**: Container Registry
            /// *   **8**: ACK
            /// *   **9**: VPC
            /// *   **11**: ActionTrail
            /// *   **12**: CDN
            /// *   **13**: Certificate Management Service (formerly SSL Certificates Service)
            /// *   **14**: Apsara Devops
            /// *   **15**: RAM
            /// *   **16**: Anti-DDoS
            /// *   **17**: WAF
            /// *   **18**: OSS
            /// *   **19**: PolarDB
            /// *   **20**: ApsaraDB RDS for PostgreSQL
            /// *   **21**: MSE
            /// *   **22**: NAS
            /// *   **23**: DSC
            /// *   **24**: EIP
            /// *   **25**: IDaaS EIAM
            /// *   **26**: PolarDB-X
            /// *   **27**: Elasticsearch
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// The type name of the cloud asset.
            /// </summary>
            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// The time when the instance was created. The value is a timestamp.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The detailed address of the cloud asset.
            /// </summary>
            [NameInMap("DetailLink")]
            [Validation(Required=false)]
            public string DetailLink { get; set; }

            /// <summary>
            /// The instance ID of the cloud asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance name of the cloud asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the instance.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The region where the cloud asset resides.
            /// 
            /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether risks are detected on the current cloud asset. Valid values:
            /// 
            /// *   **YES**
            /// *   **NO**
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// The security information about the cloud asset.
            /// </summary>
            [NameInMap("SecurityInfo")]
            [Validation(Required=false)]
            public string SecurityInfo { get; set; }

            /// <summary>
            /// The service provider of the cloud asset. Valid values:
            /// 
            /// *   **0**: The asset is provided by Alibaba Cloud.
            /// *   **1**: The asset is not provided by Alibaba Cloud.
            /// *   **2**: The asset resides in a data center.
            /// *   **3**, **4**, **5**, and **7**: other cloud asset.
            /// *   **8**: The asset is a simple application server.
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

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
            /// The name of the cloud asset subtype.
            /// </summary>
            [NameInMap("AssetSubTypeName")]
            [Validation(Required=false)]
            public string AssetSubTypeName { get; set; }

            /// <summary>
            /// The type of the cloud asset. Valid values:
            /// 
            /// *   **0**: ECS.
            /// *   **1**: SLB.
            /// *   **3**: ApsaraDB RDS.
            /// *   **4**: ApsaraDB for MongoDB.
            /// *   **5**: ApsaraDB for Redis.
            /// *   **6**: Container Registry.
            /// *   **8**: Container Service for Kubernetes.
            /// *   **9**: VPC.
            /// *   **11**: ActionTrail.
            /// *   **12**: CDN.
            /// *   **13**: Certificate Management Service.
            /// *   **14**: Apsara Devops.
            /// *   **15**: RAM.
            /// *   **16**: Anti-DDoS.
            /// *   **17**: WAF.
            /// *   **18**: OSS.
            /// *   **19**: PolarDB.
            /// *   **20**: ApsaraDB RDS for PostgreSQL.
            /// *   **21**: MSE.
            /// *   **22**: NAS.
            /// *   **23**: DSC.
            /// *   **24**: EIP.
            /// *   **25**: IDaaS-EIAM.
            /// *   **26**: PolarDB-X.
            /// *   **27**: Elasticsearch.
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// The name of the cloud asset type.
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
            /// The region in which the cloud asset resides.
            /// 
            /// > For more information about the mapping between region IDs and region names, see [Regions and zones](https://help.aliyun.com/document_detail/40654.html).
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
            /// *   **0**: Alibaba Cloud.
            /// *   **1**: service provider that is unrecognized.
            /// *   **2**: data center.
            /// *   **3**, **4**, **5**, and **7**: third-party service provider.
            /// *   **8**: simple application server.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudGroupsRequest : TeaModel {
        /// <summary>
        /// The ID of the hybrid cloud cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// The type of proxy cluster that is used. Valid values:
        /// 
        /// *   **service**: service-based traffic mirroring.
        /// *   **cname**: reverse proxy.
        /// </summary>
        [NameInMap("ClusterProxyType")]
        [Validation(Required=false)]
        public string ClusterProxyType { get; set; }

        /// <summary>
        /// The name of the node group that you want to query.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public int? GroupName { get; set; }

        /// <summary>
        /// The type of the node group. Valid values:
        /// 
        /// *   **protect**
        /// *   **control**
        /// *   **storage**
        /// *   **controlStorage**
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// > You can call the [DescribeInstance](~~433756~~) operation to obtain the ID of the WAF instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the WAF instance. Valid values:
        /// 
        /// *   **cn-hangzhou:** the Chinese mainland.
        /// *   **ap-southeast-1:** outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}

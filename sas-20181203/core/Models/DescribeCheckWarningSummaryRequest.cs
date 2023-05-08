// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningSummaryRequest : TeaModel {
        /// <summary>
        /// The value of the container field.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The level-1 type of check items.
        /// 
        /// >  You can call the [DescribeRiskType](~~DescribeRiskType~~) operation to query the level-1 types of check items.
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// The ID of the baseline check policy.
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The statistics of check items.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UUID of the asset.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of assets.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The level-2 type of the risk item.
        /// </summary>
        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

        /// <summary>
        /// The type of the query condition. Valid values:
        /// 
        /// *   **uuid**: the ID of an asset
        /// </summary>
        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public int? RiskStatus { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The number of high-risk items.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of assets on which risk items are detected.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// The number of check items.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The page number of the current page.
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// The name of the container field. Valid values:
        /// 
        /// *   **clusterId**: the ID of the cluster
        /// *   **image**: the name of the image
        /// *   **imageId**: the ID of the image
        /// *   **namespace**: the namespace
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}

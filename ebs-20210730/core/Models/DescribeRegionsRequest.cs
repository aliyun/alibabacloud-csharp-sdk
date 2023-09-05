// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The language in which the regions and zones are named. This parameter corresponds to the `LocalName` response parameter. Valid values:
        /// 
        /// *   zh-CN: Chinese
        /// *   en-US: English
        /// *   ja: Japanese
        /// 
        /// Default value: zh-CN.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of resource. Valid values:
        /// 
        /// *   ear: async replication
        /// *   lens: CloudLens for EBS
        /// *   dbsc: Dedicated Block Storage Cluster
        /// 
        /// Default value: ear.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

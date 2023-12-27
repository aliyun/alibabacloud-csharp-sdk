// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitDetailRequest : TeaModel {
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// The unique ID of the data asset that you want to query.
        /// 
        /// > You can call the [DescribeDataLimits](~~DescribeDataLimits~~) operation to query the ID of the data asset.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Simplified Chinese.
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The network type of the data asset that you want to query. Valid values:
        /// 
        /// *   **1**: virtual private cloud (VPC)
        /// *   **2**: classic network
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public int? NetworkType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SaveQuickQueryRequest : TeaModel {
        /// <summary>
        /// The name of the saved search.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The query statement.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in the Chinese mainland or in the China (Hong Kong) region.
        /// *   ap-southeast-1: Your assets reside in regions outside the Chinese mainland, excluding the China (Hong Kong) region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

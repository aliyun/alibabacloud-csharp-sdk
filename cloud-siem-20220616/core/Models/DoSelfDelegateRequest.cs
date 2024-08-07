// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DoSelfDelegateRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account of an ordinary member of the threat analysis feature.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// Specifies whether to use a delegated administrator account. Valid values:
        /// 
        /// *   1: use a delegated administrator account.
        /// *   0: do not use a delegated administrator account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DelegateOrNot")]
        [Validation(Required=false)]
        public int? DelegateOrNot { get; set; }

        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside the Chinese mainland or in the China (Hong Kong) region.
        /// *   ap-southeast-1: Your assets reside in regions outside the Chinese mainland, excluding the China (Hong Kong) region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

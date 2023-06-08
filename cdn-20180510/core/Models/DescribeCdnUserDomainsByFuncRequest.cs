// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserDomainsByFuncRequest : TeaModel {
        /// <summary>
        /// The ID of the feature.
        /// 
        /// For example, the ID of the origin host feature (set_req_host_header) is 18.
        /// </summary>
        [NameInMap("FuncId")]
        [Validation(Required=false)]
        public int? FuncId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// 
        /// Valid values: **1** to **100000**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of domain names to return on each page. Default value: **20**.
        /// 
        /// Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

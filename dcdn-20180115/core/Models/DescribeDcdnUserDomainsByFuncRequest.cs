// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsByFuncRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name whose ICP filing status you want to update.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies whether the feature that is specified by the FuncId parameter is enabled.
        /// 
        /// *   **config**: enabled
        /// *   **unconfig**: not enabled
        /// </summary>
        [NameInMap("FuncFilter")]
        [Validation(Required=false)]
        public string FuncFilter { get; set; }

        /// <summary>
        /// The ID of the feature. For more information about how to query feature IDs, see [Parameters for configuring features for domain names](~~410622~~). For example, the ID of the origin host feature (set_req_host_header) is 18.
        /// </summary>
        [NameInMap("FuncId")]
        [Validation(Required=false)]
        public int? FuncId { get; set; }

        /// <summary>
        /// The type of the search. Default value: exact_match. Valid values:
        /// 
        /// *   fuzzy_match: fuzzy search.
        /// *   exact_match: exact search.
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**. Valid values: **1 to 100000**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**. Valid values: **1 to 500**.
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

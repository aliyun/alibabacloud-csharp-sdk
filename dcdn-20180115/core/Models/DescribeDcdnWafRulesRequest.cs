// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafRulesRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Valid values: **1** to **100000**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of protection rules to return per page. Valid values: integers from **1** to **500**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The query conditions. The value needs to be a JSON string in the following format: `QueryArgs={"PolicyIds":"The range of protection policy IDs","RuleIds":"The range of protection rule IDs","RuleNameLike":"The name of the protection rule","DomainNames":"The protected domain names","DefenseScenes":"waf_group","RuleStatus":"on","OrderBy":"GmtModified","Desc":"false"}`.
        /// 
        /// > If you do not specify this parameter, all protection rules are queried.
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

    }

}

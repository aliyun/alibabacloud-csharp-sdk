// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the WAF rule group. You can query the ID by calling the [DescribeDcdnWafGroups](~~DescribeDcdnWafGroups~~) operation.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   **en**: English
        /// *    **zh**: Chinese
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The query conditions. The value needs to be a JSON string in the following format: Format:
        /// 
        /// `QueryArgs={"PolicyIds":"IDs of protection policies","RuleIds":"IDs of protection rules","RuleNameLike":"Names of protection rules","DomainNames":"Protected domain names","DefenseScenes":"waf_group","RuleStatus":"on","OrderBy":"GmtModified","Desc":"false"}`
        /// 
        /// > If you do not specify this parameter, all protection rules are queried.
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

        /// <summary>
        /// The range of the rule group to be queried.
        /// 
        /// *   **in**: rules in the rule group are returned.
        /// *  **out**: rules that are in the full rule set but are not in the rule group are returned.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}

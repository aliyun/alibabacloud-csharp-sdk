// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafRulesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Valid values: <b>1</b> to <b>100000</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of protection rules to return per page. Valid values: integers from <b>1</b> to <b>500</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query conditions. The value needs to be a JSON string in the following format: <c>QueryArgs={&quot;PolicyIds&quot;:&quot;The range of protection policy IDs&quot;,&quot;RuleIds&quot;:&quot;The range of protection rule IDs&quot;,&quot;RuleNameLike&quot;:&quot;The name of the protection rule&quot;,&quot;DomainNames&quot;:&quot;The protected domain names&quot;,&quot;DefenseScenes&quot;:&quot;waf_group&quot;,&quot;RuleStatus&quot;:&quot;on&quot;,&quot;OrderBy&quot;:&quot;GmtModified&quot;,&quot;Desc&quot;:&quot;false&quot;}</c>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, all protection rules are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RuleIds&quot;:&quot;100001,200002&quot;}</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafPoliciesRequest : TeaModel {
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
        /// <para>The number of protection policies to return on each page. Valid values: an integer from <b>1</b> to <b>500</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query conditions. The value is a JSON string. The format is <c>QueryArgs={&quot;PolicyIds&quot;:&quot;The IDs of protection policies&quot;,&quot;RuleIds&quot;:&quot;The IDs of protection rules&quot;,&quot;PolicyNameLike&quot;:&quot;The name of the protection policy&quot;,&quot;DomainNames&quot;:&quot;The protected domain names&quot;,&quot;PolicyType&quot;:&quot;default&quot;,&quot;DefenseScenes&quot;:&quot;waf_group&quot;,&quot;PolicyStatus&quot;:&quot;on&quot;,&quot;OrderBy&quot;:&quot;GmtModified&quot;,&quot;Desc&quot;:&quot;false&quot;}</c></para>
        /// <remarks>
        /// <para>If you do not set this parameter, all protection policies are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PolicyNameLIike&quot;:&quot;test_policy&quot;}</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

    }

}

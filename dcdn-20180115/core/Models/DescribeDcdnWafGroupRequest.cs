// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF rule group. You can query the ID by calling the <a href="~~DescribeDcdnWafGroups~~">DescribeDcdnWafGroups</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1012</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query conditions. The value is a JSON string in the following format:</para>
        /// <para><c>QueryArgs={&quot;PolicyIds&quot;:&quot;The range of protection policy IDs&quot;,&quot;RuleIds&quot;:&quot;The range of protection rule IDs&quot;,&quot;RuleNameLike&quot;:&quot;The name of the protection rule&quot;,&quot;DomainNames&quot;:&quot;The protected domain names&quot;,&quot;DefenseScenes&quot;:&quot;waf_group&quot;,&quot;RuleStatus&quot;:&quot;on&quot;,&quot;OrderBy&quot;:&quot;GmtModified&quot;,&quot;Desc&quot;:&quot;false&quot;}</c></para>
        /// <remarks>
        /// <para> If you do not specify this parameter, all protection rules are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;RiskLevel\&quot;:\&quot;\&quot;,\&quot;ProtectionType\&quot;:\&quot;\&quot;,\&quot;ApplicationType\&quot;:\&quot;\&quot;,\&quot;RuleIdLike\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

        /// <summary>
        /// <para>The range of the rule group to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: Rules in the rule group are returned.</description></item>
        /// <item><description><b>out</b>: Rules that are in the full rule set but are not in the rule group are returned.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}

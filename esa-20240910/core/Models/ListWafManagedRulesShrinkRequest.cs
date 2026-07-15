// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafManagedRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The attack type of the vulnerability prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL injection</description></item>
        /// <item><description>cross-site scripting (XSS)</description></item>
        /// <item><description>code execute</description></item>
        /// <item><description>CRLF</description></item>
        /// <item><description>local file inclusion (LFI)</description></item>
        /// <item><description>remote file inclusion (RFI)</description></item>
        /// <item><description>webshell</description></item>
        /// <item><description>cross-site request forgery</description></item>
        /// <item><description>Others</description></item>
        /// <item><description>SEMA</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public int? AttackType { get; set; }

        /// <summary>
        /// <para>The ID of the WAF rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The WAF instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-awmmx25y2igw</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language type. The response is returned in the specified language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The managed ruleset configuration in JSON string format.</para>
        /// <para>Contains the AttackType, ProtectionLevel, Action, and ManagedRules subfields. When ProtectionLevel is set to -1 (custom mode), specify the status and action for each rule through the ManagedRules array.</para>
        /// </summary>
        [NameInMap("ManagedRuleset")]
        [Validation(Required=false)]
        public string ManagedRulesetShrink { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The currently saved protection level, which represents the existing configuration state in the database.</para>
        /// <para>Valid values: -1 (custom mode), 1 (loose), 2 (medium), 3 (strict), 4 (super strict).</para>
        /// <para>Difference from ManagedRuleset.ProtectionLevel: this parameter indicates the currently effective configuration, while ManagedRuleset.ProtectionLevel indicates the target value being passed in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public int? ProtectionLevel { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Status\&quot;:\&quot;\&quot;,\&quot;ProtectionLevels\&quot;:[2,1],\&quot;Action\&quot;:\&quot;\&quot;,\&quot;IdNameLike\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgsShrink { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain the site ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}

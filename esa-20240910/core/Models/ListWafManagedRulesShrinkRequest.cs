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
        /// <item><description>Cross-site scripting (XSS)</description></item>
        /// <item><description>Code execute</description></item>
        /// <item><description>CRLF</description></item>
        /// <item><description>Local file inclusion (LFI)</description></item>
        /// <item><description>Remote file inclusion (RFI)</description></item>
        /// <item><description>webshell</description></item>
        /// <item><description>Cross-site request forgery</description></item>
        /// <item><description>Other</description></item>
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
        /// <para>The managed rule set configuration in JSON string format. This parameter includes the AttackType, ProtectionLevel, Action, and ManagedRules sub-fields. If ProtectionLevel is set to -1 (custom mode), you must specify the status and action for each rule in the ManagedRules array.</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The currently saved protection level, which represents the existing configuration status in the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: custom mode.</description></item>
        /// <item><description>1: loose.</description></item>
        /// <item><description>2: medium.</description></item>
        /// <item><description>3: strict.</description></item>
        /// <item><description>4: super strict.
        /// Difference from ManagedRuleset.ProtectionLevel: This field indicates the currently effective configuration, whereas ManagedRuleset.ProtectionLevel indicates the target value passed in the request.</description></item>
        /// </list>
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

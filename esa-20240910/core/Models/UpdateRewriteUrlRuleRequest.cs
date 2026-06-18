// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRewriteUrlRuleRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2867480.html">ListRewriteUrlRules</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3528160969****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The query string after the rewrite.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example=123</para>
        /// </summary>
        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// <para>The query string rewrite type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>static: Static Mode.</para>
        /// </description></item>
        /// <item><description><para>dynamic: Dynamic Mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("RewriteQueryStringType")]
        [Validation(Required=false)]
        public string RewriteQueryStringType { get; set; }

        /// <summary>
        /// <para>The URI rewrite type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>static: Static Mode.</para>
        /// </description></item>
        /// <item><description><para>dynamic: Dynamic Mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("RewriteUriType")]
        [Validation(Required=false)]
        public string RewriteUriType { get; set; }

        /// <summary>
        /// <para>The content of the rule, a conditional expression that matches user requests. This parameter is not required for a Global Configuration. Two use cases are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to true.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, for example, (http.host eq &quot;video.example.com&quot;).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is enabled. This parameter is not required for a Global Configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para>off: The rule is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. This parameter is not required for a Global Configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example=123</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution priority of the rule. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The destination URI after the rewrite.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/image/example.jpg</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}

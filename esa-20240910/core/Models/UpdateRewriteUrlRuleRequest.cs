// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRewriteUrlRuleRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID. You can call the <a href="https://help.aliyun.com/document_detail/2867480.html">ListRewriteUrlRules</a> operation to obtain the configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3528160969****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The query string after rewriting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example=123</para>
        /// </summary>
        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// <para>The query character string rewrite type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>static: static pattern.</description></item>
        /// <item><description>dynamic: dynamic pattern.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("RewriteQueryStringType")]
        [Validation(Required=false)]
        public string RewriteQueryStringType { get; set; }

        /// <summary>
        /// <para>The path rewrite type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>static: static pattern.</description></item>
        /// <item><description>dynamic: dynamic pattern.</description></item>
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
        /// <para>The rule content. A conditional expression is used to match user requests. This parameter is not required when you add a global configuration. Two scenarios are supported:</para>
        /// <list type="bullet">
        /// <item><description>Match all incoming requests: Set the value to true.</description></item>
        /// <item><description>Match specified requests: Set the value to a custom expression, for example, (http.host eq \&quot;video.example.com\&quot;).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The rule switch. This parameter is not required when you add a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. This parameter is not required when you add a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example=123</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule execution order. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The target URI after rewriting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/image/example.jpg</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}

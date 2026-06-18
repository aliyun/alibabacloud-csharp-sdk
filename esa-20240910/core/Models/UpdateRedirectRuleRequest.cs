// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRedirectRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration. To get this ID, call the <a href="https://help.aliyun.com/document_detail/2867474.html">ListRedirectRules</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3528160969****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Specifies whether to preserve the query string of the original request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Preserves the query string.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Does not preserve the query string.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ReserveQueryString")]
        [Validation(Required=false)]
        public string ReserveQueryString { get; set; }

        /// <summary>
        /// <para>The conditional expression that matches user requests. This parameter is not required for a global configuration. Two scenarios are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, use a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Specifies whether to enable the rule. This parameter is not required for a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the rule.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the rule.</para>
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
        /// <para>The name of the rule. This parameter is not required for a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution order of the rule. A lower value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The ID of the site. To get this ID, call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The response status code that the edge node returns to the client for the redirect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>301</para>
        /// </description></item>
        /// <item><description><para>302</para>
        /// </description></item>
        /// <item><description><para>303</para>
        /// </description></item>
        /// <item><description><para>307</para>
        /// </description></item>
        /// <item><description><para>308</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>301</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>The URL to which requests are redirected.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.exapmle.com/index.html">http://www.exapmle.com/index.html</a></para>
        /// </summary>
        [NameInMap("TargetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// <para>The redirection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>static</c>: Static mode.</para>
        /// </description></item>
        /// <item><description><para><c>dynamic</c>: Dynamic mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

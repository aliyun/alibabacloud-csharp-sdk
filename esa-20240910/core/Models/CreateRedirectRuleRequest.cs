// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRedirectRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to preserve the query string from the original request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Preserves the query string.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Discards the query string.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ReserveQueryString")]
        [Validation(Required=false)]
        public string ReserveQueryString { get; set; }

        /// <summary>
        /// <para>The rule content, which is a conditional expression used to match user requests. Do not set this parameter when adding a global configuration. The following use cases are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Specifies whether to enable the rule. Do not set this parameter when adding a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: The rule is disabled.</para>
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
        /// <para>The rule name. Do not set this parameter when adding a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
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
        /// <para>The site ID. To get this value, call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>For sites with configuration version management enabled, specify the version to which this configuration applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>The status code that the edge node returns to the client for the redirect. Valid values:</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>301</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>The target URL for the redirect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.exapmle.com/index.html">http://www.exapmle.com/index.html</a></para>
        /// </summary>
        [NameInMap("TargetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// <para>The redirect type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>static</c>: Static mode.</para>
        /// </description></item>
        /// <item><description><para><c>dynamic</c>: Dynamic mode.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

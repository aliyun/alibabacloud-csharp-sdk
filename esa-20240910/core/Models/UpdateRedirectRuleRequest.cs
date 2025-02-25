// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRedirectRuleRequest : TeaModel {
        /// <summary>
        /// <para>Configuration ID. It can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2867474.html">ListRedirectRules</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3528160969****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Preserve query string. The value range is:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ReserveQueryString")]
        [Validation(Required=false)]
        public string ReserveQueryString { get; set; }

        /// <summary>
        /// <para>Rule content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Rule enable status, supports:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: indicates enabled.</description></item>
        /// <item><description><b>off</b>: indicates disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>Rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The response status code used by the node when responding to the client with a redirect address. The value range is:</para>
        /// <list type="bullet">
        /// <item><description>301</description></item>
        /// <item><description>302</description></item>
        /// <item><description>303</description></item>
        /// <item><description>307</description></item>
        /// <item><description>308</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>301</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>Target URL after redirection.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.exapmle.com/index.html">http://www.exapmle.com/index.html</a></para>
        /// </summary>
        [NameInMap("TargetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// <para>Redirect type. The value range is:</para>
        /// <list type="bullet">
        /// <item><description>static: static mode.</description></item>
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

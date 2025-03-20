// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRewriteUrlRuleRequest : TeaModel {
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
        /// <para>Query string rewrite type. Value range:</para>
        /// <list type="bullet">
        /// <item><description>static: static mode.</description></item>
        /// <item><description>dynamic: dynamic mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("RewriteQueryStringType")]
        [Validation(Required=false)]
        public string RewriteQueryStringType { get; set; }

        /// <summary>
        /// <para>URI rewrite type. Value range:</para>
        /// <list type="bullet">
        /// <item><description>static: static mode.</description></item>
        /// <item><description>dynamic: dynamic mode.</description></item>
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
        /// <para>Rule content, using conditional expressions to match user requests. This parameter is not required when adding a global configuration. There are two usage scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Match all incoming requests: set the value to true</description></item>
        /// <item><description>Match specific requests: set the value to a custom expression, for example: (http.host eq \&quot;video.example.com\&quot;)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Rule switch. This parameter is not required when adding a global configuration. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: enable.</description></item>
        /// <item><description>off: disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>Rule name. This parameter is not required when adding a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with version management enabled, you can use this parameter to specify the effective version of the site configuration, defaulting to version 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

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

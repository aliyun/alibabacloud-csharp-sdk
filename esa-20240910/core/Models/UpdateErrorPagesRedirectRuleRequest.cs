// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateErrorPagesRedirectRuleRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The error code redirect configuration.</para>
        /// </summary>
        [NameInMap("ErrorPagesRedirect")]
        [Validation(Required=false)]
        public List<UpdateErrorPagesRedirectRuleRequestErrorPagesRedirect> ErrorPagesRedirect { get; set; }
        public class UpdateErrorPagesRedirectRuleRequestErrorPagesRedirect : TeaModel {
            /// <summary>
            /// <para>The HTTP status code used by the node when responding to the client with a redirect address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>400</description></item>
            /// <item><description>403</description></item>
            /// <item><description>404</description></item>
            /// <item><description>405</description></item>
            /// <item><description>414</description></item>
            /// <item><description>416</description></item>
            /// <item><description>500</description></item>
            /// <item><description>501</description></item>
            /// <item><description>502</description></item>
            /// <item><description>503</description></item>
            /// <item><description>504</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The destination URL after the redirect.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/test">http://example.com/test</a></para>
            /// </summary>
            [NameInMap("TargetURL")]
            [Validation(Required=false)]
            public string TargetURL { get; set; }

        }

        /// <summary>
        /// <para>The content of the rule, which uses a conditional expression to match user requests. You do not need to specify this parameter when you add a global configuration. This parameter applies to the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Match all incoming requests: Set the value to true.</description></item>
        /// <item><description>Match specific requests: Set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule. You do not need to specify this parameter when you add a global configuration. Valid values:</para>
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
        /// <para>The name of the rule. You do not need to specify this parameter when you add a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution sequence of the rule. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407498413****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}

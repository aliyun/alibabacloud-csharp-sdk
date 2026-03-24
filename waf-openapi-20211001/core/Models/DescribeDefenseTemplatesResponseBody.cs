// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F26D2F1-E288-5104-8518-05E240E337A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of protection templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeDefenseTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeDefenseTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The protection scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>waf_group</b>: Basic Protection.</para>
            /// </description></item>
            /// <item><description><para><b>antiscan</b>: Scan Protection.</para>
            /// </description></item>
            /// <item><description><para><b>ip_blacklist</b>: IP Blocklist.</para>
            /// </description></item>
            /// <item><description><para><b>custom_acl</b>: Custom Rule.</para>
            /// </description></item>
            /// <item><description><para><b>whitelist</b>: Allowlist.</para>
            /// </description></item>
            /// <item><description><para><b>region_block</b>: Geographic Blocking.</para>
            /// </description></item>
            /// <item><description><para><b>custom_response</b>: Custom Response.</para>
            /// </description></item>
            /// <item><description><para><b>cc</b>: HTTP Flood Protection.</para>
            /// </description></item>
            /// <item><description><para><b>tamperproof</b>: Webpage Tamper Protection.</para>
            /// </description></item>
            /// <item><description><para><b>dlp</b>: Data Loss Prevention.</para>
            /// </description></item>
            /// <item><description><para><b>bot_manager</b>: Bot Management.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>whitelist</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The sub-scenario for the Bot Management template. This parameter is returned only when <c>DefenseScene</c> is set to <c>bot_manager</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>web</b>: web protection</para>
            /// </description></item>
            /// <item><description><para><b>app</b>: app protection</para>
            /// </description></item>
            /// <item><description><para><b>basic</b>: basic protection</para>
            /// </description></item>
            /// <item><description><para><b>bot_custom_acl</b>: The protection template for advanced Custom Rules in Bot Management.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("DefenseSubScene")]
            [Validation(Required=false)]
            public string DefenseSubScene { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTemplate</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The last modification time of the protection template. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683776070000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56477</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template-blockarea1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The origin of the protection template to be created. The value is custom, which indicates a user-defined template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TemplateOrigin")]
            [Validation(Required=false)]
            public string TemplateOrigin { get; set; }

            /// <summary>
            /// <para>The status of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateStatus")]
            [Validation(Required=false)]
            public int? TemplateStatus { get; set; }

            /// <summary>
            /// <para>The type of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>user_default</b>: The user\&quot;s default protection template.</para>
            /// </description></item>
            /// <item><description><para><b>user_custom</b>: A custom protection template defined by the user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>The total number of protection templates returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

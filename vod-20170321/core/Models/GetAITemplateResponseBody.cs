// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAITemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>080DA371-8AC0-4CD4-4476-33E64282****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the AI template.</para>
        /// </summary>
        [NameInMap("TemplateInfo")]
        [Validation(Required=false)]
        public GetAITemplateResponseBodyTemplateInfo TemplateInfo { get; set; }
        public class GetAITemplateResponseBodyTemplateInfo : TeaModel {
            /// <summary>
            /// <para>The time when the AI template was created. The time is displayed in ISO 8601 format in UTC. The format is <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-08T06:50:45Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the AI template is the default template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: The template is the default template.</description></item>
            /// <item><description><b>NotDefault</b>: The template is not the default template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotDefault</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The time when the AI template was last modified. The time is displayed in ISO 8601 format in UTC. The format is <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-08T06:58:45Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The source of the AI template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>System</b>: system.</description></item>
            /// <item><description><b>Custom</b>: custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The detailed configuration of the AI template. The value is a JSON string. For more information, see <a href="~~89863#title-vd3-499-o36~~">AITemplateConfig</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AuditRange&quot;:[&quot;text-title&quot;,&quot;video&quot;],&quot;AuditContent&quot;:[&quot;screen&quot;],&quot;AuditItem&quot;:[&quot;terrorism&quot;,&quot;porn&quot;],&quot;AuditAutoBlock&quot;:&quot;yes&quot;}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The AI template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706a0063dd733f6a823ef32e0a5****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the AI template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoAITemplate</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The templatetype of the AI template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AIMediaAudit</b>: automated review.</description></item>
            /// <item><description><b>AIImage</b>: smart thumbnail.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AIMediaAudit</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

    }

}

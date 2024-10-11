// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddAITemplateRequest : TeaModel {
        /// <summary>
        /// <para>The detailed configurations of the AI template. The value must be a JSON string. For more information, see <a href="~~89863#title-vd3-499-o36~~">AITemplateConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuditItem&quot;:[&quot;terrorism&quot;,&quot;porn&quot;],&quot;AuditRange&quot;:[&quot;image-cover&quot;,&quot;text-title&quot;,&quot;video&quot;],&quot;AuditContent&quot;:[&quot;screen&quot;],&quot;AuditAutoBlock&quot;:&quot;yes&quot;}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The name of the AI template. The name can be up to 128 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI-media-test</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the AI template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AIMediaAudit</b>: automated review</description></item>
        /// <item><description><b>AIImage</b>: smart thumbnail</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AIMediaAudit</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

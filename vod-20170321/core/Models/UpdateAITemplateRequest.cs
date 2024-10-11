// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAITemplateRequest : TeaModel {
        /// <summary>
        /// <para>The detailed configurations of the AI template. The value is a JSON string. For more information, see <a href="~~89863#title-vd3-499-o36~~">AITemplateConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuditItem&quot;:[&quot;terrorism&quot;,&quot;porn&quot;],&quot;AuditRange&quot;:[&quot;text-title&quot;,&quot;video&quot;],&quot;AuditContent&quot;:[&quot;screen&quot;],&quot;AuditAutoBlock&quot;:&quot;yes&quot;}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The ID of the AI template. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/102930.html">AddAITemplate</a> operation to add an AI template if no AI template exists. The value of TemplateId in the response is the ID of the AI template.</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/102936.html">ListAITemplate</a> operation if the template already exists. The value of TemplateId in the response is the ID of the AI template.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1706a0063dd733f6a823ef32e0a5****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the AI template. The name can be up to 128 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoAITemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAITemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI template. You can obtain the template ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/102930.html">AddAITemplate</a> operation to add an AI template, the template ID is the value of the TemplateId parameter in the response.</description></item>
        /// <item><description>After the AI template is added, call the <a href="https://help.aliyun.com/document_detail/102936.html">ListAITemplate</a> operation to query the template ID, which is the value of the TemplateId parameter in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1706a0063dd733f6a823ef32e0a5****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}

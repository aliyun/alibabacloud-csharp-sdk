// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAITemplateRequest : TeaModel {
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

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAITemplateRequest : TeaModel {
        /// <summary>
        /// The ID of the AI template. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Call the [AddAITemplate](https://help.aliyun.com/document_detail/102930.html) operation to add an AI template if no AI template exists. The value of TemplateId in the response is the ID of the AI template.
        /// *   Call the [ListAITemplate](https://help.aliyun.com/document_detail/102936.html) operation if the template already exists. The value of TemplateId in the response is the ID of the AI template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}

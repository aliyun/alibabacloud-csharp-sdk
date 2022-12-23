// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAITemplateRequest : TeaModel {
        /// <summary>
        /// The ID of the AI template. You can use one of the following methods to obtain the ID of the AI template:
        /// 
        /// *   Call the [AddAITemplate](~~102930~~) operation to add an AI template if no AI template exists. The value of TemplateId from the response is the ID of the AI template.
        /// *   Call the [ListAITemplate](~~102936~~) operation if the template already exists. The value of TemplateId from the response is the ID of the AI template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}

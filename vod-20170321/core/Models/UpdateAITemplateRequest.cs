// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAITemplateRequest : TeaModel {
        /// <summary>
        /// The detailed configurations of the AI template. The value is a JSON string.
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// The ID of the AI template. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Call the [AddAITemplate](~~102930~~) operation to add an AI template if no AI template exists. The value of TemplateId in the response is the ID of the AI template.
        /// *   Call the [ListAITemplate](~~102936~~) operation if the template already exists. The value of TemplateId in the response is the ID of the AI template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The name of the AI template. The name can be up to 128 bytes in length.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}

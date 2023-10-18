/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddAITemplateRequest : TeaModel {
        /// <summary>
        /// The detailed configurations of the AI template. The value must be a JSON string. For more information, see [AITemplateConfig](~~89863#title-vd3-499-o36~~).
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// The name of the AI template. The name can be up to 128 bytes in length.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The type of the AI template. Valid values:
        /// 
        /// *   **AIMediaAudit**: automated review
        /// *   **AIImage**: smart thumbnail
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAITemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the AI template.
        /// </summary>
        [NameInMap("TemplateInfo")]
        [Validation(Required=false)]
        public GetAITemplateResponseBodyTemplateInfo TemplateInfo { get; set; }
        public class GetAITemplateResponseBodyTemplateInfo : TeaModel {
            /// <summary>
            /// The time when the AI template was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Indicates whether the template is the default AI template. Valid values:
            /// 
            /// *   **Default**
            /// *   **NotDefault**
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// The time when the AI template was modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The source of the AI template. Valid values:
            /// 
            /// *   **System**
            /// *   **Custom**
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The detailed configurations of the AI template. The value is a JSON string. For more information, see [AITemplateConfig](~~89863#title-vd3-499-o36~~).
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// The ID of the AI template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The name of the AI template.
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

}

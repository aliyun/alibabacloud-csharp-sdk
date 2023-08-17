// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow Facebook to automatically change the directory of the template. If you set this parameter to true, the review success rate of the template is improved. This parameter is valid only if TemplateType is set to WHATSAPP.
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// The category of the template if TemplateType is set to WHATSAPP. Valid values:
        /// 
        /// *   **UTILITY**: the transaction template
        /// *   **MARKETING**: the marketing template
        /// *   **AUTHENTICATION**: the authentication template
        /// 
        /// The category of the template if TemplateType is set to VIBER. Valid values:
        /// 
        /// *   **text**: the template that contains only text
        /// *   **image**: the template that contains only images
        /// *   **text_image_button**: the template that contains text, images, and buttons
        /// *   **text_button**: the template that contains text and buttons
        /// *   **document**: the template that contains only documents
        /// *   **video**: the template that contains only videos
        /// *   **text_video**: the template that contains text and videos
        /// *   **text_video_button**: the template that contains text, videos, and buttons
        /// *   **text_image**: the template that contains text and images
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The components of the message template.
        /// 
        /// > If Category is set to AUTHENTICATION, the Type sub-parameter of the Components parameter cannot be set to HEADER. If the value of Type is BODY or FOOTER, the Text sub-parameter of the Components parameter is empty.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// The space ID of the user within the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// The examples of variables that are used when you create the message template.
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string ExampleShrink { get; set; }

        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

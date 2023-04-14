// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateShrinkRequest : TeaModel {
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// The category of the template when the TemplateType parameter is set to WHATSAPP. Valid values:
        /// 
        /// *   **TRANSACTIONAL**: a transactional template
        /// *   **MARKETING**: a marketing template
        /// *   **OTP**: a one-time password template
        /// 
        /// The category of the template when the TemplateType parameter is set to VIBER. Valid values:
        /// 
        /// *   **text**: a text message template
        /// *   **image**: an image message template
        /// *   **text_image_button**: a template that contains multiple media objects, including text, image, and button
        /// *   **text_button**: a template that contains the text and button media objects
        /// *   **document**: a document message template
        /// *   **video**: a video message template
        /// *   **text_video**: a template that contains the text and video media objects
        /// *   **text_video_button**: a template that contains multiple media objects, including text, video, and button
        /// *   **text_image**: a template that contains the text and image media objects
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The list of components of the message template.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The ID of the WhatsApp account that you register.
        /// </summary>
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

        /// <summary>
        /// The ISV verification code, which is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The language that is used in the message template. For more information, see [Language codes](~~463420~~).
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The name of the message template.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the message template.
        /// 
        /// *   **WHATSAPP**
        /// *   **VIBER**
        /// *   LINE: the LINE message template. The LINE message template is under development.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

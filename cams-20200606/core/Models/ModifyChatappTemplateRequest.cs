// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateRequest : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The components of the message template.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ModifyChatappTemplateRequestComponents> Components { get; set; }
        public class ModifyChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// The buttons. This parameter is applicable only to components of the **BUTTONS** type.
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class ModifyChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// The phone number.
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// The text of the message to be sent.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// The type of the button.
                /// 
                /// *   **PHONE_NUMBER**: a phone number button
                /// *   **URL**: a URL button
                /// *   **QUICK_REPLY**: a quick reply button
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The URL to be visited after users click the button.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// The type of the URL. Valid values:
                /// 
                /// *   **static**: a static URL
                /// *   **dynamic**: a dynamic URL
                /// </summary>
                [NameInMap("UrlType")]
                [Validation(Required=false)]
                public string UrlType { get; set; }

            }

            /// <summary>
            /// The description.
            /// 
            /// > When the Type parameter is set to **HEADER** and the Format parameter is set to **IMAGE, DOCUMENT, or VIDEO**, you can specify a description.
            /// </summary>
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// The name of the file.
            /// 
            /// > When the Type parameter is set to **HEADER** and the Format parameter is set to **DOCUMENT**, you can specify a name for the file.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// The type of the media resources that are included in the message.
            /// 
            /// *   **TEXT**: text
            /// *   **IMAGE**: image
            /// *   **DOCUMENT**: document
            /// *   **VIDEO**: video
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The text of the message to be sent.
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("ThumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// The type of the component. Valid values:
            /// 
            /// *   **BODY**
            /// *   **HEADER**
            /// *   **FOOTER**
            /// *   **BUTTONS**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The URL of the material.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The space ID of the user under the ISV account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The ID of the WhatsApp Business account under the independent software vendor (ISV) account.
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
        public Dictionary<string, string> Example { get; set; }

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
        /// The code of the message template.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

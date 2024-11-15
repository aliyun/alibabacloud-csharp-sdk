// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow Facebook to automatically change the directory of the template. If you set this parameter to true, the review success rate of the template is improved. This parameter is valid only when TemplateType is set to WHATSAPP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// <para>The category of the template if TemplateType is set to WHATSAPP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UTILITY</b>: the transaction template</description></item>
        /// <item><description><b>MARKETING</b>: the marketing template</description></item>
        /// <item><description><b>AUTHENTICATION</b>: the authentication template</description></item>
        /// </list>
        /// <para>The category of the template if TemplateType is set to VIBER. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>text</b>: the template that contains only text</description></item>
        /// <item><description><b>image</b>: the template that contains only images</description></item>
        /// <item><description><b>text_image_button</b>: the template that contains text, images, and buttons</description></item>
        /// <item><description><b>text_button</b>: the template that contains text and buttons</description></item>
        /// <item><description><b>document</b>: the template that contains only documents</description></item>
        /// <item><description><b>video</b>: the template that contains only videos</description></item>
        /// <item><description><b>text_video</b>: the template that contains text and videos</description></item>
        /// <item><description><b>text_video_button</b>: the template that contains text, videos, and buttons</description></item>
        /// <item><description><b>text_image</b>: the template that contains text and images</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The code of the message template.</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The components of the message template.</para>
        /// <remarks>
        /// <para> If Category is set to AUTHENTICATION, the Type sub-parameter of the Components parameter cannot be set to HEADER. If the Type sub-parameter is set to BODY or FOOTER, the Text sub-parameter of the Components parameter must be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// <para>The note indicating that customers cannot share verification codes with others. The note is displayed in the message body. This parameter is valid if Category is set to AUTHENTICATION and the Type sub-parameter of the Components parameter is set to BODY for a WhatsApp message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// <para>The buttons. Specify this parameter only if you set the Type sub-parameter of the Components parameter to <b>BUTTONS</b>.</para>
            /// <remarks>
            /// <h4></h4>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>A marketing or utility WhatsApp message template can contain up to 10 buttons.</para>
            /// </description></item>
            /// <item><description><para>A WhatsApp message template can contain only one phone call button.</para>
            /// </description></item>
            /// <item><description><para>A WhatsApp message template can contain up to two URL buttons.</para>
            /// </description></item>
            /// <item><description><para>In a WhatsApp message template, a quick reply button cannot be used together with a phone call button or a URL button.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// <para>The text of the one-tap autofill button. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP for a WhatsApp message template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Autofill</para>
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// <para>The coupon code. It can contain only letters and digits. You can set this parameter to a variable such as $(couponCode). Specify the value of couponCode when you send a message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120293</para>
                /// </summary>
                [NameInMap("CouponCode")]
                [Validation(Required=false)]
                public string CouponCode { get; set; }

                /// <summary>
                /// <para>The Flow action.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_EXCHANGE</description></item>
                /// <item><description>NAVIGATE</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NAVIGATE</para>
                /// </summary>
                [NameInMap("FlowAction")]
                [Validation(Required=false)]
                public string FlowAction { get; set; }

                /// <summary>
                /// <para>The Flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>479884093605183</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The unsubscribe button. This parameter is valid if Category is set to MARKETING and the Type sub-parameter of the Buttons parameter is set to QUICK_REPLY for a WhatsApp message template. Marketing messages will not be sent to customers if you configure message sending in the Chat App Message Service console and the customers click this button.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// <para>The first screen in the Flow. This parameter is required if FlowAction is set to NAVIGATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DETAILS</para>
                /// </summary>
                [NameInMap("NavigateScreen")]
                [Validation(Required=false)]
                public string NavigateScreen { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The app package name that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP for a WhatsApp message template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.demo</para>
                /// </summary>
                [NameInMap("PackageName")]
                [Validation(Required=false)]
                [Obsolete]
                public string PackageName { get; set; }

                /// <summary>
                /// <para>The phone number. This parameter is valid only when the Type sub-parameter of the Buttons parameter is set to <b>PHONE_NUMBER</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>+861368897****</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The app signing key hash that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP for a WhatsApp message template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wi299382</para>
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                [Obsolete]
                public string SignatureHash { get; set; }

                /// <summary>
                /// <para>List of supported apps.</para>
                /// </summary>
                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class CreateChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    /// <summary>
                    /// <para>The name of the Android application package. This parameter is required if you create an Android application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.kuaidian.waimaistaff</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>WhatsApp template is required when Category is Authoritative and Button Type is ONE_TAP/ZERO-TAP, indicating the signature hash value of the WhatsApp application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ieid83kdiek</para>
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                }

                /// <summary>
                /// <para>The display name of the button.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Call Me</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The type of the button. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PHONE_NUMBER</b>: phone call button</description></item>
                /// <item><description><b>URL</b>: URL button</description></item>
                /// <item><description><b>QUICK_REPLY</b>: quick reply button</description></item>
                /// <item><description><b>COPY_CODE</b>: copy code button</description></item>
                /// <item><description><b>ONE_TAP</b>: one-tap autofill button if Category is set to AUTHENTICATION</description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If Category is set to AUTHENTICATION for a WhatsApp message template, you can add only one button to the WhatsApp message template and you must set the Type sub-parameter of the Buttons parameter to COPY_CODE or ONE_TAP. If Type is set to COPY_CODE, the Text sub-parameter of the Buttons parameter is required. If Type is set to ONE_TAP, the Text, SignatureHash, PackageName, and AutofillText sub-parameters of the Buttons parameter are required. The value of Text is displayed if the desired app is not installed on the device. The value of Text indicates that you must manually copy the verification code.</para>
                /// </description></item>
                /// <item><description><para>You can add only one button to a Viber message template, and you must set the Type sub-parameter of the Buttons parameter to URL.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHONE_NUMBER</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URL to be accessed when you click the URL button.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The type of the URL. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>static</b></description></item>
                /// <item><description><b>dynamic</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("UrlType")]
                [Validation(Required=false)]
                public string UrlType { get; set; }

            }

            /// <summary>
            /// <para>The description of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a video</para>
            /// </summary>
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            /// <summary>
            /// <para>The carousel cards of the carousel template.</para>
            /// </summary>
            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class CreateChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// <para>The components of the carousel card.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class CreateChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    /// <summary>
                    /// <para>The buttons. Specify this parameter only if you set the Type sub-parameter of the CardComponents parameter to BUTTONS. A carousel card can contain up to two buttons.</para>
                    /// </summary>
                    [NameInMap("Buttons")]
                    [Validation(Required=false)]
                    public List<CreateChatappTemplateRequestComponentsCardsCardComponentsButtons> Buttons { get; set; }
                    public class CreateChatappTemplateRequestComponentsCardsCardComponentsButtons : TeaModel {
                        /// <summary>
                        /// <para>The phone number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>+8613800</para>
                        /// </summary>
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        /// <summary>
                        /// <para>The text of the button.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Call me</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>The type of the button. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>PHONE_NUMBER</b>: phone call button</description></item>
                        /// <item><description><b>URL</b>: URL button</description></item>
                        /// <item><description><b>QUICK_REPLY</b>: quick reply button</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PHONE_NUMBER</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The URL to which you are redirected when you click the URL button.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://alibaba.com/xx">https://alibaba.com/xx</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        /// <summary>
                        /// <para>The type of the URL. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>static</b></description></item>
                        /// <item><description><b>dynamic</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>static</para>
                        /// </summary>
                        [NameInMap("UrlType")]
                        [Validation(Required=false)]
                        public string UrlType { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of the media resource. This parameter is valid if the Type sub-parameter of the CardComponents parameter is set to HEADER. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>IMAGE</b></description></item>
                    /// <item><description><b>VIDEO</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IMAGE</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The body content of the carousel card.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Who is the very powerful team</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The type of the component. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>BODY</b></description></item>
                    /// <item><description><b>HEADER</b></description></item>
                    /// <item><description><b>BUTTONS</b></description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BODY</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The URL of the media resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://alibaba.com/img.png">https://alibaba.com/img.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The validity period of the verification code in the WhatsApp authentication template. Unit: minutes. This parameter is valid only when Category is set to AUTHENTICATION and the Type sub-parameter of the Components parameter is set to FOOTER. The validity period of the verification code is displayed in the footer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CodeExpirationMinutes")]
            [Validation(Required=false)]
            public int? CodeExpirationMinutes { get; set; }

            /// <summary>
            /// <para>The length of the video in the Viber message template. Unit: seconds. Valid values: 0 to 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The name of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video name</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The type of the document attached in the Viber message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docx</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The type of the media resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TEXT</b></description></item>
            /// <item><description><b>IMAGE</b></description></item>
            /// <item><description><b>DOCUMENT</b></description></item>
            /// <item><description><b>VIDEO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Specifies whether the coupon code has an expiration time. Specify this parameter if the Type sub-parameter of the Components parameter is set to LIMITED_TIME_OFFER.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasExpiration")]
            [Validation(Required=false)]
            public bool? HasExpiration { get; set; }

            /// <summary>
            /// <para>The text of the message that you want to send.</para>
            /// <remarks>
            /// <para> If Category is set to AUTHENTICATION, the Text sub-parameter of the Components parameter must be empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hello whatsapp</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The thumbnail URL of the video in the Viber message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn.multiplymall.mobiapp.cloud/yunmall/B-LM-LMALL202207130001/20220730/d712a057-a6af-4513-bbe6-7ee57ea60983.png?x-oss-process=image/resize,w_100">https://cdn.multiplymall.mobiapp.cloud/yunmall/B-LM-LMALL202207130001/20220730/d712a057-a6af-4513-bbe6-7ee57ea60983.png?x-oss-process=image/resize,w_100</a></para>
            /// </summary>
            [NameInMap("ThumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// <para>The type of the component. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BODY</b></description></item>
            /// <item><description><b>HEADER</b></description></item>
            /// <item><description><b>FOOTER</b></description></item>
            /// <item><description><b>BUTTONS</b></description></item>
            /// <item><description><b>CAROUSEL</b></description></item>
            /// <item><description><b>LIMITED_TIME_OFFER</b></description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>In a WhatsApp message template, a <b>Body</b> component cannot exceed 1,024 characters in length. A <b>HEADER</b> or <b>FOOTER</b> component cannot exceed 60 characters in length.</para>
            /// </description></item>
            /// <item><description><para><b>FOOTER</b>, <b>CAROUSEL</b>, and <b>LIMITED_TIME_OFFER</b> components are not supported in Viber message templates.</para>
            /// </description></item>
            /// <item><description><para>In Viber message templates, media resources such as images, videos, and documents are placed in the <b>HEADER</b> component. If a Viber message contains text and an image, the image is placed below the text in the message received on a device.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BODY</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the media resource.</para>
            /// <remarks>
            /// <para> We recommend that you use 800 × 800 images in Viber message templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://image.developer.aliyundoc.com">https://image.developer.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The space ID of the user within the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The WhatsApp Business account (WABA) ID of the user within the independent software vendor (ISV) account.</para>
        /// <remarks>
        /// <para>CustWabaId is an obsolete parameter. Use CustSpaceId instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65921621816****</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The examples of variables that are used when you create the message template.</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        /// <summary>
        /// <para>The independent software vendor (ISV) verification code, which is used to verify whether the user is authorized by the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The language that is used in the message template. For more information, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>Validity period of authentication template message sending in WhatsApp</para>
        /// <remarks>
        /// <para>This attribute requires providing waba in advance to Alibaba operators to open the whitelist, otherwise it will result in template submission failure</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        /// <summary>
        /// <para>The name of the message template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the message template.</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b></description></item>
        /// <item><description><b>VIBER</b></description></item>
        /// <item><description>LINE: the Line message template. This type of message template will be released later.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

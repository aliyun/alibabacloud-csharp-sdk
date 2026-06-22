// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Indicates whether to allow Facebook to automatically change the category of the template. This can increase the approval rate of the template. This parameter is valid only when TemplateType is set to WHATSAPP.</para>
        /// <remarks>
        /// <para>Notice: This property is deprecated. WhatsApp no longer supports this property.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// <para>WhatsApp template categories:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: Transactional.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: Marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: Authentication.</para>
        /// </description></item>
        /// </list>
        /// <para>Viber template categories:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: Transactional.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: Marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: Authentication.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTILITY</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>The list of message template components.</para>
        /// <remarks>
        /// <para>When Category is set to AUTHENTICATION, the Components array cannot contain a component of the HEADER type. If the component type is BODY or FOOTER, the Text parameter must be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// <para>This parameter is valid for WhatsApp templates when Category is set to AUTHENTICATION and the component type is Body. It indicates that a security recommendation is displayed above the body, advising the user not to share the verification code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// <para>The list of buttons. This parameter applies only to the <b>BUTTONS</b> component.</para>
            /// <remarks>
            /// <para>Number of buttons for WhatsApp</para>
            /// <list type="bullet">
            /// <item><description><para>For MARKETING or UTILITY templates, you can add up to 10 buttons.</para>
            /// </description></item>
            /// <item><description><para>You can add only one button of the PHONE_NUMBER type.</para>
            /// </description></item>
            /// <item><description><para>You can add up to two buttons of the URL type.</para>
            /// </description></item>
            /// <item><description><para>Buttons of the QUICK_REPLY type cannot be mixed with buttons of the PHONE_NUMBER or URL type.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Number of buttons for Viber</para>
            /// <list type="bullet">
            /// <item><description><para>Only one button of the URL type is allowed.</para>
            /// </description></item>
            /// <item><description><para>If the HEADER component contains a video, the button type is URL, but you cannot set a URL.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// <para>This parameter is required for WhatsApp templates when Category is set to AUTHENTICATION and the button type is ONE_TAP or ZERO_TAP. It specifies the button text for the WhatsApp autofill action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Autofill</para>
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// <para>The value of the coupon code. It supports only letters and digits. You can pass a variable such as $(couponCode) and then pass the actual coupon code when sending the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120293</para>
                /// </summary>
                [NameInMap("CouponCode")]
                [Validation(Required=false)]
                public string CouponCode { get; set; }

                /// <summary>
                /// <para>The flow data event type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>DATA_EXCHANGE: Data exchange.</para>
                /// </description></item>
                /// <item><description><para>NAVIGATE: Navigation.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NAVIGATE</para>
                /// </summary>
                [NameInMap("FlowAction")]
                [Validation(Required=false)]
                public string FlowAction { get; set; }

                /// <summary>
                /// <para>The flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>479884093605****</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>This parameter is valid for WhatsApp templates when Category is set to Marketing and the button type is QUICK_REPLY. It indicates that the button is a marketing opt-out button. If a customer clicks this button and you have configured sending control operations in ChatApp, subsequent marketing messages will not be sent to the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// <para>The screen to navigate to. This parameter is required when FlowAction is set to NAVIGATE.</para>
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
                /// <para>Use the properties under SupportedApps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.demo</para>
                /// </summary>
                [NameInMap("PackageName")]
                [Validation(Required=false)]
                [Obsolete]
                public string PackageName { get; set; }

                /// <summary>
                /// <para>The phone number. This parameter is valid only when the button type is <b>PHONE_NUMBER</b>.</para>
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
                /// <para>Use the properties under SupportedApps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wi299382</para>
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                [Obsolete]
                public string SignatureHash { get; set; }

                /// <summary>
                /// <para>The list of supported apps.</para>
                /// </summary>
                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class CreateChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required for WhatsApp templates when Category is set to AUTHENTICATION and the button type is ONE_TAP or ZERO_TAP. It specifies the package name of the app that WhatsApp will launch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.kuaidian.waimaistaff</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required for WhatsApp templates when Category is set to AUTHENTICATION and the button type is ONE_TAP or ZERO_TAP. It specifies the signature hash of the app that WhatsApp will launch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ieid83kdiek</para>
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                }

                /// <summary>
                /// <para>The name displayed on the button.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Call Me</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The button type.</para>
                /// <list type="bullet">
                /// <item><description><para><b>PHONE_NUMBER</b>: A call button.</para>
                /// </description></item>
                /// <item><description><para><b>URL</b>: A URL button.</para>
                /// </description></item>
                /// <item><description><para><b>QUICK_REPLY</b>: A quick reply button.</para>
                /// </description></item>
                /// <item><description><para><b>COPY_CODE</b>: A button to copy a verification code or coupon code.</para>
                /// </description></item>
                /// <item><description><para><b>ONE_TAP</b>: An autofill button for AUTHENTICATION templates.</para>
                /// </description></item>
                /// <item><description><para><b>ZERO_TAP</b>: An autofill button for AUTHENTICATION templates.</para>
                /// </description></item>
                /// <item><description><para><b>MPM</b>: A multi-product message.</para>
                /// </description></item>
                /// <item><description><para><b>CATALOG</b>: A catalog.</para>
                /// </description></item>
                /// <item><description><para><b>FLOW</b>: Opens a WhatsApp flow.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>For WhatsApp templates, if Category is set to AUTHENTICATION, only one button is allowed. The button type must be COPY_CODE or ONE_TAP. If you set the button type to COPY_CODE, the Text parameter is required. If you set the button type to ONE_TAP, the Text (the name of the copy code button displayed on the client if the destination app is not installed), SignatureHash, PackageName, and AutofillText parameters are required.</para>
                /// </description></item>
                /// <item><description><para>For Viber templates, only one button is allowed, and it must be of the URL type.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHONE_NUMBER</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URL that is visited when the URL button is clicked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The URL type.</para>
                /// <list type="bullet">
                /// <item><description><para><b>static</b>: Static</para>
                /// </description></item>
                /// <item><description><para><b>dynamic</b>: Dynamic</para>
                /// </description></item>
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
            /// <para>The description of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a video</para>
            /// </summary>
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            /// <summary>
            /// <para>The list of cards for a carousel template.</para>
            /// </summary>
            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class CreateChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// <para>The list of controls in the carousel card.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class CreateChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    /// <summary>
                    /// <para>The list of buttons. This parameter applies only to the BUTTONS component. Each card in a carousel can have a maximum of two buttons.</para>
                    /// </summary>
                    [NameInMap("Buttons")]
                    [Validation(Required=false)]
                    public List<CreateChatappTemplateRequestComponentsCardsCardComponentsButtons> Buttons { get; set; }
                    public class CreateChatappTemplateRequestComponentsCardsCardComponentsButtons : TeaModel {
                        /// <summary>
                        /// <para>The phone number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>+86138007****</para>
                        /// </summary>
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        /// <summary>
                        /// <para>The button text.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Call me</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>The button type.</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>PHONE_NUMBER</b>: A call button.</para>
                        /// </description></item>
                        /// <item><description><para><b>URL</b>: A URL button.</para>
                        /// </description></item>
                        /// <item><description><para><b>QUICK_REPLY</b>: A quick reply button.</para>
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
                        /// <para>The URL that is visited when the button is clicked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://alibaba.com/xx">https://alibaba.com/xx</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        /// <summary>
                        /// <para>The URL type.</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>static</b>: Static</para>
                        /// </description></item>
                        /// <item><description><para><b>dynamic</b>: Dynamic</para>
                        /// </description></item>
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
                    /// <para>The type of the media resource. This parameter is valid when Type is set to HEADER.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>IMAGE</b>: image</para>
                    /// </description></item>
                    /// <item><description><para><b>VIDEO</b>: video</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IMAGE</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The content of the BODY component in the carousel card.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Who is the very powerful team</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The component type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>BODY</b></para>
                    /// </description></item>
                    /// <item><description><para><b>HEADER</b></para>
                    /// </description></item>
                    /// <item><description><para><b>BUTTONS</b></para>
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
                    /// <para>The path of the media resource.</para>
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
            /// <para>The validity period of the verification code for a WhatsApp AUTHENTICATION template, in minutes. This parameter is valid only for WhatsApp messages when Category is set to AUTHENTICATION and the component type is Footer. This information is displayed in the footer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CodeExpirationMinutes")]
            [Validation(Required=false)]
            public int? CodeExpirationMinutes { get; set; }

            /// <summary>
            /// <para>The duration of the video in a Viber video message, in seconds. The value ranges from 0 to 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Express delivery video</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file type of a Viber file message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docx</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The type of the media resource.</para>
            /// <list type="bullet">
            /// <item><description><para><b>TEXT</b>: text</para>
            /// </description></item>
            /// <item><description><para><b>IMAGE</b>: image</para>
            /// </description></item>
            /// <item><description><para><b>DOCUMENT</b>: document</para>
            /// </description></item>
            /// <item><description><para><b>VIDEO</b>: video</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TEXT</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Indicates whether the coupon code has an expiration time. This parameter is used when type is set to LIMITED_TIME_OFFER.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasExpiration")]
            [Validation(Required=false)]
            public bool? HasExpiration { get; set; }

            /// <summary>
            /// <para>The text of the message to send.</para>
            /// <remarks>
            /// <para>For WhatsApp templates, if Category is set to AUTHENTICATION, this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hello whatsapp</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The thumbnail of a Viber message that contains a video.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn.multiplymall.mobiapp.cloud/yunmall/B-LM-LMALL202207130001/20220730/d712a057-a6af-4513-bbe6-7ee57ea60983.png?x-oss-process=image/resize,w_100">https://cdn.multiplymall.mobiapp.cloud/yunmall/B-LM-LMALL202207130001/20220730/d712a057-a6af-4513-bbe6-7ee57ea60983.png?x-oss-process=image/resize,w_100</a></para>
            /// </summary>
            [NameInMap("ThumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// <para>The component type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BODY</b></para>
            /// </description></item>
            /// <item><description><para><b>HEADER</b></para>
            /// </description></item>
            /// <item><description><para><b>FOOTER</b></para>
            /// </description></item>
            /// <item><description><para><b>BUTTONS</b></para>
            /// </description></item>
            /// <item><description><para><b>CAROUSEL</b></para>
            /// </description></item>
            /// <item><description><para><b>LIMITED_TIME_OFFER</b></para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>For WhatsApp templates, the BODY component can contain up to 1,024 characters. The HEADER and FOOTER components can contain up to 60 characters.</para>
            /// </description></item>
            /// <item><description><para>For Viber templates, the FOOTER, CAROUSEL, and LIMITED_TIME_OFFER types are invalid.</para>
            /// </description></item>
            /// <item><description><para>For Viber templates, images, videos, and files are placed in the HEADER component. The client displays the image below the text. The text is placed in the BODY component.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BODY</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The path of the media resource.</para>
            /// <remarks>
            /// <para>For Viber templates, the recommended image size is 800 × 800 pixels.</para>
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
        /// <para>The Space ID of the ISV sub-customer or the instance ID of the direct customer.</para>
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
        /// <para>The WhatsApp Business Account (WABA) ID of the independent software vendor (ISV) customer.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Use CustSpaceId instead.</para>
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
        /// <para>An example of how to create a template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        /// <summary>
        /// <para>The ISV verification code, used to verify whether the RAM user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The template language. For more information about language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the template message in WhatsApp.</para>
        /// <list type="bullet">
        /// <item><description><para>For AUTHENTICATION templates, the value ranges from 30 to 900.</para>
        /// </description></item>
        /// <item><description><para>For UTILITY templates, the value ranges from 30 to 43200.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// <list type="bullet">
        /// <item><description><para><b>WHATSAPP</b></para>
        /// </description></item>
        /// <item><description><para><b>VIBER</b></para>
        /// </description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The templatetype is immutable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>A list of message template components.</para>
        /// <remarks>
        /// <para>When Category is AUTHENTICATION, Components cannot contain a node with Type set to HEADER. If Type is BODY or FOOTER, the Text content is empty and is automatically generated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ModifyChatappTemplateRequestComponents> Components { get; set; }
        public class ModifyChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// <para>For WhatsApp templates, this is valid when Category is AUTHENTICATION and Component Type is Body. It indicates that a message is displayed above the body, advising users not to share the verification code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// <para>A list of buttons. This applies only to the <c>BUTTONS</c> component.</para>
            /// <remarks>
            /// <para>Number of buttons for WhatsApp:</para>
            /// <list type="bullet">
            /// <item><description><para>For MARKETING or UTILITY templates, WhatsApp allows a maximum of 10 buttons.</para>
            /// </description></item>
            /// <item><description><para>Only one button of the PHONE_NUMBER type is allowed.</para>
            /// </description></item>
            /// <item><description><para>A maximum of two buttons of the URL type are allowed.</para>
            /// </description></item>
            /// <item><description><para>QUICK_REPLY buttons cannot be mixed with PHONE_NUMBER or URL buttons.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class ModifyChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// <para>Required for WhatsApp templates when Category is AUTHENTICATION and Button Type is ONE_TAP or ZERO_TAP. This is the button text for the WhatsApp Autofill action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Autofill</para>
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// <para>The coupon code. It supports only letters and numbers. You can pass a variable, such as \<c>$(couponCode)\\</c>, and provide the actual coupon code at the time of sending.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120293</para>
                /// </summary>
                [NameInMap("CouponCode")]
                [Validation(Required=false)]
                public string CouponCode { get; set; }

                /// <summary>
                /// <para>The Flow data event type. Valid values:</para>
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
                /// <para>The Flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>664597077870605</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>For WhatsApp templates, this is valid when Category is Marketing and Button type is QUICK_REPLY. It indicates that the button is a marketing opt-out button. If a customer clicks this button and a sending control action is configured in ChatApp, subsequent marketing messages are not sent to the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// <para>The screen to navigate to. This is required when FlowAction is NAVIGATE.</para>
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
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>+861388888****</para>
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
                /// <para>29dkeke</para>
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                [Obsolete]
                public string SignatureHash { get; set; }

                /// <summary>
                /// <para>A list of supported apps.</para>
                /// </summary>
                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class ModifyChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    /// <summary>
                    /// <para>Required for WhatsApp templates when Category is AUTHENTICATION and Button Type is ONE_TAP or ZERO_TAP. This is the package name of the application launched by WhatsApp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.example.myapplication</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>Required for WhatsApp templates when Category is AUTHENTICATION and Button Type is ONE_TAP or ZERO_TAP. This is the signature hash of the application launched by WhatsApp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fk39kd93ks9</para>
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                }

                /// <summary>
                /// <para>The button text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>phone-button-text</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The button type.</para>
                /// <list type="bullet">
                /// <item><description><para><b>PHONE_NUMBER</b>: Call button</para>
                /// </description></item>
                /// <item><description><para><b>URL</b>: URL button</para>
                /// </description></item>
                /// <item><description><para><b>QUICK_REPLY</b>: Quick reply button</para>
                /// </description></item>
                /// <item><description><para><b>COPY_CODE</b>: Copy verification code or coupon code</para>
                /// </description></item>
                /// <item><description><para><b>ONE_TAP</b>: Backfill button for AUTHENTICATION templates</para>
                /// </description></item>
                /// <item><description><para><b>ZERO_TAP</b>: Backfill button for AUTHENTICATION templates</para>
                /// </description></item>
                /// <item><description><para><b>MPM</b>: Multi-product message</para>
                /// </description></item>
                /// <item><description><para><b>CATALOG</b>: Catalog</para>
                /// </description></item>
                /// <item><description><para><b>FLOW</b>: Open WhatsApp flow</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For WhatsApp templates where Category is AUTHENTICATION, only one button is allowed, and its type must be COPY_CODE or ONE_TAP. If the type is COPY_CODE, Text is required. If the type is ONE_TAP, the Text (the name of the copy code button, displayed when the target application is not installed), SignatureHash, PackageName, and AutofillText properties are required.</description></item>
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
                /// <para>The URL to visit when the button is clicked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.website.com/">https://www.website.com/</a>***</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The URL type.</para>
                /// <list type="bullet">
                /// <item><description><para><b>static</b></para>
                /// </description></item>
                /// <item><description><para><b>dynamic</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dynamic</para>
                /// </summary>
                [NameInMap("UrlType")]
                [Validation(Required=false)]
                public string UrlType { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// <remarks>
            /// <para>You can add a description when Type is HEADER and Format is IMAGE, <c>DOCUMENT</c>, or <c>VIDEO</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>This is a video</para>
            /// </summary>
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            /// <summary>
            /// <para>A list of cards for the Carousel template.</para>
            /// </summary>
            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class ModifyChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// <para>A list of controls in the Carousel card.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class ModifyChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    /// <summary>
                    /// <para>A list of buttons. This applies only to the BUTTONS component. Each Carousel card can have a maximum of two buttons.</para>
                    /// </summary>
                    [NameInMap("Buttons")]
                    [Validation(Required=false)]
                    public List<ModifyChatappTemplateRequestComponentsCardsCardComponentsButtons> Buttons { get; set; }
                    public class ModifyChatappTemplateRequestComponentsCardsCardComponentsButtons : TeaModel {
                        /// <summary>
                        /// <para>The phone number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>+861368893****</para>
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
                        /// <item><description><para><b>PHONE_NUMBER</b>: Call button</para>
                        /// </description></item>
                        /// <item><description><para><b>URL</b>: URL button</para>
                        /// </description></item>
                        /// <item><description><para><b>QUICK_REPLY</b>: Quick reply button</para>
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
                        /// <para>The URL to visit when the button is clicked.</para>
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
                        /// <item><description><para><b>static</b></para>
                        /// </description></item>
                        /// <item><description><para><b>dynamic</b></para>
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
                    /// <para>The media resource type. This is valid when Type is HEADER.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>IMAGE</b></para>
                    /// </description></item>
                    /// <item><description><para><b>VIDEO</b></para>
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
                    /// <para>The content of the BODY in the Carousel card.</para>
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
                    /// <para>The URL of the media asset.</para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The validity period of the verification code for a WhatsApp AUTHENTICATION template, in minutes. This is valid only for WhatsApp messages when Category is AUTHENTICATION and Component Type is Footer. This information is displayed in the footer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CodeExpirationMinutes")]
            [Validation(Required=false)]
            public int? CodeExpirationMinutes { get; set; }

            /// <summary>
            /// <para>This field is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// <remarks>
            /// <para>Specify the file name when Type is HEADER and <c>Format</c> is <c>DOCUMENT</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>This field is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docx</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The media resource type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>TEXT</b>: Text</para>
            /// </description></item>
            /// <item><description><para><b>IMAGE</b>: Image</para>
            /// </description></item>
            /// <item><description><para><b>DOCUMENT</b>: Document</para>
            /// </description></item>
            /// <item><description><para><b>VIDEO</b>: Video</para>
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
            /// <para>Indicates whether the coupon code has an expiration time. Used when type is LIMITED_TIME_OFFER.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasExpiration")]
            [Validation(Required=false)]
            public bool? HasExpiration { get; set; }

            /// <summary>
            /// <para>The text of the message.</para>
            /// <remarks>
            /// <para>If Category is AUTHENTICATION, this property is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hello chatapp</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>This field is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn.multiplymall.mobiapp.cloud/cloudcode/yc-165407506207478-165511576113195/20220905/ec5b9737-1507-4208-bb27-8da3958da961.jpg?x-oss-process=image/resize,w_100">https://cdn.multiplymall.mobiapp.cloud/cloudcode/yc-165407506207478-165511576113195/20220905/ec5b9737-1507-4208-bb27-8da3958da961.jpg?x-oss-process=image/resize,w_100</a></para>
            /// </summary>
            [NameInMap("ThumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// <para>The component type:</para>
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
            /// <item><description>For WhatsApp templates, the <c>BODY</c> component cannot exceed 1,024 characters. The <c>HEADER</c> and <c>FOOTER</c> components cannot exceed 60 characters.</description></item>
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
            /// <para>The URL of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.****.com/png_preview/00/10/24/1GygxVK3F4.jpg">https://img.****.com/png_preview/00/10/24/1GygxVK3F4.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer, or the instance ID of a direct customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28251486512358****</para>
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
        /// <para>The template example.</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        /// <summary>
        /// <para>The ISV verification code. This code is used to verify that the RAM user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ksiekdki39ksks93939</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The template language. For a list of language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the template message in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>For AUTHENTICATION templates, the value ranges from 30 to 900.</para>
        /// </description></item>
        /// <item><description><para>For UTILITY templates, the value ranges from 30 to 43,200.</para>
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
        /// <para>The message template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8472929283883</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

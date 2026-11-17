// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template category for Viber templates. This parameter is invalid for WhatsApp templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKETING</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause sending the template when its category is changed from Utility to Marketing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>The list of message template components.</para>
        /// <remarks>
        /// <para>When Category is AUTHENTICATION, Components cannot contain nodes with Type set to HEADER. When Type is BODY or FOOTER, if Text is empty, the content is automatically generated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ModifyChatappTemplateRequestComponents> Components { get; set; }
        public class ModifyChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// <para>The prompt displayed above the body that advises users not to share the verification code with others. This parameter is valid only for WhatsApp templates where Category is Authentication and Component Type is Body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// <para>The list of buttons. This parameter applies only to <b>BUTTONS</b> components.</para>
            /// <remarks>
            /// <para>WhatsApp button limits</para>
            /// <list type="bullet">
            /// <item><description>For MARKETING or UTILITY templates, a maximum of 10 buttons are allowed.</description></item>
            /// <item><description>Only one PHONE_NUMBER button is allowed.</description></item>
            /// <item><description>A maximum of two URL buttons are allowed.</description></item>
            /// <item><description>QUICK_REPLY buttons must not be mixed with PHONE_NUMBER or URL buttons.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class ModifyChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// <para>The button text for the WhatsApp autofill operation. This parameter is required for WhatsApp templates where Category is Authentication and Button Type is ONE_TAP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Autofill</para>
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// <para>The coupon code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23838jdjdj</para>
                /// </summary>
                [NameInMap("CouponCode")]
                [Validation(Required=false)]
                public string CouponCode { get; set; }

                /// <summary>
                /// <para>The flow data event type. Valid values: NAVIGATE and DATA_EXCHANGE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAVIGATE</para>
                /// </summary>
                [NameInMap("FlowAction")]
                [Validation(Required=false)]
                public string FlowAction { get; set; }

                /// <summary>
                /// <para>Flow id</para>
                /// 
                /// <b>Example:</b>
                /// <para>293882</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>Specifies whether the button is a marketing opt-out button. If a customer clicks this button and send control operations are configured on the Chat App Message Service platform, subsequent marketing messages are not sent to the customer. This parameter is valid only for WhatsApp templates where Category is Marketing and Button Type is QUICK_REPLY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// <para>The navigation screen. This parameter is required when FlowAction is NAVIGATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SIGN_UP</para>
                /// </summary>
                [NameInMap("NavigateScreen")]
                [Validation(Required=false)]
                public string NavigateScreen { get; set; }

                /// <summary>
                /// <para>The package name of the application invoked by WhatsApp. This parameter is valid for WhatsApp templates where Category is Authentication and Button Type is ONE_TAP or ZERO_TAP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.aliyun.pack.***</para>
                /// </summary>
                [NameInMap("PackageName")]
                [Validation(Required=false)]
                public string PackageName { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8613800**</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>The signature hash value of the application invoked by WhatsApp. This parameter is valid for WhatsApp templates where Category is Authentication and Button Type is ONE_TAP or ZERO_TAP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kdikie9398k</para>
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                public string SignatureHash { get; set; }

                /// <summary>
                /// <para>The applications supported by the ONE_TAP or ZERO_TAP verification code.</para>
                /// </summary>
                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class ModifyChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    /// <summary>
                    /// <para>The package name of the application invoked by WhatsApp. This parameter is valid for WhatsApp templates where Category is Authentication and Button Type is ONE_TAP or ZERO_TAP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.aliyun.pack.***</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>The signature hash value of the application invoked by WhatsApp. This parameter is valid for WhatsApp templates where Category is Authentication and Button Type is ONE_TAP or ZERO_TAP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kdikie9398k</para>
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                }

                /// <summary>
                /// <para>The text of the message to be sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CTA</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The validity period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10800</para>
                /// </summary>
                [NameInMap("TtlMinutes")]
                [Validation(Required=false)]
                public long? TtlMinutes { get; set; }

                /// <summary>
                /// <para>The button type. Valid values: PHONE_NUMBER, URL, and QUICK_REPLY.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URL to be accessed when the button is clicked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The URL type. Valid values: static and dynamic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("UrlType")]
                [Validation(Required=false)]
                public string UrlType { get; set; }

            }

            /// <summary>
            /// <para>The description. You can add a description when Type is Header and Format is IMGAGE, DOCUMENT, or VIDEO.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            /// <summary>
            /// <para>The list of carousel template cards.</para>
            /// </summary>
            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class ModifyChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// <para>The list of components in the carousel card.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class ModifyChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    /// <summary>
                    /// <para>The buttons in the carousel card. The button type, name, and order must be consistent across all cards. Each card can have a maximum of two buttons.</para>
                    /// </summary>
                    [NameInMap("Buttons")]
                    [Validation(Required=false)]
                    public List<ModifyChatappTemplateRequestComponentsCardsCardComponentsButtons> Buttons { get; set; }
                    public class ModifyChatappTemplateRequestComponentsCardsCardComponentsButtons : TeaModel {
                        /// <summary>
                        /// <para>The phone number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8613800**</para>
                        /// </summary>
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        /// <summary>
                        /// <para>The button text.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>The button type of the carousel template. Valid values: URL, PHONE_NUMBER, and QUICK_REQLY.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>URL</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The URL to be accessed when the button is clicked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://aliyun.com/image.png">https://aliyun.com/image.png</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        /// <summary>
                        /// <para>The URL type. Valid values: static and dynamic.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>static</para>
                        /// </summary>
                        [NameInMap("UrlType")]
                        [Validation(Required=false)]
                        public string UrlType { get; set; }

                    }

                    /// <summary>
                    /// <para>The header type in the carousel template. Only IMAGE and VIDEO are supported. The header must be consistent across all cards. Valid values: IMGAGE and VIDEO.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IMAGE</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The body content in the carousel card.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>body</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The component type. Valid values: BODY, HEADER, and BUTTONS.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HEADER</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The URL of the image or video in the header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://aliyun.com/image.png">https://aliyun.com/image.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The validity period of the verification code in minutes for WhatsApp authentication templates. This parameter is valid only for WhatsApp messages where Category is Authentication and Component Type is Footer. This information is displayed in the footer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CodeExpirationMinutes")]
            [Validation(Required=false)]
            public int? CodeExpirationMinutes { get; set; }

            /// <summary>
            /// <para>The duration of the Viber video message. Valid values: 0 to 600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The file name. You can specify a file name when Type is Header and Format is DOCUMENT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt.txt</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file type of the Viber file message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TEXT: Text.</description></item>
            /// <item><description>IMGAGE: Image.</description></item>
            /// <item><description>DOCUMENT: Document.</description></item>
            /// <item><description>VIDEO: Video.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>body</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Specifies whether the LTO template has an expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasExpiration")]
            [Validation(Required=false)]
            public bool? HasExpiration { get; set; }

            /// <summary>
            /// <para>The text of the message to be sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The thumbnail URL for a Viber video message.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.png">https://img.png</a></para>
            /// </summary>
            [NameInMap("ThumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// <para>The component type. Valid values: BODY, HEADER, FOOTER, and BUTTONS.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HEADER</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The media URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.png">https://img.png</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer or the instance ID of the direct customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-did***</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The WABA ID of the ISV customer. This parameter is deprecated. Use CustSpaceId instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>939***</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The variables in a key-value structure.</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ISV verification code, which is used to verify whether the RAM user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9393***</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The validity period for sending WhatsApp authentication template messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        /// <summary>
        /// <para>productSetId</para>
        /// 
        /// <b>Example:</b>
        /// <para>939***</para>
        /// </summary>
        [NameInMap("ProductSetId")]
        [Validation(Required=false)]
        public string ProductSetId { get; set; }

        /// <summary>
        /// <para>The message template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93938**</para>
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
        /// <para>The templatetype to modify. Valid values: WHATSAPP and VIBER. Default value: WHATSAPP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

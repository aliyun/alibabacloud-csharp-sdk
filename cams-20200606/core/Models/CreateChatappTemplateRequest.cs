// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow Facebook to automatically change the template category (to improve the template approval rate). This property is valid only when TemplateType is set to WHATSAPP.</para>
        /// <remarks>
        /// <para>Notice: This property has been deprecated. WhatsApp no longer supports this property.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// <para>WhatsApp template category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: transaction-related.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: identity verification.</para>
        /// </description></item>
        /// </list>
        /// <para>Viber template category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: transaction-related.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: marketing.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: identity verification.</para>
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

        /// <summary>
        /// <para>Specifies whether to pause template sending when a Utility template is changed to Marketing type. This property is valid only for WhatsApp templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>The list of message template components.</para>
        /// <remarks>
        /// <para>When Category=AUTHENTICATION, Components cannot contain nodes with Type=HEADER. When Type=BODY or FOOTER, the Text content must be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// <para>Valid for WhatsApp templates when Category is AUTHENTICATION and Component Type is Body. Displays a prompt above the Body advising not to share the verification code with others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// <para>The button list. Applicable only to <b>BUTTONS</b> components.</para>
            /// <remarks>
            /// <para>WhatsApp button quantity rules:</para>
            /// <list type="bullet">
            /// <item><description>For WhatsApp templates with Category MARKETING/UTILITY, a maximum of 10 buttons are allowed.</description></item>
            /// <item><description>Only 1 PHONE_NUMBER button is allowed.</description></item>
            /// <item><description>A maximum of 2 URL buttons are allowed.</description></item>
            /// <item><description>QUICK_REPLY buttons cannot appear in mixed order with PHONE_NUMBER/URL buttons.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Viber button quantity rules:</para>
            /// <list type="bullet">
            /// <item><description>Only URL type is supported, and only one button is allowed.</description></item>
            /// <item><description>When the HEADER contains a VIDEO, the button type is URL, but you cannot set a URL address.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// <para>Required for WhatsApp templates when Category is AUTHENTICATION and Button Type is ONE_TAP/ZERO_TAP. The button text for the WhatsApp Autofill operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Autofill</para>
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// <para>The coupon code value. Only letters and numbers are supported. You can pass in a variable such as $(couponCode) and provide the actual coupon code when sending.</para>
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
                /// <item><description><para>DATA_EXCHANGE: data exchange.</para>
                /// </description></item>
                /// <item><description><para>NAVIGATE: navigation.</para>
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
                /// <para>Flow ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>479884093605****</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>Valid for WhatsApp templates when Category is Marketing and Button type is QUICK_REPLY. Indicates the button is a marketing opt-out button. If the customer clicks this button and send control is configured on ChatApp, subsequent Marketing messages will not be sent to the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// <para>The navigate screen. Required when FlowAction=NAVIGATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DETAILS</para>
                /// </summary>
                [NameInMap("NavigateScreen")]
                [Validation(Required=false)]
                public string NavigateScreen { get; set; }

                /// <summary>
                /// <para>Use the properties under SupportedApps instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.demo</para>
                /// </summary>
                [NameInMap("PackageName")]
                [Validation(Required=false)]
                public string PackageName { get; set; }

                /// <summary>
                /// <para>The phone number. Valid only when the button type is <b>PHONE_NUMBER</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>+861368897****</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>Use the properties under SupportedApps instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wi299382</para>
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                public string SignatureHash { get; set; }

                /// <summary>
                /// <para>The list of supported applications.</para>
                /// </summary>
                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class CreateChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    /// <summary>
                    /// <para>Required for WhatsApp templates when Category is AUTHENTICATION and Button Type is ONE_TAP/ZERO_TAP. The package name of the application invoked by WhatsApp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.kuaidian.waimaistaff</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>Required for WhatsApp templates when Category is AUTHENTICATION and Button Type is ONE_TAP/ZERO_TAP. The signature hash value for the application invoked by WhatsApp.</para>
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
                /// <para>The button type.</para>
                /// <list type="bullet">
                /// <item><description><para><b>PHONE_NUMBER</b>: dial phone button</para>
                /// </description></item>
                /// <item><description><para><b>URL</b>: web button</para>
                /// </description></item>
                /// <item><description><para><b>QUICK_REPLY</b>: quick reply button</para>
                /// </description></item>
                /// <item><description><para><b>COPY_CODE</b>: copy verification code or coupon code</para>
                /// </description></item>
                /// <item><description><para><b>ONE_TAP</b>: autofill button for AUTHENTICATION templates</para>
                /// </description></item>
                /// <item><description><para><b>ZERO_TAP</b>: autofill button for AUTHENTICATION templates</para>
                /// </description></item>
                /// <item><description><para><b>MPM</b>: multi-product catalog</para>
                /// </description></item>
                /// <item><description><para><b>CATALOG</b>: catalog</para>
                /// </description></item>
                /// <item><description><para><b>FLOW</b>: open WhatsApp flow</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For WhatsApp templates with Category AUTHENTICATION, only one button is allowed, and the type can only be COPY_CODE/ONE_TAP. When COPY_CODE is selected, Text is required. When ONE_TAP is selected, Text (displayed when the target application is not installed on the device, representing the copy verification code button name), SignatureHash, PackageName, and AutofillText are required.</description></item>
                /// <item><description>Viber templates allow only one Button, and it must be URL type.</description></item>
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
                /// <para>The URL to visit when the link button is clicked.</para>
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
                /// <item><description><para><b>static</b>: static</para>
                /// </description></item>
                /// <item><description><para><b>dynamic</b>: dynamic</para>
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
            /// <para>The Carousel template card list.</para>
            /// </summary>
            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class CreateChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// <para>The list of components in the Carousel card.</para>
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class CreateChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    /// <summary>
                    /// <para>The button list. Applicable only to BUTTONS components. Each Carousel card can have a maximum of two buttons.</para>
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
                        /// <item><description><para><b>PHONE_NUMBER</b>: dial phone button</para>
                        /// </description></item>
                        /// <item><description><para><b>URL</b>: web button</para>
                        /// </description></item>
                        /// <item><description><para><b>QUICK_REPLY</b>: quick reply button</para>
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
                        /// <para>The URL that is accessed when the button is clicked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://alibaba.com/xx">https://alibaba.com/xx</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        /// <summary>
                        /// <para>The URL type. </para>
                        /// <list type="bullet">
                        /// <item><description><para><b>static</b>: Static.</para>
                        /// </description></item>
                        /// <item><description><para><b>dynamic</b>: Dynamic.</para>
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
                    /// <para>The media resource type. Valid when Type = HEADER.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>IMAGE</b>: image </para>
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
                    /// <para>The BODY content in the Carousel card.</para>
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
                    /// <para>The material path.</para>
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
            /// <para>The validity period (in minutes) of the verification code for WhatsApp AUTHENTICATION templates. Valid only for WhatsApp messages when Category is AUTHENTICATION and Component Type is Footer (displayed in the Footer position).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CodeExpirationMinutes")]
            [Validation(Required=false)]
            public int? CodeExpirationMinutes { get; set; }

            /// <summary>
            /// <para>The duration (in seconds) of Viber video messages. Valid values: 0 to 600.</para>
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
            /// <para>The file type for Viber file messages.</para>
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
            /// <para>Specifies whether the coupon code has an expiration time. This parameter is used when type = LIMITED_TIME_OFFER.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasExpiration")]
            [Validation(Required=false)]
            public bool? HasExpiration { get; set; }

            /// <summary>
            /// <para>The text of the message to be sent.</para>
            /// <remarks>
            /// <para>For WHATSAPP type, this property value is empty when Category=AUTHENTICATION.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hello whatsapp</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The thumbnail for Viber video messages.</para>
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
            /// <item><description>For WhatsApp templates, the <b>BODY</b> component cannot exceed 1024 characters. The <b>HEADER</b> and <b>FOOTER</b> components cannot exceed 60 characters.</description></item>
            /// <item><description>For Viber templates, the <b>FOOTER</b>, <b>CAROUSEL</b>, and <b>LIMITED_TIME_OFFER</b> types are invalid.</description></item>
            /// <item><description>For Viber templates, images, videos, and files are placed in the <b>HEADER</b> (the device displays images below the text). Text is placed in the <b>BODY</b>.</description></item>
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
            /// <para>The media resource path.</para>
            /// <remarks>
            /// <para>For Viber type, the recommended image size is 800 px × 800 px.</para>
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
        /// <para>The SpaceId of the ISV sub-customer or the direct customer instance ID.</para>
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
        /// <para>The ISV customer WabaId.</para>
        /// <remarks>
        /// <para>Deprecated parameter. Use CustSpaceId instead.</para>
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
        /// <para>The example for creating the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello_whatsapp</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ISV verification code, used to verify whether the sub-account is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The template language. For detailed language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) for template messages in WhatsApp.</para>
        /// <list type="bullet">
        /// <item><description>AUTHENTICATION: valid values range from 30 to 900. </description></item>
        /// <item><description>UTILITY: valid values range from 30 to 43200.</description></item>
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
        /// <para>productSetId</para>
        /// 
        /// <b>Example:</b>
        /// <para>9928**</para>
        /// </summary>
        [NameInMap("ProductSetId")]
        [Validation(Required=false)]
        public string ProductSetId { get; set; }

        /// <summary>
        /// <para>The templatetype. Valid values:</para>
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

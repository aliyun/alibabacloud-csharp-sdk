// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow Facebook to automatically change the category of the template to improve the approval rate. This property is valid only when TemplateType is set to WHATSAPP.</para>
        /// <remarks>
        /// <para>Notice: <b>[Deprecated]</b> WhatsApp no longer supports this property.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// <para>WhatsApp template categories:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: Transaction-related.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: Marketing templates.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: Authenticate identity.</para>
        /// </description></item>
        /// </list>
        /// <para>Viber template categories:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UTILITY</b>: Transaction-related.</para>
        /// </description></item>
        /// <item><description><para><b>MARKETING</b>: Marketing templates.</para>
        /// </description></item>
        /// <item><description><para><b>AUTHENTICATION</b>: Authenticate identity.</para>
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
        /// <para>Specifies whether to pause sending the template when a utility template is changed to a marketing template. This property is valid only for WhatsApp templates.</para>
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
        /// <para>When Category is set to AUTHENTICATION, Components cannot contain nodes with Type set to HEADER. Additionally, when Type is set to BODY or FOOTER, the Text content must be empty.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// <para>The security recommendation text displayed above the body to warn users not to share the verification code with others. This parameter is valid only for WhatsApp templates where Category is set to AUTHENTICATION and Component Type is set to BODY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// <para>The list of buttons. This parameter is only applicable to the <b>BUTTONS</b> component.</para>
            /// <remarks>
            /// <para>WhatsApp button limits:</para>
            /// <list type="bullet">
            /// <item><description>For MARKETING or UTILITY templates, a maximum of 10 buttons are allowed.</description></item>
            /// <item><description>Only one PHONE_NUMBER button is allowed.</description></item>
            /// <item><description>A maximum of two URL buttons are allowed.</description></item>
            /// <item><description>QUICK_REPLY buttons cannot be mixed with PHONE_NUMBER or URL buttons in an unordered manner.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Viber button limits:</para>
            /// <list type="bullet">
            /// <item><description>Only the URL type is supported, and only one button is allowed.</description></item>
            /// <item><description>When the HEADER is a VIDEO, the button type must be URL, but the URL address cannot be set.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// <para>The button text for the WhatsApp autofill operation. This parameter is required for WhatsApp templates where Category is set to AUTHENTICATION and Button Type is set to ONE_TAP or ZERO_TAP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Autofill</para>
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// <para>The coupon code value. Only letters and digits are supported. You can pass a variable such as $(couponCode) and specify the actual coupon code when sending the message.</para>
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
                /// <para>The flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>479884093605****</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>Specifies whether the button is a marketing opt-out button. If a customer clicks this button and send control operations are configured on the Chat App Message Service platform, subsequent marketing messages will not be sent to the customer. This parameter is valid only for WhatsApp templates where Category is set to Marketing and Button Type is set to QUICK_REPLY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// <para>The navigation screen. This parameter is required when FlowAction is set to NAVIGATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DETAILS</para>
                /// </summary>
                [NameInMap("NavigateScreen")]
                [Validation(Required=false)]
                public string NavigateScreen { get; set; }

                /// <summary>
                /// <para>Use the properties under SupportedApps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.demo</para>
                /// </summary>
                [NameInMap("PackageName")]
                [Validation(Required=false)]
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

                /// <summary>
                /// <para>Use the properties under SupportedApps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wi299382</para>
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                public string SignatureHash { get; set; }

                /// <summary>
                /// <para>The list of supported apps.</para>
                /// </summary>
                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class CreateChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    /// <summary>
                    /// <para>The package name of the app invoked by WhatsApp. This parameter is required for WhatsApp templates where Category is set to AUTHENTICATION and Button Type is set to ONE_TAP or ZERO_TAP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.kuaidian.waimaistaff</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>The signature hash value of the app invoked by WhatsApp. This parameter is required for WhatsApp templates where Category is set to AUTHENTICATION and Button Type is set to ONE_TAP or ZERO_TAP.</para>
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
                /// <para>The validity period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10800</para>
                /// </summary>
                [NameInMap("TtlMinutes")]
                [Validation(Required=false)]
                public long? TtlMinutes { get; set; }

                /// <summary>
                /// <para>The button type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>PHONE_NUMBER</b>: call button.</para>
                /// </description></item>
                /// <item><description><para><b>URL</b>: URL button.</para>
                /// </description></item>
                /// <item><description><para><b>QUICK_REPLY</b>: quick reply button.</para>
                /// </description></item>
                /// <item><description><para><b>COPY_CODE</b>: copy verification code or coupon code button.</para>
                /// </description></item>
                /// <item><description><para><b>ONE_TAP</b>: autofill button for AUTHENTICATION templates.</para>
                /// </description></item>
                /// <item><description><para><b>ZERO_TAP</b>: autofill button for AUTHENTICATION templates.</para>
                /// </description></item>
                /// <item><description><para><b>MPM</b>: multi-product message.</para>
                /// </description></item>
                /// <item><description><para><b>CATALOG</b>: catalog.</para>
                /// </description></item>
                /// <item><description><para><b>FLOW</b>: open WhatsApp flow.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For WhatsApp templates where Category is set to AUTHENTICATION, only one button is allowed, and its type must be COPY_CODE or ONE_TAP. If the type is COPY_CODE, Text is required. If the type is ONE_TAP, Text (displayed when the target app is not installed on the device, representing the name of the copy verification code button), SignatureHash, PackageName, and AutofillText are required.</description></item>
                /// <item><description>For Viber templates, only one button is allowed, and its type must be URL.</description></item>
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
                /// <para>The URL to be accessed when the link button is clicked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The URL type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>static</b>: static.</para>
                /// </description></item>
                /// <item><description><para><b>dynamic</b>: dynamic.</para>
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
            /// <para>The list of carousel template cards.</para>
            /// </summary>
            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class CreateChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// <para>The list of controls in the carousel card.</para>
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<CreateChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class CreateChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    /// <summary>
                    /// <para>The list of buttons. This parameter is only applicable to the BUTTONS component. Each carousel card can have a maximum of two buttons.</para>
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
                        /// <para>The button type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>PHONE_NUMBER</b>: call button.</para>
                        /// </description></item>
                        /// <item><description><para><b>URL</b>: URL button.</para>
                        /// </description></item>
                        /// <item><description><para><b>QUICK_REPLY</b>: quick reply button.</para>
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
                        /// <para>The URL to be accessed when the button is clicked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://alibaba.com/xx">https://alibaba.com/xx</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        /// <summary>
                        /// <para>The URL type. Valid values: </para>
                        /// <list type="bullet">
                        /// <item><description><para><b>static</b>: static.</para>
                        /// </description></item>
                        /// <item><description><para><b>dynamic</b>: dynamic.</para>
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
                    /// <para>The media resource type. This parameter is valid when Type is set to HEADER. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>IMAGE</b>: image. </para>
                    /// </description></item>
                    /// <item><description><para><b>VIDEO</b>: video.</para>
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
                    /// <para>The body content in the carousel card.</para>
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
                    /// <para>The media URL.</para>
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
            /// <para>The validity period of the verification code in minutes for WhatsApp AUTHENTICATION templates. This parameter is valid only for WhatsApp messages where Category is set to AUTHENTICATION and Component Type is set to FOOTER. This information is displayed in the footer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CodeExpirationMinutes")]
            [Validation(Required=false)]
            public int? CodeExpirationMinutes { get; set; }

            /// <summary>
            /// <para>The duration of the Viber video message in seconds. Valid values: 0 to 600.</para>
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
            /// <para>The file type of the Viber file message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docx</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The media resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>TEXT</b>: text.</para>
            /// </description></item>
            /// <item><description><para><b>IMAGE</b>: image.</para>
            /// </description></item>
            /// <item><description><para><b>DOCUMENT</b>: document.</para>
            /// </description></item>
            /// <item><description><para><b>VIDEO</b>: video.</para>
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
            /// <para>Specifies whether the coupon code has an expiration time. This parameter is used when Type is set to LIMITED_TIME_OFFER.</para>
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
            /// <para>For WhatsApp templates, when Category is set to AUTHENTICATION, this property is empty.</para>
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
            /// <item><description>For WhatsApp templates, the <b>BODY</b> component cannot exceed 1,024 characters in length. The <b>HEADER</b> and <b>FOOTER</b> components cannot exceed 60 characters in length.</description></item>
            /// <item><description>For Viber templates, the <b>FOOTER</b>, <b>CAROUSEL</b>, and <b>LIMITED_TIME_OFFER</b> types are invalid.</description></item>
            /// <item><description>In Viber templates, images, videos, and files are placed in the <b>HEADER</b> (the client displays the image below the text). Text is placed in the <b>BODY</b>.</description></item>
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
            /// <para>The URL of the media.</para>
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
        /// <para>The SpaceId of the ISV sub-customer or the instance ID of the direct customer.</para>
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
        /// <para>The WabaId of the ISV customer.</para>
        /// <remarks>
        /// <para><b>[Deprecated]</b> Use CustSpaceId instead.</para>
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
        /// <para>The example for creating a template.</para>
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
        /// <para>The ISV verification code used to verify whether the RAM user is authorized by the ISV.</para>
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
        /// <para>The validity period for sending template messages in WhatsApp.</para>
        /// <list type="bullet">
        /// <item><description>AUTHENTICATION: 30 to 900. </description></item>
        /// <item><description>UTILITY: 30 to 43200.</description></item>
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
        /// <para>The templatetype.</para>
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

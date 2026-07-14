// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The templatetype cannot be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to pause sending when a Utility template is changed to Marketing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("CategoryChangePaused")]
        [Validation(Required=false)]
        public bool? CategoryChangePaused { get; set; }

        /// <summary>
        /// <para>The list of message template components.</para>
        /// <remarks>
        /// <para>When Category is set to AUTHENTICATION, Components cannot contain a node with Type set to HEADER. When Type is set to BODY or FOOTER and the Text content is empty, the content is automatically generated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ModifyChatappTemplateRequestComponents> Components { get; set; }
        public class ModifyChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// <para>Valid for WhatsApp templates when Category is AUTHENTICATION and Component Type is Body. Displays a message in the Body section advising not to share the verification code with others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// <para>The button list. This parameter applies only to the <b>BUTTONS</b> component.</para>
            /// <remarks>
            /// <para>WhatsApp button limits:</para>
            /// <list type="bullet">
            /// <item><description>For WhatsApp templates with Category set to MARKETING or UTILITY, a maximum of 10 buttons are allowed.</description></item>
            /// <item><description>Only one PHONE_NUMBER button is allowed.</description></item>
            /// <item><description>A maximum of two URL buttons are allowed.</description></item>
            /// <item><description>QUICK_REPLY buttons cannot be mixed in random order with PHONE_NUMBER or URL buttons.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class ModifyChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// <para>Required when the WhatsApp template Category is AUTHENTICATION and Button Type is ONE_TAP or ZERO_TAP. The button text for the WhatsApp autofill operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Autofill</para>
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// <para>The coupon code value. Only letters and numbers are supported. You can pass in a variable such as $(couponCode) and provide the actual coupon code when sending the message.</para>
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
                /// <para>Flow ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>664597077870605</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>Valid when the WhatsApp template Category is Marketing and Button type is QUICK_REPLY. Indicates the button is a marketing opt-out button. If the customer clicks this button and the send control operation is configured in ChatApp, subsequent Marketing messages will not be sent to the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// <para>The navigate screen. Required when FlowAction is set to NAVIGATE.</para>
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
                /// <para>Use the properties under SupportedApps instead.</para>
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
                /// <para>Use the properties under SupportedApps instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29dkeke</para>
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                [Obsolete]
                public string SignatureHash { get; set; }

                /// <summary>
                /// <para>The list of supported applications.</para>
                /// </summary>
                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class ModifyChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    /// <summary>
                    /// <para>Required when the WhatsApp template Category is AUTHENTICATION and Button Type is ONE_TAP or ZERO_TAP. The package name for WhatsApp to launch the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.example.myapplication</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>Required when the WhatsApp template Category is AUTHENTICATION and Button Type is ONE_TAP or ZERO_TAP. The signature hash value for WhatsApp to launch the application.</para>
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
                /// <item><description><para><b>PHONE_NUMBER</b>: phone call button</para>
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
                /// <item><description><para><b>FLOW</b>: open a WhatsApp flow</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For WhatsApp templates with Category set to AUTHENTICATION, only one button is allowed, and the type can only be COPY_CODE or ONE_TAP. When the type is COPY_CODE, Text is required. When the type is ONE_TAP, Text (displayed when the target application is not installed on the device, indicating the name of the copy verification code button) is required, and SignatureHash, PackageName, and AutofillText are required.</description></item>
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
                /// <item><description><para><b>static</b>: static</para>
                /// </description></item>
                /// <item><description><para><b>dynamic</b>: dynamic</para>
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
            /// <para>A description can be added when Type is set to <b>HEADER</b> and Format is set to <b>IMAGE/DOCUMENT/VIDEO</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>This is a video</para>
            /// </summary>
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            /// <summary>
            /// <para>The list of Carousel template cards.</para>
            /// </summary>
            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class ModifyChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// <para>The list of components in the Carousel card.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class ModifyChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    /// <summary>
                    /// <para>The button list. This parameter applies only to the BUTTONS component. Each Carousel card can have a maximum of two buttons.</para>
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
                        /// <item><description><para><b>PHONE_NUMBER</b>: phone call button</para>
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
                    /// <para>The media resource type. Valid when Type is set to HEADER.</para>
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
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The validity period (in minutes) of the verification code in WhatsApp AUTHENTICATION templates. Valid only for WhatsApp messages when Category is AUTHENTICATION and Component Type is Footer. This information is displayed in the Footer section.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CodeExpirationMinutes")]
            [Validation(Required=false)]
            public int? CodeExpirationMinutes { get; set; }

            /// <summary>
            /// <para>Invalid field.</para>
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
            /// <para>A file name can be specified when Type is set to <b>HEADER</b> and Format is set to <b>DOCUMENT</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>Invalid field.</para>
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
            /// <item><description><para><b>TEXT</b>: text </para>
            /// </description></item>
            /// <item><description><para><b>IMAGE</b>: image </para>
            /// </description></item>
            /// <item><description><para><b>DOCUMENT</b>: document </para>
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
            /// <para>Specifies whether the coupon code has an expiration time. Used when type is set to LIMITED_TIME_OFFER.</para>
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
            /// <para>When Category is set to AUTHENTICATION, this property value is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hello chatapp</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>Invalid field.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn.multiplymall.mobiapp.cloud/cloudcode/yc-165407506207478-165511576113195/20220905/ec5b9737-1507-4208-bb27-8da3958da961.jpg?x-oss-process=image/resize,w_100">https://cdn.multiplymall.mobiapp.cloud/cloudcode/yc-165407506207478-165511576113195/20220905/ec5b9737-1507-4208-bb27-8da3958da961.jpg?x-oss-process=image/resize,w_100</a></para>
            /// </summary>
            [NameInMap("ThumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

            /// <summary>
            /// <para>The component type.</para>
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
            /// <item><description>For WhatsApp templates, the character length of the <b>BODY</b> component cannot exceed 1024 characters. The character length of the <b>HEADER</b> and <b>FOOTER</b> components cannot exceed 60 characters.</description></item>
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
            /// <para>The material path.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.****.com/png_preview/00/10/24/1GygxVK3F4.jpg">https://img.****.com/png_preview/00/10/24/1GygxVK3F4.jpg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The SpaceId of the ISV sub-customer or the instance ID of a direct customer.</para>
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
        /// <para>The examples for creating the template.</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        /// <summary>
        /// <para>The ISV verification code used to verify whether the RAM user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ksiekdki39ksks93939</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
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
        /// <item><description>AUTHENTICATION: valid values are 30 to 900. </description></item>
        /// <item><description>UTILITY: valid values are 30 to 43200.</description></item>
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
        /// <para>The templatetype.</para>
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

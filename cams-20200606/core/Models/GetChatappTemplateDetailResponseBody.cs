// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the request is successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ 		&quot;category&quot;: &quot;ACCOUNT_UPDATE&quot;, 		&quot;name&quot;: &quot;account_notice&quot;, 		&quot;language&quot;: &quot;en_US&quot;, 		&quot;templateCode&quot;: &quot;744c4b5c79c9432497a075bdfca3****&quot;, 		&quot;auditStatus&quot;: &quot;APPROVED&quot;, 		&quot;components&quot;: &quot;[{\&quot;type\&quot;:\&quot;BODY\&quot;,\&quot;text\&quot;:\&quot;body_text$(textVariable)\&quot;},{\&quot;type\&quot;:\&quot;HEADER\&quot;,\&quot;formate\&quot;:\&quot;IMAGE\&quot;,\&quot;url\&quot;:\&quot;$(linkVariable)\&quot;},{\&quot;type\&quot;:\&quot;FOOTER\&quot;,\&quot;text\&quot;:\&quot;footer-text\&quot;},{\&quot;type\&quot;:\&quot;BUTTONS\&quot;,\&quot;buttons\&quot;:[{\&quot;type\&quot;:\&quot;PHONE_NUMBER\&quot;,\&quot;text\&quot;:\&quot;phone-button-text\&quot;,\&quot;phone_number\&quot;:\&quot;+861388888****\&quot;},{\&quot;type\&quot;:\&quot;URL\&quot;,\&quot;text\&quot;:\&quot;url-button-text\&quot;,\&quot;url\&quot;:\&quot;<a href="https://www.website.com/%5C%5C%22%7D%5D%7D%5D">https://www.website.com/\\&quot;}]}]</a>&quot;, 		&quot;example&quot;: &quot;{\&quot;textVariable\&quot;: \&quot;text\&quot;, \&quot;linkVariable\&quot;: \&quot;link\&quot;}&quot; 	}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatappTemplateDetailResponseBodyData Data { get; set; }
        public class GetChatappTemplateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the current template can be sent. This parameter is valid only for marketing templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowSend")]
            [Validation(Required=false)]
            public bool? AllowSend { get; set; }

            /// <summary>
            /// <para>The review status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pass</b>: Approved.</para>
            /// </description></item>
            /// <item><description><para><b>fail</b>: Rejected.</para>
            /// </description></item>
            /// <item><description><para><b>auditing</b>: Under review.</para>
            /// </description></item>
            /// <item><description><para><b>unaudit</b>: Review suspended.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <para>The WhatsApp template categorization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UTILITY</b>: Transaction-related.</para>
            /// </description></item>
            /// <item><description><para><b>MARKETING</b>: Marketing template.</para>
            /// </description></item>
            /// <item><description><para><b>AUTHENTICATION</b>: Identity verification.</para>
            /// </description></item>
            /// </list>
            /// <para>Viber template categorization:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UTILITY</b>: Transaction-related.</para>
            /// </description></item>
            /// <item><description><para><b>MARKETING</b>: Marketing template.</para>
            /// </description></item>
            /// <item><description><para><b>AUTHENTICATION</b>: Identity verification.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UTILITY</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Indicates whether the sending of the template is paused when a utility template is changed to a marketing template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CategoryChangePaused")]
            [Validation(Required=false)]
            public bool? CategoryChangePaused { get; set; }

            /// <summary>
            /// <para>The list of message template components.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<GetChatappTemplateDetailResponseBodyDataComponents> Components { get; set; }
            public class GetChatappTemplateDetailResponseBodyDataComponents : TeaModel {
                /// <summary>
                /// <para>Indicates whether to display a security recommendation above the body to remind users not to share the verification code with others. This parameter is valid only for WhatsApp templates whose category is AUTHENTICATION and component type is BODY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AddSecretRecommendation")]
                [Validation(Required=false)]
                public bool? AddSecretRecommendation { get; set; }

                /// <summary>
                /// <para>The list of buttons. This parameter is valid only for the <b>BUTTONS</b> component.</para>
                /// <remarks>
                /// <para>WhatsApp button limits</para>
                /// <list type="bullet">
                /// <item><description>For MARKETING or UTILITY templates, a maximum of 10 buttons are allowed.</description></item>
                /// <item><description>Only one PHONE_NUMBER button is allowed.</description></item>
                /// <item><description>A maximum of two URL buttons are allowed.</description></item>
                /// <item><description>QUICK_REPLY buttons cannot be mixed with PHONE_NUMBER or URL buttons in an unordered manner.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("Buttons")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsButtons> Buttons { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsButtons : TeaModel {
                    /// <summary>
                    /// <para>The button text for the WhatsApp autofill operation. This parameter is required for WhatsApp templates whose category is AUTHENTICATION and button type is ONE_TAP.</para>
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
                    /// <para>202039ksjs</para>
                    /// </summary>
                    [NameInMap("CouponCode")]
                    [Validation(Required=false)]
                    public string CouponCode { get; set; }

                    /// <summary>
                    /// <para>The extended attributes.</para>
                    /// </summary>
                    [NameInMap("ExtendAttrs")]
                    [Validation(Required=false)]
                    public GetChatappTemplateDetailResponseBodyDataComponentsButtonsExtendAttrs ExtendAttrs { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsButtonsExtendAttrs : TeaModel {
                        /// <summary>
                        /// <para>The event type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>nextCard</para>
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// <para>The intent code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("IntentCode")]
                        [Validation(Required=false)]
                        public string IntentCode { get; set; }

                        /// <summary>
                        /// <para>The language of the next template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>en</para>
                        /// </summary>
                        [NameInMap("NextLanguageCode")]
                        [Validation(Required=false)]
                        public string NextLanguageCode { get; set; }

                        /// <summary>
                        /// <para>The code of the next template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20939920093993</para>
                        /// </summary>
                        [NameInMap("NextTemplateCode")]
                        [Validation(Required=false)]
                        public string NextTemplateCode { get; set; }

                        /// <summary>
                        /// <para>The name of the next template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>abc</para>
                        /// </summary>
                        [NameInMap("NextTemplateName")]
                        [Validation(Required=false)]
                        public string NextTemplateName { get; set; }

                    }

                    /// <summary>
                    /// <para>The flow data event type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>NAVIGATE: Navigation.</para>
                    /// </description></item>
                    /// <item><description><para>DATA_EXCHANGE: Data exchange.</para>
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
                    /// <para>Flow ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3838292983</para>
                    /// </summary>
                    [NameInMap("FlowId")]
                    [Validation(Required=false)]
                    public string FlowId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the button is a marketing opt-out button. This parameter is valid only for WhatsApp templates whose category is MARKETING and button type is QUICK_REPLY. If a customer clicks this button and send control operations are configured on the Chat App Message Service platform, subsequent marketing messages are not sent to the customer.</para>
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
                    /// <para>The package name of the application invoked by WhatsApp. This parameter is required for WhatsApp templates whose category is AUTHENTICATION and button type is ONE_TAP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.aliyun</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>The phone number. This parameter is valid only when the button type is <b>PHONE_NUMBER</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>+861398745****</para>
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// <para>The signature hash value of the application invoked by WhatsApp. This parameter is required for WhatsApp templates whose category is AUTHENTICATION and button type is ONE_TAP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2993839</para>
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                    /// <summary>
                    /// <para>The applications supported by the ONE_TAP or ZERO_TAP verification code.</para>
                    /// </summary>
                    [NameInMap("SupportedApps")]
                    [Validation(Required=false)]
                    public List<GetChatappTemplateDetailResponseBodyDataComponentsButtonsSupportedApps> SupportedApps { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsButtonsSupportedApps : TeaModel {
                        /// <summary>
                        /// <para>The package name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>com.test</para>
                        /// </summary>
                        [NameInMap("PackageName")]
                        [Validation(Required=false)]
                        public string PackageName { get; set; }

                        /// <summary>
                        /// <para>The package signature hash.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>29kdkeik939</para>
                        /// </summary>
                        [NameInMap("SignatureHash")]
                        [Validation(Required=false)]
                        public string SignatureHash { get; set; }

                    }

                    /// <summary>
                    /// <para>The display name of the button.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
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
                    /// <item><description><para><b>PHONE_NUMBER</b>: Call button.</para>
                    /// </description></item>
                    /// <item><description><para><b>URL</b>: URL button.</para>
                    /// </description></item>
                    /// <item><description><para><b>QUICK_REPLY</b>: Quick reply button.</para>
                    /// </description></item>
                    /// <item><description><para><b>COPY_CODE</b>: Copy verification code or coupon code button.</para>
                    /// </description></item>
                    /// <item><description><para><b>ONE_TAP</b>: Autofill button for AUTHENTICATION templates.</para>
                    /// </description></item>
                    /// <item><description><para><b>ZERO_TAP</b>: Autofill button for AUTHENTICATION templates.</para>
                    /// </description></item>
                    /// <item><description><para><b>MPM</b>: Multi-product message.</para>
                    /// </description></item>
                    /// <item><description><para><b>CATALOG</b>: Catalog.</para>
                    /// </description></item>
                    /// <item><description><para><b>FLOW</b>: Open WhatsApp flow.</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>For WhatsApp templates whose category is AUTHENTICATION, only one button is allowed, and the type must be COPY_CODE or ONE_TAP. If the type is COPY_CODE, Text is required. If the type is ONE_TAP, Text (displayed when the target application is not installed on the terminal, indicating the name of the copy verification code button), SignatureHash, PackageName, and AutofillText are required.</description></item>
                    /// <item><description>For Viber templates, only one button is allowed, and the type must be URL.</description></item>
                    /// </list>
                    /// </remarks>
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
                /// <para>The description of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The list of carousel cards.</para>
                /// </summary>
                [NameInMap("Cards")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsCards> Cards { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsCards : TeaModel {
                    /// <summary>
                    /// <para>The list of card controls.</para>
                    /// </summary>
                    [NameInMap("CardComponents")]
                    [Validation(Required=false)]
                    public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents> CardComponents { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents : TeaModel {
                        /// <summary>
                        /// <para>The list of card buttons.</para>
                        /// </summary>
                        [NameInMap("Buttons")]
                        [Validation(Required=false)]
                        public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons> Buttons { get; set; }
                        public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons : TeaModel {
                            /// <summary>
                            /// <para>The phone number.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>+861380005****</para>
                            /// </summary>
                            [NameInMap("PhoneNumber")]
                            [Validation(Required=false)]
                            public string PhoneNumber { get; set; }

                            /// <summary>
                            /// <para>The button content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>example</para>
                            /// </summary>
                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                            /// <summary>
                            /// <para>The button type for carousel templates. Valid values: URL, PHONE_NUMBER, and QUICK_REQLY.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>URL</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The URL to visit after the button is clicked.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                            /// <summary>
                            /// <para>The URL type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>static: Static.</description></item>
                            /// <item><description>dynamic: Dynamic.</description></item>
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
                        /// <para>The header type for carousel templates. Only IMAGE and VIDEO are supported. The header must be consistent across all cards.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HEADER</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The text content of the card.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Body</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>The component type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HEADER</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The web address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }

                /// <summary>
                /// <para>The validity period of the verification code in minutes for WhatsApp authentication templates. This is valid only for WhatsApp messages where the category is Authentication and the component type is Footer. This information is displayed in the footer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CodeExpirationMinutes")]
                [Validation(Required=false)]
                public int? CodeExpirationMinutes { get; set; }

                /// <summary>
                /// <para>The video duration in seconds for Viber video messages. Valid values: 0 to 600.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
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
                /// <para>The format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEXT</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The latitude of the location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28.001</para>
                /// </summary>
                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// <para>The address of the location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangzhou</para>
                /// </summary>
                [NameInMap("LocationAddress")]
                [Validation(Required=false)]
                public string LocationAddress { get; set; }

                /// <summary>
                /// <para>The name of the location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangzhou</para>
                /// </summary>
                [NameInMap("LocationName")]
                [Validation(Required=false)]
                public string LocationName { get; set; }

                /// <summary>
                /// <para>The longitude of the location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120.002</para>
                /// </summary>
                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// <para>The offer expiration variable for limited-time offer (LTO) templates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$(offerExpirationTimeMs)</para>
                /// </summary>
                [NameInMap("OfferExpirationTimeMs")]
                [Validation(Required=false)]
                public string OfferExpirationTimeMs { get; set; }

                /// <summary>
                /// <para>The text of the message to send.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The thumbnail URL for Viber video messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.png">https://img.png</a></para>
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
                /// <item><description>For WhatsApp templates, the <b>BODY</b> component cannot exceed 1,024 characters. The <b>HEADER</b> and <b>FOOTER</b> components cannot exceed 60 characters.</description></item>
                /// <item><description>For Viber templates, the <b>FOOTER</b>, <b>CAROUSEL</b>, and <b>LIMITED_TIME_OFFER</b> types are invalid.</description></item>
                /// <item><description>In Viber templates, images, videos, and files are placed in the <b>HEADER</b>. The client displays the image below the text.</description></item>
                /// </list>
                /// </remarks>
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
                /// <para><a href="https://image.developer.aliyundoc.com">https://image.developer.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Specifies whether the offer code has an expiration time in LTO templates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasExpiration")]
                [Validation(Required=false)]
                public bool? HasExpiration { get; set; }

            }

            /// <summary>
            /// <para>The variable example.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;textVariable&quot;:&quot;text&quot;}</para>
            /// </summary>
            [NameInMap("Example")]
            [Validation(Required=false)]
            public Dictionary<string, string> Example { get; set; }

            /// <summary>
            /// <para>The language of the template. For more information about language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en_US</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The time-to-live (TTL) in seconds for messages sent by using WhatsApp authentication templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MessageSendTtlSeconds")]
            [Validation(Required=false)]
            public int? MessageSendTtlSeconds { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
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
            /// <para>939***</para>
            /// </summary>
            [NameInMap("ProductSetId")]
            [Validation(Required=false)]
            public string ProductSetId { get; set; }

            /// <summary>
            /// <para>The template quality. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RED: Low quality.</description></item>
            /// <item><description>YELLOW: Medium quality.</description></item>
            /// <item><description>UNKNOWN: Unknown quality.</description></item>
            /// <item><description>GREEN: High quality.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GREEN</para>
            /// </summary>
            [NameInMap("QualityScore")]
            [Validation(Required=false)]
            public string QualityScore { get; set; }

            /// <summary>
            /// <para>The reason why the template was rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>744c4b5c79c9432497a075bdfca3****</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The templatetype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>WHATSAPP</b></para>
            /// </description></item>
            /// <item><description><para><b>VIBER</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WHATSAPP</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>744c4b5c79c9432497a075bdfca3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

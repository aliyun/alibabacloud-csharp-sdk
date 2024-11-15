// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>Example: OK. This value indicates that the request is successful.</description></item>
        /// <item><description>Other codes indicate that the request fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ 		&quot;category&quot;: &quot;ACCOUNT_UPDATE&quot;, 		&quot;name&quot;: &quot;account_notice&quot;, 		&quot;language&quot;: &quot;en_US&quot;, 		&quot;templateCode&quot;: &quot;744c4b5c79c9432497a075bdfca3****&quot;, 		&quot;auditStatus&quot;: &quot;APPROVED&quot;, 		&quot;components&quot;: &quot;[{\&quot;type\&quot;:\&quot;BODY\&quot;,\&quot;text\&quot;:\&quot;body_text$(textVariable)\&quot;},{\&quot;type\&quot;:\&quot;HEADER\&quot;,\&quot;formate\&quot;:\&quot;IMAGE\&quot;,\&quot;url\&quot;:\&quot;$(linkVariable)\&quot;},{\&quot;type\&quot;:\&quot;FOOTER\&quot;,\&quot;text\&quot;:\&quot;footer-text\&quot;},{\&quot;type\&quot;:\&quot;BUTTONS\&quot;,\&quot;buttons\&quot;:[{\&quot;type\&quot;:\&quot;PHONE_NUMBER\&quot;,\&quot;text\&quot;:\&quot;phone-button-text\&quot;,\&quot;phone_number\&quot;:\&quot;+861388888****\&quot;},{\&quot;type\&quot;:\&quot;URL\&quot;,\&quot;text\&quot;:\&quot;url-button-text\&quot;,\&quot;url\&quot;:\&quot;<a href="https://www.website.com/%5C%5C%22%7D%5D%7D%5D">https://www.website.com/\\&quot;}]}]</a>&quot;, 		&quot;example&quot;: &quot;{\&quot;textVariable\&quot;: \&quot;text\&quot;, \&quot;linkVariable\&quot;: \&quot;link\&quot;}&quot; 	}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatappTemplateDetailResponseBodyData Data { get; set; }
        public class GetChatappTemplateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The review status of the message template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pass</b>: The message template is approved.</description></item>
            /// <item><description><b>fail</b>: The message template is rejected.</description></item>
            /// <item><description><b>auditing</b>: The message template is being reviewed.</description></item>
            /// <item><description><b>unaudit</b>: The review is suspended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <para>The category of the template when the returned value of TemplateType is WHATSAPP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UTILITY</b>: a transactional template</description></item>
            /// <item><description><b>MARKETING</b>: a marketing template</description></item>
            /// <item><description><b>AUTHENTICATION</b>: an identity authentication template</description></item>
            /// </list>
            /// <para>The category of the template when the returned value of the TemplateType parameter is VIBER. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>text</b>: a template that contains only text</description></item>
            /// <item><description><b>image</b>: a template that contains only images</description></item>
            /// <item><description><b>text_image_button</b>: a template that contains text, images, and buttons</description></item>
            /// <item><description><b>text_button</b>: a template that contains text and buttons</description></item>
            /// <item><description><b>document</b>: a template that contains only files</description></item>
            /// <item><description><b>video</b>: a template that contains only videos</description></item>
            /// <item><description><b>text_video</b>: a template that contains text and videos</description></item>
            /// <item><description><b>text_video_button</b>: a template that contains text, videos, and buttons</description></item>
            /// <item><description><b>text_image</b>: a template that contains text and images</description></item>
            /// </list>
            /// <remarks>
            /// <para>If Category is set to text_video_button, users cannot open a web page by clicking the button. Users can open only the video in the message. In this case, you do not need to specify the Url parameter for the URL button in the template.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TRANSACTIONAL</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The components of the message template.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<GetChatappTemplateDetailResponseBodyDataComponents> Components { get; set; }
            public class GetChatappTemplateDetailResponseBodyDataComponents : TeaModel {
                /// <summary>
                /// <para>The note indicating that customers cannot share verification codes with others. The note is displayed in the message body. This parameter is valid if Category is set to AUTHENTICATION and the Type sub-parameter of the Components parameter is set to BODY for a WhatsApp message template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AddSecretRecommendation")]
                [Validation(Required=false)]
                public bool? AddSecretRecommendation { get; set; }

                /// <summary>
                /// <para>The buttons. This parameter is returned only if the Type sub-parameter of the Components parameter is set to <b>BUTTONS</b>.</para>
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
                public List<GetChatappTemplateDetailResponseBodyDataComponentsButtons> Buttons { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsButtons : TeaModel {
                    /// <summary>
                    /// <para>The text of the one-tap autofill button. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP in a WhatsApp message template.</para>
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
                    /// <para>The extended fields.</para>
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
                    /// <para>The Flow action. Valid values: NAVIGATE and DATA_EXCHANGE.</para>
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
                    /// <para>3838292983</para>
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
                    /// <para>The first screen in the Flow. This parameter is returned if FlowAction is set to NAVIGATE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DETAILS</para>
                    /// </summary>
                    [NameInMap("NavigateScreen")]
                    [Validation(Required=false)]
                    public string NavigateScreen { get; set; }

                    /// <summary>
                    /// <para>The app package name that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP in a WhatsApp message template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>com.aliyun</para>
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// <para>The phone number. This parameter is valid only if the Type sub-parameter of the Buttons parameter is set to <b>PHONE_NUMBER</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>861398745****</para>
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// <para>The app signing key hash that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP in a WhatsApp message template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2993839</para>
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                    /// <summary>
                    /// <para>The apps that support one-tap authentication and zero-tap authentication.</para>
                    /// </summary>
                    [NameInMap("SupportedApps")]
                    [Validation(Required=false)]
                    public List<GetChatappTemplateDetailResponseBodyDataComponentsButtonsSupportedApps> SupportedApps { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsButtonsSupportedApps : TeaModel {
                        /// <summary>
                        /// <para>The app package name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>com.test</para>
                        /// </summary>
                        [NameInMap("PackageName")]
                        [Validation(Required=false)]
                        public string PackageName { get; set; }

                        /// <summary>
                        /// <para>The app signing key hash.</para>
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
                    /// <para>Call</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The button type. Valid values:</para>
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
                    /// <para><a href="https://example.com">https://example.com</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    /// <summary>
                    /// <para>The URL type. Valid values:</para>
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
                /// <para>The new file has been uploaded.</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The carousel cards.</para>
                /// </summary>
                [NameInMap("Cards")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsCards> Cards { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsCards : TeaModel {
                    /// <summary>
                    /// <para>The components of the carousel card.</para>
                    /// </summary>
                    [NameInMap("CardComponents")]
                    [Validation(Required=false)]
                    public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents> CardComponents { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents : TeaModel {
                        /// <summary>
                        /// <para>The buttons of the carousel card.</para>
                        /// </summary>
                        [NameInMap("Buttons")]
                        [Validation(Required=false)]
                        public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons> Buttons { get; set; }
                        public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons : TeaModel {
                            /// <summary>
                            /// <para>The phone number.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>+86138000</para>
                            /// </summary>
                            [NameInMap("PhoneNumber")]
                            [Validation(Required=false)]
                            public string PhoneNumber { get; set; }

                            /// <summary>
                            /// <para>The button text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Button text</para>
                            /// </summary>
                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                            /// <summary>
                            /// <para>The type of the button in the carousel template. Valid values: URL, PHONE_NUMBER, and QUICK_REQLY.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>URL</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The URL to which you are redirected when you click the URL button.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                            /// <summary>
                            /// <para>The type of the URL. Valid values: static and dynamic.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>static</para>
                            /// </summary>
                            [NameInMap("UrlType")]
                            [Validation(Required=false)]
                            public string UrlType { get; set; }

                        }

                        /// <summary>
                        /// <para>The type of the header in the carousel template. The header can only be an image or a video. The headers of all carousel cards must be the same. The type of the media resources that are included in the message. Valid values: IMGAGE and VIDEO.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HEADER</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The text of the carousel card.</para>
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
                        /// <para>The URL.</para>
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
                /// <para>The validity period of the verification code in the WhatsApp authentication template. Unit: minutes. This parameter is valid only when Category is set to AUTHENTICATION and the Type sub-parameter of the Components parameter is set to FOOTER for a WhatsApp message template. The validity period of the verification code is displayed in the footer.</para>
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
                /// <para>50</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The name of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Express file</para>
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
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("LocationAddress")]
                [Validation(Required=false)]
                public string LocationAddress { get; set; }

                /// <summary>
                /// <para>The name of the location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
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
                /// <para>The variable when the coupon code expires in the limited-time offer template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$(offerExpirationTimeMs)</para>
                /// </summary>
                [NameInMap("OfferExpirationTimeMs")]
                [Validation(Required=false)]
                public string OfferExpirationTimeMs { get; set; }

                /// <summary>
                /// <para>The text of the message that you want to send.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The thumbnail URL of the video in the Viber message template.</para>
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
                /// <para><a href="https://image.developer.aliyundoc.com">https://image.developer.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>Indicates whether the coupon code has an expiration time in the limited-time offer template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("hasExpiration")]
                [Validation(Required=false)]
                public bool? HasExpiration { get; set; }

            }

            /// <summary>
            /// <para>The examples of variables.</para>
            /// </summary>
            [NameInMap("Example")]
            [Validation(Required=false)]
            public Dictionary<string, string> Example { get; set; }

            /// <summary>
            /// <para>The language that is used in the message template. For more information, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en_US</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The validity period of the WhatsApp authentication message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MessageSendTtlSeconds")]
            [Validation(Required=false)]
            public int? MessageSendTtlSeconds { get; set; }

            /// <summary>
            /// <para>The name of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello_whatsapp</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The quality of the template.</para>
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
            /// <para>The code of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>744c4b5c79c9432497a075bdfca3****</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The type of the message template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WHATSAPP</b></description></item>
            /// <item><description><b>VIBER</b></description></item>
            /// <item><description>LINE (developing)</description></item>
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

    }

}

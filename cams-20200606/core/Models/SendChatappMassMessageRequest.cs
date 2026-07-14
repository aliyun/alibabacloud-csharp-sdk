// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMassMessageRequest : TeaModel {
        /// <summary>
        /// <para>The channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>whatsapp</b></para>
        /// </description></item>
        /// <item><description><para><b>messenger</b></para>
        /// </description></item>
        /// <item><description><para><b>instagram</b></para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;- <b>viber</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>whatsapp</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The ISV sub-customer SpaceId or direct customer instance ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ISV customer WABA ID. This parameter is deprecated. Use CustSpaceId instead, which is the direct customer instance ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The custom fallback content. This parameter is for the China site (Chinese). China site users can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fallback SMS</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// <para>The fallback trigger time. This parameter is for the international site. China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;If no delivery receipt is returned within the specified time, the fallback is triggered. If this parameter is not specified, the fallback is triggered only when the message fails to send or a failure status report is received. Unit: seconds. Minimum value: 60. Maximum value: 43200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <para>The fallback policy ID. This parameter is for the China site (Chinese). China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;You can view the policy ID on the <a href="https://chatapp.console.alibabacloud.com/FallbackStrategy"><b>Fallback Policy</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S0****</para>
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// <para>The fallback rule. This parameter is for the international site. China site users can ignore this parameter.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:
        /// &lt;props=&quot;intl&quot;&gt;- <b>undelivered</b>: the fallback is triggered when the message cannot be delivered to the device. During sending, the template and parameters must pass validation. Blocked templates or blocked numbers are not validated. This rule is used by default if the parameter value is empty.
        /// &lt;props=&quot;intl&quot;&gt;- <b>sentFailed</b>: the fallback is triggered when validation of the template or template variables fails. Only channelType, type, messageType, to, and from (whether it exists) are strictly validated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>undelivered</para>
        /// </summary>
        [NameInMap("FallBackRule")]
        [Validation(Required=false)]
        public string FallBackRule { get; set; }

        /// <summary>
        /// <para>The sender phone number.</para>
        /// <list type="bullet">
        /// <item><description>If ChannelType is <b>whatsapp</b>, this is the phone number registered and bindng with WhatsApp. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>WABA Management</b> &gt; <b>Phone Number Management</b> page.</description></item>
        /// <item><description>If ChannelType is <b>messenger</b>, this is the Page ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Public Page</b> page.</description></item>
        /// <item><description>If ChannelType is <b>instagram</b>, this is the Instagram professional Account ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Professional Account</b> page.
        /// &lt;props=&quot;intl&quot;&gt;- If ChannelType is <b>viber</b>, this is the Viber Service ID. You can view it on the <a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Service ID Management</b> page.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861387777****</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ISV verification code used to verify whether a RAM user is authorized by the ISV. This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikd****</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The Viber message type. This parameter is for the international site. China site users can ignore this parameter.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:
        /// &lt;props=&quot;intl&quot;&gt;- <b>pormotion</b>: marketing or promotional messages.
        /// &lt;props=&quot;intl&quot;&gt;- <b>transaction</b>: notification messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The language. For a list of language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The list of recipient phone numbers.</para>
        /// </summary>
        [NameInMap("SenderList")]
        [Validation(Required=false)]
        public List<SendChatappMassMessageRequestSenderList> SenderList { get; set; }
        public class SendChatappMassMessageRequestSenderList : TeaModel {
            /// <summary>
            /// <para>The Flow message object.</para>
            /// </summary>
            [NameInMap("FlowAction")]
            [Validation(Required=false)]
            public SendChatappMassMessageRequestSenderListFlowAction FlowAction { get; set; }
            public class SendChatappMassMessageRequestSenderListFlowAction : TeaModel {
                /// <summary>
                /// <para>The collection of flow default parameters.</para>
                /// </summary>
                [NameInMap("FlowActionData")]
                [Validation(Required=false)]
                public Dictionary<string, object> FlowActionData { get; set; }

                /// <summary>
                /// <para>The custom flow token information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kde****</para>
                /// </summary>
                [NameInMap("FlowToken")]
                [Validation(Required=false)]
                public string FlowToken { get; set; }

            }

            /// <summary>
            /// <para>The list of button trigger message identifiers.</para>
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public List<string> Payload { get; set; }

            /// <summary>
            /// <para>The product information. This parameter applies only to WhatsApp channels and refers to the product information you uploaded on Meta.</para>
            /// </summary>
            [NameInMap("ProductAction")]
            [Validation(Required=false)]
            public SendChatappMassMessageRequestSenderListProductAction ProductAction { get; set; }
            public class SendChatappMassMessageRequestSenderListProductAction : TeaModel {
                /// <summary>
                /// <para>The list of product categories. A maximum of 10 categories and 30 products are supported.</para>
                /// </summary>
                [NameInMap("Sections")]
                [Validation(Required=false)]
                public List<SendChatappMassMessageRequestSenderListProductActionSections> Sections { get; set; }
                public class SendChatappMassMessageRequestSenderListProductActionSections : TeaModel {
                    /// <summary>
                    /// <para>The list of product information.</para>
                    /// </summary>
                    [NameInMap("ProductItems")]
                    [Validation(Required=false)]
                    public List<SendChatappMassMessageRequestSenderListProductActionSectionsProductItems> ProductItems { get; set; }
                    public class SendChatappMassMessageRequestSenderListProductActionSectionsProductItems : TeaModel {
                        /// <summary>
                        /// <para>The product ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Catalog Management</b> &gt; <b>Product Management</b> page, or obtain it by calling the <a href="https://help.aliyun.com/document_detail/2557786.html">ListProduct</a> operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ksi3****</para>
                        /// </summary>
                        [NameInMap("ProductRetailerId")]
                        [Validation(Required=false)]
                        public string ProductRetailerId { get; set; }

                    }

                    /// <summary>
                    /// <para>The category name. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Catalog Management</b> &gt; <b>Product Management</b> page, or obtain it by calling the <a href="https://help.aliyun.com/document_detail/2557786.html">ListProduct</a> operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abcd</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The product catalog ID. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2539783.html">ListProductCatalog</a> operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skkks99****</para>
                /// </summary>
                [NameInMap("ThumbnailProductRetailerId")]
                [Validation(Required=false)]
                public string ThumbnailProductRetailerId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>individual</para>
            /// </summary>
            [NameInMap("RecipientType")]
            [Validation(Required=false)]
            public string RecipientType { get; set; }

            /// <summary>
            /// <para>The collection of template parameters.</para>
            /// </summary>
            [NameInMap("TemplateParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateParams { get; set; }

            /// <summary>
            /// <para>The recipient phone number.</para>
            /// <list type="bullet">
            /// <item><description>If ChannelType is <b>whatsapp</b>, this is the phone number of the message recipient.</description></item>
            /// <item><description>If ChannelType is <b>messenger</b>, this is the Page-Scoped User ID generated when the user interacts with the Facebook page.</description></item>
            /// <item><description>If ChannelType is <b>instagram</b>, this is the Instagram User ID generated when the user interacts with the Instagram business or creator account.
            /// &lt;props=&quot;intl&quot;&gt;- If ChannelType is <b>viber</b>, this is the phone number of the message recipient.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>861386666****</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>The tag information. Custom tag information for Viber message sending.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tag</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The custom task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The template code. You can view the template code on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1119***************</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template name. You can view the template name on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The timeout period for Viber message sending. This parameter is for the international site. China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;Unit: seconds. Valid values: 30 to 1209600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}

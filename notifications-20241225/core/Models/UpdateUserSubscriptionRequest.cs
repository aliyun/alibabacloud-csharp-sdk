// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class UpdateUserSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application name of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yunge-user</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The business line of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The request protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("CallerProtocol")]
        [Validation(Required=false)]
        public string CallerProtocol { get; set; }

        /// <summary>
        /// <para>The list of categories.</para>
        /// </summary>
        [NameInMap("CategoryCodes")]
        [Validation(Required=false)]
        public List<string> CategoryCodes { get; set; }

        /// <summary>
        /// <para>The list of channels.</para>
        /// </summary>
        [NameInMap("ChannelConfigs")]
        [Validation(Required=false)]
        public List<UpdateUserSubscriptionRequestChannelConfigs> ChannelConfigs { get; set; }
        public class UpdateUserSubscriptionRequestChannelConfigs : TeaModel {
            /// <summary>
            /// <para>The channel type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pmsg</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>Specifies whether the channel is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("CheckedState")]
            [Validation(Required=false)]
            public string CheckedState { get; set; }

            /// <summary>
            /// <para>The fatigue threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("FatigueDayLimit")]
            [Validation(Required=false)]
            public int? FatigueDayLimit { get; set; }

        }

        /// <summary>
        /// <para>The channel group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tts: Voice channel group.</description></item>
        /// <item><description>webhook: Chatbot channel group.</description></item>
        /// <item><description>base: Basic channel group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("ChannelGroupCode")]
        [Validation(Required=false)]
        public string ChannelGroupCode { get; set; }

        /// <summary>
        /// <para>The source of the operation terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("ClientSource")]
        [Validation(Required=false)]
        public string ClientSource { get; set; }

        /// <summary>
        /// <para>The common contacts.</para>
        /// </summary>
        [NameInMap("CommonContacts")]
        [Validation(Required=false)]
        public List<UpdateUserSubscriptionRequestCommonContacts> CommonContacts { get; set; }
        public class UpdateUserSubscriptionRequestCommonContacts : TeaModel {
            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>The contact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ContactMobile")]
            [Validation(Required=false)]
            public string ContactMobile { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("EmailConfirmed")]
            [Validation(Required=false)]
            public bool? EmailConfirmed { get; set; }

            /// <summary>
            /// <para>The message source.</para>
            /// </summary>
            [NameInMap("MessageSource")]
            [Validation(Required=false)]
            public UpdateUserSubscriptionRequestCommonContactsMessageSource MessageSource { get; set; }
            public class UpdateUserSubscriptionRequestCommonContactsMessageSource : TeaModel {
                /// <summary>
                /// <para>The blacklist.</para>
                /// </summary>
                [NameInMap("KeywordBlacklist")]
                [Validation(Required=false)]
                public List<string> KeywordBlacklist { get; set; }

                /// <summary>
                /// <para>The whitelist.</para>
                /// </summary>
                [NameInMap("KeywordWhitelist")]
                [Validation(Required=false)]
                public List<string> KeywordWhitelist { get; set; }

            }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("MobileConfirmed")]
            [Validation(Required=false)]
            public bool? MobileConfirmed { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public string Position { get; set; }

        }

        /// <summary>
        /// <para>The user cookies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string Cookies { get; set; }

        /// <summary>
        /// <para>The revision type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>receive_contact: Receive contact.</description></item>
        /// <item><description>receive_channel: Receive channel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>receive_channel</para>
        /// </summary>
        [NameInMap("OperationItemCode")]
        [Validation(Required=false)]
        public string OperationItemCode { get; set; }

        /// <summary>
        /// <para>Not supported.</para>
        /// </summary>
        [NameInMap("ReceiveTimeList")]
        [Validation(Required=false)]
        public List<int?> ReceiveTimeList { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The URL of the source page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("SrcUrl")]
        [Validation(Required=false)]
        public string SrcUrl { get; set; }

        /// <summary>
        /// <para>The tenant information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

        /// <summary>
        /// <para>The user type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("UidType")]
        [Validation(Required=false)]
        public string UidType { get; set; }

        /// <summary>
        /// <para>The list of chatbot contacts.</para>
        /// </summary>
        [NameInMap("WebhookContacts")]
        [Validation(Required=false)]
        public List<UpdateUserSubscriptionRequestWebhookContacts> WebhookContacts { get; set; }
        public class UpdateUserSubscriptionRequestWebhookContacts : TeaModel {
            /// <summary>
            /// <para>webhook id</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The message source.</para>
            /// </summary>
            [NameInMap("MessageSource")]
            [Validation(Required=false)]
            public UpdateUserSubscriptionRequestWebhookContactsMessageSource MessageSource { get; set; }
            public class UpdateUserSubscriptionRequestWebhookContactsMessageSource : TeaModel {
                /// <summary>
                /// <para>The blacklist.</para>
                /// </summary>
                [NameInMap("KeywordBlacklist")]
                [Validation(Required=false)]
                public List<string> KeywordBlacklist { get; set; }

                /// <summary>
                /// <para>The whitelist.</para>
                /// </summary>
                [NameInMap("KeywordWhitelist")]
                [Validation(Required=false)]
                public List<string> KeywordWhitelist { get; set; }

            }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ServerUrl")]
            [Validation(Required=false)]
            public string ServerUrl { get; set; }

            /// <summary>
            /// <para>No input required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("WebhookType")]
            [Validation(Required=false)]
            public string WebhookType { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadUserSubscriptionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ReadUserSubscriptionListResponseBodyData> Data { get; set; }
        public class ReadUserSubscriptionListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The message category code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod_edu_content</para>
            /// </summary>
            [NameInMap("CategoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// <para>The description of the message category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Content related to product usage scenarios and technical sharing</para>
            /// </summary>
            [NameInMap("CategoryDesc")]
            [Validation(Required=false)]
            public string CategoryDesc { get; set; }

            /// <summary>
            /// <para>The category group code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod_msg</para>
            /// </summary>
            [NameInMap("CategoryGroupCode")]
            [Validation(Required=false)]
            public string CategoryGroupCode { get; set; }

            /// <summary>
            /// <para>The category group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product Messages</para>
            /// </summary>
            [NameInMap("CategoryGroupName")]
            [Validation(Required=false)]
            public string CategoryGroupName { get; set; }

            /// <summary>
            /// <para>The message category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product Educational Content</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The channel list.</para>
            /// </summary>
            [NameInMap("ChannelConfigs")]
            [Validation(Required=false)]
            public List<ReadUserSubscriptionListResponseBodyDataChannelConfigs> ChannelConfigs { get; set; }
            public class ReadUserSubscriptionListResponseBodyDataChannelConfigs : TeaModel {
                /// <summary>
                /// <para>The channel type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>email</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>Indicates whether the subscription is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YES</para>
                /// </summary>
                [NameInMap("CheckedState")]
                [Validation(Required=false)]
                public string CheckedState { get; set; }

                /// <summary>
                /// <para>Indicates whether the option is selected by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YES</para>
                /// </summary>
                [NameInMap("DefaultChecked")]
                [Validation(Required=false)]
                public string DefaultChecked { get; set; }

                /// <summary>
                /// <para>The fatigue limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("FatigueDayLimit")]
                [Validation(Required=false)]
                public int? FatigueDayLimit { get; set; }

                /// <summary>
                /// <para>Indicates whether the option can be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YES</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public string Optional { get; set; }

            }

            /// <summary>
            /// <para>The contact.</para>
            /// </summary>
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public ReadUserSubscriptionListResponseBodyDataContact Contact { get; set; }
            public class ReadUserSubscriptionListResponseBodyDataContact : TeaModel {
                /// <summary>
                /// <para>The Account Center contact list.</para>
                /// </summary>
                [NameInMap("CommonContacts")]
                [Validation(Required=false)]
                public List<ReadUserSubscriptionListResponseBodyDataContactCommonContacts> CommonContacts { get; set; }
                public class ReadUserSubscriptionListResponseBodyDataContactCommonContacts : TeaModel {
                    /// <summary>
                    /// <para>The Alibaba Cloud account ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("AliUid")]
                    [Validation(Required=false)]
                    public long? AliUid { get; set; }

                    /// <summary>
                    /// <para>The email address of the contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t*@qq.*</para>
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
                    /// <para>The masked mobile phone number of the Account Center contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>130*90</para>
                    /// </summary>
                    [NameInMap("ContactMobile")]
                    [Validation(Required=false)]
                    public string ContactMobile { get; set; }

                    /// <summary>
                    /// <para>The name of the Account Center contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the email address is verified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EmailConfirmed")]
                    [Validation(Required=false)]
                    public bool? EmailConfirmed { get; set; }

                    /// <summary>
                    /// <para>The message source.</para>
                    /// </summary>
                    [NameInMap("MessageSource")]
                    [Validation(Required=false)]
                    public ReadUserSubscriptionListResponseBodyDataContactCommonContactsMessageSource MessageSource { get; set; }
                    public class ReadUserSubscriptionListResponseBodyDataContactCommonContactsMessageSource : TeaModel {
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
                    /// <para>Indicates whether the mobile phone number of the Account Center contact is verified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MobileConfirmed")]
                    [Validation(Required=false)]
                    public bool? MobileConfirmed { get; set; }

                    /// <summary>
                    /// <para>The position of the Account Center contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CEO</para>
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public string Position { get; set; }

                }

                /// <summary>
                /// <para>The webhook contact list.</para>
                /// </summary>
                [NameInMap("WebhookContacts")]
                [Validation(Required=false)]
                public List<ReadUserSubscriptionListResponseBodyDataContactWebhookContacts> WebhookContacts { get; set; }
                public class ReadUserSubscriptionListResponseBodyDataContactWebhookContacts : TeaModel {
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
                    /// <para>The name of the Account Center contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <para>The message source.</para>
                    /// </summary>
                    [NameInMap("MessageSource")]
                    [Validation(Required=false)]
                    public ReadUserSubscriptionListResponseBodyDataContactWebhookContactsMessageSource MessageSource { get; set; }
                    public class ReadUserSubscriptionListResponseBodyDataContactWebhookContactsMessageSource : TeaModel {
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
                    /// <para>The security token.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("SecurityToken")]
                    [Validation(Required=false)]
                    public string SecurityToken { get; set; }

                    /// <summary>
                    /// <para>The webhook URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxxxxxxx">https://oapi.dingtalk.com/robot/send?access_token=xxxxxxxx</a></para>
                    /// </summary>
                    [NameInMap("ServerUrl")]
                    [Validation(Required=false)]
                    public string ServerUrl { get; set; }

                    /// <summary>
                    /// <para>The webhook type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dingtalk</para>
                    /// </summary>
                    [NameInMap("WebhookType")]
                    [Validation(Required=false)]
                    public string WebhookType { get; set; }

                }

            }

            /// <summary>
            /// <para>The receiving time list.</para>
            /// </summary>
            [NameInMap("ReceiveTimeList")]
            [Validation(Required=false)]
            public List<int?> ReceiveTimeList { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

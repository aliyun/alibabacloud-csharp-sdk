// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadUserSubscriptionListResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ReadUserSubscriptionListResponseBodyData> Data { get; set; }
        public class ReadUserSubscriptionListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod_edu_content</para>
            /// </summary>
            [NameInMap("CategoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>产品的使用场景、技术分享的相关内容</para>
            /// </summary>
            [NameInMap("CategoryDesc")]
            [Validation(Required=false)]
            public string CategoryDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod_msg</para>
            /// </summary>
            [NameInMap("CategoryGroupCode")]
            [Validation(Required=false)]
            public string CategoryGroupCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>产品消息</para>
            /// </summary>
            [NameInMap("CategoryGroupName")]
            [Validation(Required=false)]
            public string CategoryGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>产品教育内容</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("ChannelConfigs")]
            [Validation(Required=false)]
            public List<ReadUserSubscriptionListResponseBodyDataChannelConfigs> ChannelConfigs { get; set; }
            public class ReadUserSubscriptionListResponseBodyDataChannelConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>email</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>YES</para>
                /// </summary>
                [NameInMap("CheckedState")]
                [Validation(Required=false)]
                public string CheckedState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>YES</para>
                /// </summary>
                [NameInMap("DefaultChecked")]
                [Validation(Required=false)]
                public string DefaultChecked { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("FatigueDayLimit")]
                [Validation(Required=false)]
                public int? FatigueDayLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>YES</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public string Optional { get; set; }

            }

            [NameInMap("Contact")]
            [Validation(Required=false)]
            public ReadUserSubscriptionListResponseBodyDataContact Contact { get; set; }
            public class ReadUserSubscriptionListResponseBodyDataContact : TeaModel {
                [NameInMap("CommonContacts")]
                [Validation(Required=false)]
                public List<ReadUserSubscriptionListResponseBodyDataContactCommonContacts> CommonContacts { get; set; }
                public class ReadUserSubscriptionListResponseBodyDataContactCommonContacts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("AliUid")]
                    [Validation(Required=false)]
                    public long? AliUid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>t*@qq.*</para>
                    /// </summary>
                    [NameInMap("ContactEmail")]
                    [Validation(Required=false)]
                    public string ContactEmail { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public long? ContactId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>130*90</para>
                    /// </summary>
                    [NameInMap("ContactMobile")]
                    [Validation(Required=false)]
                    public string ContactMobile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EmailConfirmed")]
                    [Validation(Required=false)]
                    public bool? EmailConfirmed { get; set; }

                    [NameInMap("MessageSource")]
                    [Validation(Required=false)]
                    public ReadUserSubscriptionListResponseBodyDataContactCommonContactsMessageSource MessageSource { get; set; }
                    public class ReadUserSubscriptionListResponseBodyDataContactCommonContactsMessageSource : TeaModel {
                        [NameInMap("KeywordBlacklist")]
                        [Validation(Required=false)]
                        public List<string> KeywordBlacklist { get; set; }

                        [NameInMap("KeywordWhitelist")]
                        [Validation(Required=false)]
                        public List<string> KeywordWhitelist { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("MobileConfirmed")]
                    [Validation(Required=false)]
                    public bool? MobileConfirmed { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CEO</para>
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public string Position { get; set; }

                }

                [NameInMap("WebhookContacts")]
                [Validation(Required=false)]
                public List<ReadUserSubscriptionListResponseBodyDataContactWebhookContacts> WebhookContacts { get; set; }
                public class ReadUserSubscriptionListResponseBodyDataContactWebhookContacts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public long? ContactId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ContactName")]
                    [Validation(Required=false)]
                    public string ContactName { get; set; }

                    [NameInMap("MessageSource")]
                    [Validation(Required=false)]
                    public ReadUserSubscriptionListResponseBodyDataContactWebhookContactsMessageSource MessageSource { get; set; }
                    public class ReadUserSubscriptionListResponseBodyDataContactWebhookContactsMessageSource : TeaModel {
                        [NameInMap("KeywordBlacklist")]
                        [Validation(Required=false)]
                        public List<string> KeywordBlacklist { get; set; }

                        [NameInMap("KeywordWhitelist")]
                        [Validation(Required=false)]
                        public List<string> KeywordWhitelist { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("SecurityToken")]
                    [Validation(Required=false)]
                    public string SecurityToken { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxxxxxxx">https://oapi.dingtalk.com/robot/send?access_token=xxxxxxxx</a></para>
                    /// </summary>
                    [NameInMap("ServerUrl")]
                    [Validation(Required=false)]
                    public string ServerUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dingtalk</para>
                    /// </summary>
                    [NameInMap("WebhookType")]
                    [Validation(Required=false)]
                    public string WebhookType { get; set; }

                }

            }

            [NameInMap("ReceiveTimeList")]
            [Validation(Required=false)]
            public List<int?> ReceiveTimeList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

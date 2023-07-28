// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListResponseBody : TeaModel {
        /// <summary>
        /// The description of the alert contact.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The status of the phone number. Valid values:
        /// 
        /// *   PENDING: The phone number is not activated. Alert notifications can be sent to the phone number by using text messages only after the phone number is activated.
        /// *   OK: The phone number is activated and can receive alert notifications.
        /// 
        /// >  This parameter can be returned only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public DescribeContactListResponseBodyContacts Contacts { get; set; }
        public class DescribeContactListResponseBodyContacts : TeaModel {
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public List<DescribeContactListResponseBodyContactsContact> Contact { get; set; }
            public class DescribeContactListResponseBodyContactsContact : TeaModel {
                /// <summary>
                /// The status of the email address. Valid values:
                /// 
                /// *   PENDING: The email address is not activated. Alert notifications can be sent to the email address only after the email address is activated.
                /// *   OK: The email address is activated and can receive alert notifications.
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactChannels Channels { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannels : TeaModel {
                    /// <summary>
                    /// The alert notification method. Valid values:
                    /// 
                    /// *   Mail: emails
                    /// *   DingWebHook: DingTalk chatbots
                    /// </summary>
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    /// <summary>
                    /// The timestamp when the alert contact was updated.
                    /// 
                    /// Unit: milliseconds.
                    /// </summary>
                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    /// <summary>
                    /// The alert contact groups.
                    /// </summary>
                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    /// <summary>
                    /// The ID of the request.
                    /// </summary>
                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                /// <summary>
                /// The status of the alert notification method. Valid values: PENDING and OK.
                /// 
                /// The email address must be activated after it is added as the value specified for the alert notification method. The value PENDING indicates that the email address is not activated. The value OK indicates that the email address is activated.
                /// </summary>
                [NameInMap("ChannelsState")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactChannelsState ChannelsState { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannelsState : TeaModel {
                    /// <summary>
                    /// Queries alert contacts.
                    /// </summary>
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    /// <summary>
                    /// The status of the DingTalk chatbot.
                    /// 
                    /// Valid value: OK. The value OK indicates that the DingTalk chatbot is normal and alert notifications can be received in a DingTalk group.
                    /// </summary>
                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                /// <summary>
                /// The alert notification method.
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactContactGroups ContactGroups { get; set; }
                public class DescribeContactListResponseBodyContactsContactContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }

                /// <summary>
                /// The name of the alert contact.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The alert contacts.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The timestamp when the alert contact was created.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// The number of the page to return.
                /// 
                /// Default value: 1.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The email address of the alert contact.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The language in which the alert information is displayed. Valid values:
        /// 
        /// *   zh-cn: simplified Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 100.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The TradeManager ID of the alert contact.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListByContactGroupResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The alert group.
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public DescribeContactListByContactGroupResponseBodyContacts Contacts { get; set; }
        public class DescribeContactListByContactGroupResponseBodyContacts : TeaModel {
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public List<DescribeContactListByContactGroupResponseBodyContactsContact> Contact { get; set; }
            public class DescribeContactListByContactGroupResponseBodyContactsContact : TeaModel {
                /// <summary>
                /// The alert notification targets.
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public DescribeContactListByContactGroupResponseBodyContactsContactChannels Channels { get; set; }
                public class DescribeContactListByContactGroupResponseBodyContactsContactChannels : TeaModel {
                    /// <summary>
                    /// The TradeManager ID of the alert contact.
                    /// 
                    /// >  This parameter can be returned only on the China site (aliyun.com).
                    /// </summary>
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    /// <summary>
                    /// The webhook URL of the DingTalk chatbot.
                    /// </summary>
                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    /// <summary>
                    /// The email address of the alert contact.
                    /// </summary>
                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    /// <summary>
                    /// The phone number of the alert contact.
                    /// 
                    /// >  This parameter can be returned only on the China site (aliyun.com).
                    /// </summary>
                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                /// <summary>
                /// The time when the alert contact was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The description of the alert contact.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The name of the alert contact.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The time when the alert contact was modified.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

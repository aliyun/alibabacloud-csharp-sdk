// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QuerySendDetailsResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The response code.
        /// 
        /// If OK is returned, the request is successful. Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html?spm=a2c4g.419277.0.i11).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<QuerySendDetailsResponseBodyModel> Model { get; set; }
        public class QuerySendDetailsResponseBodyModel : TeaModel {
            /// <summary>
            /// The content of the text message.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The status code returned by the carrier.
            /// 
            /// *   If the text message was delivered, "DELIVERED" is returned.
            /// *   If the text message failed to be sent, see [Error codes](https://help.aliyun.com/document_detail/101347.html?spm=a2c4g.419277.0.i8) for more information.
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            /// <summary>
            /// The extension field.
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// The phone number.
            /// </summary>
            [NameInMap("PhoneNum")]
            [Validation(Required=false)]
            public string PhoneNum { get; set; }

            /// <summary>
            /// The date and time when the text message was received.
            /// </summary>
            [NameInMap("ReceiveDate")]
            [Validation(Required=false)]
            public string ReceiveDate { get; set; }

            /// <summary>
            /// The date when the text message was sent. You can query text messages that were sent within the last 30 days.
            /// 
            /// The date is in the yyyyMMdd format. Example: 20181225.
            /// </summary>
            [NameInMap("SendDate")]
            [Validation(Required=false)]
            public string SendDate { get; set; }

            /// <summary>
            /// The delivery status of the text message.
            /// 
            /// *   1: A delivery receipt is to be sent.
            /// *   2: The text message failed to be sent.
            /// *   3: The text message was sent.
            /// </summary>
            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public long? SendStatus { get; set; }

            /// <summary>
            /// The code of the text message template.
            /// 
            /// Log on to the SMS console. In the left-side navigation pane, click **Go China** or **Go Globe**. You can view the text message template code in the **Template Code** column on the **Message Templates** tab.
            /// 
            /// >  The text message templates must be created on the Go Globe page and approved.
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries in the list.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

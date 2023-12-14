// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEventDisposeResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEventDisposeResponseBodyData Data { get; set; }
        public class DescribeEventDisposeResponseBodyData : TeaModel {
            /// <summary>
            /// An array consisting of JSON objects that are configured for event handling.
            /// </summary>
            [NameInMap("EventDispose")]
            [Validation(Required=false)]
            public List<object> EventDispose { get; set; }

            /// <summary>
            /// The JSON object that is configured for an alert recipient.
            /// </summary>
            [NameInMap("ReceiverInfo")]
            [Validation(Required=false)]
            public DescribeEventDisposeResponseBodyDataReceiverInfo ReceiverInfo { get; set; }
            public class DescribeEventDisposeResponseBodyDataReceiverInfo : TeaModel {
                /// <summary>
                /// The channel of the contact information. Valid values:
                /// 
                /// *   message
                /// *   mail
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The modification time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the recipient who receives the event handling result.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The UUID of the event.
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// The message title.
                /// </summary>
                [NameInMap("MessageTitle")]
                [Validation(Required=false)]
                public string MessageTitle { get; set; }

                /// <summary>
                /// The contact information of the recipient.
                /// </summary>
                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                /// <summary>
                /// Indicates whether the message is sent. Valid values:
                /// 
                /// *   0: not sent
                /// *   1: sent
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// The description of the event.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the event. Valid values:
            /// 
            /// *   0: not handled
            /// *   1: handing
            /// *   5: handling failed
            /// *   10: handled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

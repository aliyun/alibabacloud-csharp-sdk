// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendDetailsResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html).
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the message.
        /// </summary>
        [NameInMap("SmsSendDetailDTOs")]
        [Validation(Required=false)]
        public QuerySendDetailsResponseBodySmsSendDetailDTOs SmsSendDetailDTOs { get; set; }
        public class QuerySendDetailsResponseBodySmsSendDetailDTOs : TeaModel {
            [NameInMap("SmsSendDetailDTO")]
            [Validation(Required=false)]
            public List<QuerySendDetailsResponseBodySmsSendDetailDTOsSmsSendDetailDTO> SmsSendDetailDTO { get; set; }
            public class QuerySendDetailsResponseBodySmsSendDetailDTOsSmsSendDetailDTO : TeaModel {
                /// <summary>
                /// The content of the message.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The status code returned by the carrier.
                /// 
                /// *   If the message is delivered, "DELIVERED" is returned.
                /// *   For information about the error codes that may be returned if the message is not delivered, see [error codes](https://help.aliyun.com/document_detail/101347.html).
                /// </summary>
                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// The extended field.
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// The mobile numbers of the recipients.
                /// </summary>
                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                /// <summary>
                /// The date and time when the message was received.
                /// </summary>
                [NameInMap("ReceiveDate")]
                [Validation(Required=false)]
                public string ReceiveDate { get; set; }

                /// <summary>
                /// The date and time when the message was sent.
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// The delivery status of the message. Valid values:
                /// 
                /// *   **1**: The message has not received a delivery receipt yet.
                /// *   **2**: The message failed to be delivered.
                /// *   **3**: The message was delivered.
                /// </summary>
                [NameInMap("SendStatus")]
                [Validation(Required=false)]
                public long? SendStatus { get; set; }

                /// <summary>
                /// The ID of the message template.
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

        }

        /// <summary>
        /// The number of sent messages.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

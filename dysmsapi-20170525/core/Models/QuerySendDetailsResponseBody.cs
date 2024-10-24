// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other values indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819BE656-D2E0-4858-8B21-B2E477085AAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the message.</para>
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
                /// <para>The content of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>【Aliyun】This is a test message.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The status code returned by the carrier.</para>
                /// <list type="bullet">
                /// <item><description>If the message is delivered, &quot;DELIVERED&quot; is returned.</description></item>
                /// <item><description>For information about the error codes that may be returned if the message is not delivered, see <a href="https://help.aliyun.com/document_detail/101347.html">error codes</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DELIVERED</para>
                /// </summary>
                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// <para>The extended field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>The mobile numbers of the recipients.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1390000****</para>
                /// </summary>
                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                /// <summary>
                /// <para>The date and time when the message was received.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-08 16:44:13</para>
                /// </summary>
                [NameInMap("ReceiveDate")]
                [Validation(Required=false)]
                public string ReceiveDate { get; set; }

                /// <summary>
                /// <para>The date and time when the message was sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-08 16:44:10</para>
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// <para>The delivery status of the message. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The message has not received a delivery receipt yet.</description></item>
                /// <item><description><b>2</b>: The message failed to be delivered.</description></item>
                /// <item><description><b>3</b>: The message was delivered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SendStatus")]
                [Validation(Required=false)]
                public long? SendStatus { get; set; }

                /// <summary>
                /// <para>The ID of the message template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMS_12231****</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of sent messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

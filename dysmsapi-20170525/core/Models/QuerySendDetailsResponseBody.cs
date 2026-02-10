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

        [NameInMap("SmsSendDetailDTOs")]
        [Validation(Required=false)]
        public QuerySendDetailsResponseBodySmsSendDetailDTOs SmsSendDetailDTOs { get; set; }
        public class QuerySendDetailsResponseBodySmsSendDetailDTOs : TeaModel {
            [NameInMap("SmsSendDetailDTO")]
            [Validation(Required=false)]
            public List<QuerySendDetailsResponseBodySmsSendDetailDTOsSmsSendDetailDTO> SmsSendDetailDTO { get; set; }
            public class QuerySendDetailsResponseBodySmsSendDetailDTOsSmsSendDetailDTO : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                [NameInMap("ReceiveDate")]
                [Validation(Required=false)]
                public string ReceiveDate { get; set; }

                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                [NameInMap("SendStatus")]
                [Validation(Required=false)]
                public long? SendStatus { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendDetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

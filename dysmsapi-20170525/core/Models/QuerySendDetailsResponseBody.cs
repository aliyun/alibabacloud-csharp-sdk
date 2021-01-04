// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendDetailsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("SmsSendDetailDTOs")]
        [Validation(Required=false)]
        public QuerySendDetailsResponseBodySmsSendDetailDTOs SmsSendDetailDTOs { get; set; }
        public class QuerySendDetailsResponseBodySmsSendDetailDTOs : TeaModel {
            [NameInMap("SmsSendDetailDTO")]
            [Validation(Required=false)]
            public List<QuerySendDetailsResponseBodySmsSendDetailDTOsSmsSendDetailDTO> SmsSendDetailDTO { get; set; }
            public class QuerySendDetailsResponseBodySmsSendDetailDTOsSmsSendDetailDTO : TeaModel {
                public string ErrCode { get; set; }
                public string TemplateCode { get; set; }
                public string OutId { get; set; }
                public string ReceiveDate { get; set; }
                public string SendDate { get; set; }
                public string PhoneNum { get; set; }
                public string Content { get; set; }
                public long? SendStatus { get; set; }
            }
        };

    }

}

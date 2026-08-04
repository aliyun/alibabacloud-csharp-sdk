// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryBindsByPkResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryBindsByPkResponseBodyData> Data { get; set; }
        public class QueryBindsByPkResponseBodyData : TeaModel {
            [NameInMap("BindData")]
            [Validation(Required=false)]
            public Dictionary<string, object> BindData { get; set; }

            [NameInMap("MinorOuterId")]
            [Validation(Required=false)]
            public string MinorOuterId { get; set; }

            [NameInMap("OuterId")]
            [Validation(Required=false)]
            public string OuterId { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

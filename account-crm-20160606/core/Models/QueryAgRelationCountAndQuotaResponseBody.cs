// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAgRelationCountAndQuotaResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAgRelationCountAndQuotaResponseBodyData Data { get; set; }
        public class QueryAgRelationCountAndQuotaResponseBodyData : TeaModel {
            [NameInMap("AccountCount")]
            [Validation(Required=false)]
            public long? AccountCount { get; set; }

            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public string Mpk { get; set; }

            [NameInMap("NullObject")]
            [Validation(Required=false)]
            public bool? NullObject { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public int? Quota { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NullObject")]
        [Validation(Required=false)]
        public bool? NullObject { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

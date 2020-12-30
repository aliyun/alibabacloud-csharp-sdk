// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QuerySignByParamResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QuerySignByParamResponseBodyData Data { get; set; }
        public class QuerySignByParamResponseBodyData : TeaModel {
            [NameInMap("sign")]
            [Validation(Required=false)]
            public List<QuerySignByParamResponseBodyDataSign> Sign { get; set; }
            public class QuerySignByParamResponseBodyDataSign : TeaModel {
                public string Remark { get; set; }
                public string AuditState { get; set; }
                public string GmtCreate { get; set; }
                public long? SignId { get; set; }
                public string SignName { get; set; }
                public string OrderId { get; set; }
                public string RejectInfo { get; set; }
                public string SignType { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

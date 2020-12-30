// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryDomainByParamResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryDomainByParamResponseBodyData Data { get; set; }
        public class QueryDomainByParamResponseBodyData : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public List<QueryDomainByParamResponseBodyDataDomain> Domain { get; set; }
            public class QueryDomainByParamResponseBodyDataDomain : TeaModel {
                public string DomainRecord { get; set; }
                public string SpfAuthStatus { get; set; }
                public string MxAuthStatus { get; set; }
                public string CreateTime { get; set; }
                public string CnameAuthStatus { get; set; }
                public string ConfirmStatus { get; set; }
                public string IcpStatus { get; set; }
                public long? UtcCreateTime { get; set; }
                public string DomainStatus { get; set; }
                public string DomainName { get; set; }
                public string DomainId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

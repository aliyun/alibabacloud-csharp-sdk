// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryDomainByParamResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryDomainByParamResponseBodyData Data { get; set; }
        public class QueryDomainByParamResponseBodyData : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public List<QueryDomainByParamResponseBodyDataDomain> Domain { get; set; }
            public class QueryDomainByParamResponseBodyDataDomain : TeaModel {
                [NameInMap("CnameAuthStatus")]
                [Validation(Required=false)]
                public string CnameAuthStatus { get; set; }

                [NameInMap("ConfirmStatus")]
                [Validation(Required=false)]
                public string ConfirmStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainRecord")]
                [Validation(Required=false)]
                public string DomainRecord { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                [NameInMap("IcpStatus")]
                [Validation(Required=false)]
                public string IcpStatus { get; set; }

                [NameInMap("MxAuthStatus")]
                [Validation(Required=false)]
                public string MxAuthStatus { get; set; }

                [NameInMap("SpfAuthStatus")]
                [Validation(Required=false)]
                public string SpfAuthStatus { get; set; }

                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}

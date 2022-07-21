// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDomainListResponseBodyData Data { get; set; }
        public class QueryDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<QueryDomainListResponseBodyDataDomain> Domain { get; set; }
            public class QueryDomainListResponseBodyDataDomain : TeaModel {
                public string DomainAuditStatus { get; set; }
                public string DomainGroupId { get; set; }
                public string DomainGroupName { get; set; }
                public string DomainName { get; set; }
                public string DomainStatus { get; set; }
                public string DomainType { get; set; }
                public int? ExpirationCurrDateDiff { get; set; }
                public string ExpirationDate { get; set; }
                public long? ExpirationDateLong { get; set; }
                public string ExpirationDateStatus { get; set; }
                public string InstanceId { get; set; }
                public bool? Premium { get; set; }
                public string ProductId { get; set; }
                public string RegistrantType { get; set; }
                public string RegistrationDate { get; set; }
                public long? RegistrationDateLong { get; set; }
                public string Remark { get; set; }
            }
        };

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}

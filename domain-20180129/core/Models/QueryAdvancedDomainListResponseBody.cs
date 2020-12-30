// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryAdvancedDomainListResponseBody : TeaModel {
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAdvancedDomainListResponseBodyData Data { get; set; }
        public class QueryAdvancedDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<QueryAdvancedDomainListResponseBodyDataDomain> Domain { get; set; }
            public class QueryAdvancedDomainListResponseBodyDataDomain : TeaModel {
                public string DomainAuditStatus { get; set; }
                public string DomainGroupId { get; set; }
                public string Remark { get; set; }
                public string DomainGroupName { get; set; }
                public string ZhRegistrantOrganization { get; set; }
                public string RegistrantOrganization { get; set; }
                public string RegistrationDate { get; set; }
                public string InstanceId { get; set; }
                public string DomainName { get; set; }
                public string ExpirationDateStatus { get; set; }
                public string ExpirationDate { get; set; }
                public QueryAdvancedDomainListResponseBodyDataDomainDnsList DnsList { get; set; }
                public class QueryAdvancedDomainListResponseBodyDataDomainDnsList : TeaModel {
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public List<string> Dns { get; set; }

                }
                public string Email { get; set; }
                public string RegistrantType { get; set; }
                public long? ExpirationDateLong { get; set; }
                public int? ExpirationCurrDateDiff { get; set; }
                public bool? Premium { get; set; }
                public long? RegistrationDateLong { get; set; }
                public string ProductId { get; set; }
                public string DomainStatus { get; set; }
                public string DomainType { get; set; }
            }
        };

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

    }

}

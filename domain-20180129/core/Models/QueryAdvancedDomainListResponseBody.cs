// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryAdvancedDomainListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAdvancedDomainListResponseBodyData Data { get; set; }
        public class QueryAdvancedDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<QueryAdvancedDomainListResponseBodyDataDomain> Domain { get; set; }
            public class QueryAdvancedDomainListResponseBodyDataDomain : TeaModel {
                [NameInMap("DnsList")]
                [Validation(Required=false)]
                public QueryAdvancedDomainListResponseBodyDataDomainDnsList DnsList { get; set; }
                public class QueryAdvancedDomainListResponseBodyDataDomainDnsList : TeaModel {
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public List<string> Dns { get; set; }

                }

                [NameInMap("DomainAuditStatus")]
                [Validation(Required=false)]
                public string DomainAuditStatus { get; set; }

                [NameInMap("DomainGroupId")]
                [Validation(Required=false)]
                public string DomainGroupId { get; set; }

                [NameInMap("DomainGroupName")]
                [Validation(Required=false)]
                public string DomainGroupName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("ExpirationCurrDateDiff")]
                [Validation(Required=false)]
                public int? ExpirationCurrDateDiff { get; set; }

                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                [NameInMap("ExpirationDateLong")]
                [Validation(Required=false)]
                public long? ExpirationDateLong { get; set; }

                [NameInMap("ExpirationDateStatus")]
                [Validation(Required=false)]
                public string ExpirationDateStatus { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Premium")]
                [Validation(Required=false)]
                public bool? Premium { get; set; }

                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                [NameInMap("RegistrantOrganization")]
                [Validation(Required=false)]
                public string RegistrantOrganization { get; set; }

                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                [NameInMap("RegistrationDate")]
                [Validation(Required=false)]
                public string RegistrationDate { get; set; }

                [NameInMap("RegistrationDateLong")]
                [Validation(Required=false)]
                public long? RegistrationDateLong { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public QueryAdvancedDomainListResponseBodyDataDomainTag Tag { get; set; }
                public class QueryAdvancedDomainListResponseBodyDataDomainTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<QueryAdvancedDomainListResponseBodyDataDomainTagTag> Tag { get; set; }
                    public class QueryAdvancedDomainListResponseBodyDataDomainTagTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("ZhRegistrantOrganization")]
                [Validation(Required=false)]
                public string ZhRegistrantOrganization { get; set; }

            }

        }

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

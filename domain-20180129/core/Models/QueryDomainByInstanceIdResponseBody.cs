// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainByInstanceIdResponseBody : TeaModel {
        [NameInMap("DnsList")]
        [Validation(Required=false)]
        public QueryDomainByInstanceIdResponseBodyDnsList DnsList { get; set; }
        public class QueryDomainByInstanceIdResponseBodyDnsList : TeaModel {
            [NameInMap("Dns")]
            [Validation(Required=false)]
            public List<string> Dns { get; set; }

        }

        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainNameProxyService")]
        [Validation(Required=false)]
        public bool? DomainNameProxyService { get; set; }

        [NameInMap("DomainNameVerificationStatus")]
        [Validation(Required=false)]
        public string DomainNameVerificationStatus { get; set; }

        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("EmailVerificationClientHold")]
        [Validation(Required=false)]
        public bool? EmailVerificationClientHold { get; set; }

        [NameInMap("EmailVerificationStatus")]
        [Validation(Required=false)]
        public int? EmailVerificationStatus { get; set; }

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

        [NameInMap("RealNameStatus")]
        [Validation(Required=false)]
        public string RealNameStatus { get; set; }

        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        [NameInMap("RegistrantOrganization")]
        [Validation(Required=false)]
        public string RegistrantOrganization { get; set; }

        [NameInMap("RegistrantType")]
        [Validation(Required=false)]
        public string RegistrantType { get; set; }

        [NameInMap("RegistrantUpdatingStatus")]
        [Validation(Required=false)]
        public string RegistrantUpdatingStatus { get; set; }

        [NameInMap("RegistrationDate")]
        [Validation(Required=false)]
        public string RegistrationDate { get; set; }

        [NameInMap("RegistrationDateLong")]
        [Validation(Required=false)]
        public long? RegistrationDateLong { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public QueryDomainByInstanceIdResponseBodyTag Tag { get; set; }
        public class QueryDomainByInstanceIdResponseBodyTag : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<QueryDomainByInstanceIdResponseBodyTagTag> Tag { get; set; }
            public class QueryDomainByInstanceIdResponseBodyTagTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("TransferOutStatus")]
        [Validation(Required=false)]
        public string TransferOutStatus { get; set; }

        [NameInMap("TransferProhibitionLock")]
        [Validation(Required=false)]
        public string TransferProhibitionLock { get; set; }

        [NameInMap("UpdateProhibitionLock")]
        [Validation(Required=false)]
        public string UpdateProhibitionLock { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}

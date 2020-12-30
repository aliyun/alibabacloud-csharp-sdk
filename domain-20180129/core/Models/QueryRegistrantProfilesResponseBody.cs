// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryRegistrantProfilesResponseBody : TeaModel {
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

        [NameInMap("RegistrantProfiles")]
        [Validation(Required=false)]
        public QueryRegistrantProfilesResponseBodyRegistrantProfiles RegistrantProfiles { get; set; }
        public class QueryRegistrantProfilesResponseBodyRegistrantProfiles : TeaModel {
            [NameInMap("RegistrantProfile")]
            [Validation(Required=false)]
            public List<QueryRegistrantProfilesResponseBodyRegistrantProfilesRegistrantProfile> RegistrantProfile { get; set; }
            public class QueryRegistrantProfilesResponseBodyRegistrantProfilesRegistrantProfile : TeaModel {
                public string TelExt { get; set; }
                public string UpdateTime { get; set; }
                public string ZhProvince { get; set; }
                public string CreateTime { get; set; }
                public string Telephone { get; set; }
                public string RegistrantOrganization { get; set; }
                public string City { get; set; }
                public string ZhCity { get; set; }
                public string TelArea { get; set; }
                public string Address { get; set; }
                public string RealNameStatus { get; set; }
                public string PostalCode { get; set; }
                public string RegistrantProfileType { get; set; }
                public long? RegistrantProfileId { get; set; }
                public string ZhRegistrantOrganization { get; set; }
                public bool? DefaultRegistrantProfile { get; set; }
                public string ZhRegistrantName { get; set; }
                public string Email { get; set; }
                public string RegistrantType { get; set; }
                public string Country { get; set; }
                public string RegistrantName { get; set; }
                public int? EmailVerificationStatus { get; set; }
                public string ZhAddress { get; set; }
                public string Province { get; set; }
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class ListEnterpriseInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnterpriseInfoResponseBodyData> Data { get; set; }
        public class ListEnterpriseInfoResponseBodyData : TeaModel {
            [NameInMap("AuditDesc")]
            [Validation(Required=false)]
            public string AuditDesc { get; set; }

            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public long? EnterpriseId { get; set; }

            [NameInMap("EnterpriseName")]
            [Validation(Required=false)]
            public string EnterpriseName { get; set; }

            [NameInMap("ManagerContactNumber")]
            [Validation(Required=false)]
            public string ManagerContactNumber { get; set; }

            [NameInMap("ManagerName")]
            [Validation(Required=false)]
            public string ManagerName { get; set; }

            [NameInMap("OrganizationCode")]
            [Validation(Required=false)]
            public string OrganizationCode { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

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

    }

}

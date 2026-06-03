// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class ListSchemeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSchemeResponseBodyData> Data { get; set; }
        public class ListSchemeResponseBodyData : TeaModel {
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public long? ApplyTime { get; set; }

            [NameInMap("AuditDesc")]
            [Validation(Required=false)]
            public string AuditDesc { get; set; }

            [NameInMap("BusinessTypeList")]
            [Validation(Required=false)]
            public List<int?> BusinessTypeList { get; set; }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("SchemeId")]
            [Validation(Required=false)]
            public long? SchemeId { get; set; }

            [NameInMap("SchemeName")]
            [Validation(Required=false)]
            public string SchemeName { get; set; }

            [NameInMap("SchemeType")]
            [Validation(Required=false)]
            public int? SchemeType { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryMaterialListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMaterialListResponseBodyData Data { get; set; }
        public class QueryMaterialListResponseBodyData : TeaModel {
            [NameInMap("Trademark")]
            [Validation(Required=false)]
            public List<QueryMaterialListResponseBodyDataTrademark> Trademark { get; set; }
            public class QueryMaterialListResponseBodyDataTrademark : TeaModel {
                [NameInMap("CardNumber")]
                [Validation(Required=false)]
                public string CardNumber { get; set; }

                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LoaKey")]
                [Validation(Required=false)]
                public string LoaKey { get; set; }

                [NameInMap("LoaStatus")]
                [Validation(Required=false)]
                public int? LoaStatus { get; set; }

                [NameInMap("MaterialVersion")]
                [Validation(Required=false)]
                public string MaterialVersion { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PrincipalDescription")]
                [Validation(Required=false)]
                public string PrincipalDescription { get; set; }

                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public int? PrincipalName { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SystemVersion")]
                [Validation(Required=false)]
                public string SystemVersion { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("ValidDate")]
                [Validation(Required=false)]
                public long? ValidDate { get; set; }

            }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

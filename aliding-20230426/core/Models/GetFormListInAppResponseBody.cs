// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFormListInAppResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetFormListInAppResponseBodyData> Data { get; set; }
        public class GetFormListInAppResponseBodyData : TeaModel {
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("FormType")]
            [Validation(Required=false)]
            public string FormType { get; set; }

            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public GetFormListInAppResponseBodyDataTitle Title { get; set; }
            public class GetFormListInAppResponseBodyDataTitle : TeaModel {
                [NameInMap("EnUS")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                [NameInMap("ZhCN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}

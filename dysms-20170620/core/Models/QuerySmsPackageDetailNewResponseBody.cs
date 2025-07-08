// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsPackageDetailNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySmsPackageDetailNewResponseBodyList List { get; set; }
        public class QuerySmsPackageDetailNewResponseBodyList : TeaModel {
            [NameInMap("SmsPackageDetailDTO")]
            [Validation(Required=false)]
            public List<QuerySmsPackageDetailNewResponseBodyListSmsPackageDetailDTO> SmsPackageDetailDTO { get; set; }
            public class QuerySmsPackageDetailNewResponseBodyListSmsPackageDetailDTO : TeaModel {
                [NameInMap("InvalidTime")]
                [Validation(Required=false)]
                public long? InvalidTime { get; set; }

                [NameInMap("OrderTime")]
                [Validation(Required=false)]
                public long? OrderTime { get; set; }

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                [NameInMap("RemainCount")]
                [Validation(Required=false)]
                public long? RemainCount { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RemainSmsCount")]
        [Validation(Required=false)]
        public long? RemainSmsCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("TotalSmsCount")]
        [Validation(Required=false)]
        public long? TotalSmsCount { get; set; }

    }

}

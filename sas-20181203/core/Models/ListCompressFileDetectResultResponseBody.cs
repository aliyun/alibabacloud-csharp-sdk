// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCompressFileDetectResultResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCompressFileDetectResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListCompressFileDetectResultResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<ListCompressFileDetectResultResponseBodyResultList> ResultList { get; set; }
        public class ListCompressFileDetectResultResponseBodyResultList : TeaModel {
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("VirusType")]
            [Validation(Required=false)]
            public string VirusType { get; set; }

        }

    }

}

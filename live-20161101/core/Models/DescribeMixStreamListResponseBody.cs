// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeMixStreamListResponseBody : TeaModel {
        [NameInMap("MixStreamList")]
        [Validation(Required=false)]
        public List<DescribeMixStreamListResponseBodyMixStreamList> MixStreamList { get; set; }
        public class DescribeMixStreamListResponseBodyMixStreamList : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InputStreamNumber")]
            [Validation(Required=false)]
            public int? InputStreamNumber { get; set; }

            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            [NameInMap("MixStreamTemplate")]
            [Validation(Required=false)]
            public string MixStreamTemplate { get; set; }

            [NameInMap("MixstreamId")]
            [Validation(Required=false)]
            public string MixstreamId { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

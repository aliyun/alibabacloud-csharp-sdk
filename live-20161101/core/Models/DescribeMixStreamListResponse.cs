// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeMixStreamListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("MixStreamList")]
        [Validation(Required=true)]
        public List<DescribeMixStreamListResponseMixStreamList> MixStreamList { get; set; }
        public class DescribeMixStreamListResponseMixStreamList : TeaModel {
            [NameInMap("MixstreamId")]
            [Validation(Required=true)]
            public string MixstreamId { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=true)]
            public string AppName { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=true)]
            public string StreamName { get; set; }

            [NameInMap("LayoutId")]
            [Validation(Required=true)]
            public string LayoutId { get; set; }

            [NameInMap("InputStreamNumber")]
            [Validation(Required=true)]
            public int? InputStreamNumber { get; set; }

            [NameInMap("MixStreamTemplate")]
            [Validation(Required=true)]
            public string MixStreamTemplate { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }

        }

    }

}

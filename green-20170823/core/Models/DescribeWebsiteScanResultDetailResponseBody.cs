// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeWebsiteScanResultDetailResponseBody : TeaModel {
        [NameInMap("Baseline")]
        [Validation(Required=false)]
        public string Baseline { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("HitKeywords")]
        [Validation(Required=false)]
        public List<string> HitKeywords { get; set; }

        [NameInMap("ImageScanResults")]
        [Validation(Required=false)]
        public List<DescribeWebsiteScanResultDetailResponseBodyImageScanResults> ImageScanResults { get; set; }
        public class DescribeWebsiteScanResultDetailResponseBodyImageScanResults : TeaModel {
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("TamperedSource")]
        [Validation(Required=false)]
        public string TamperedSource { get; set; }

    }

}

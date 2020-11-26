// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceUsageResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("FaceUsageList")]
        [Validation(Required=true)]
        public List<DescribeFaceUsageResponseFaceUsageList> FaceUsageList { get; set; }
        public class DescribeFaceUsageResponseFaceUsageList : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=true)]
            public string Date { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }

        }

    }

}

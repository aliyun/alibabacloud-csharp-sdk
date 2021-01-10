// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class DescribeStreamPredictsResponseBody : TeaModel {
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("StreamPredicts")]
        [Validation(Required=false)]
        public List<DescribeStreamPredictsResponseBodyStreamPredicts> StreamPredicts { get; set; }
        public class DescribeStreamPredictsResponseBodyStreamPredicts : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Notify")]
            [Validation(Required=false)]
            public string Notify { get; set; }

            [NameInMap("PredictId")]
            [Validation(Required=false)]
            public string PredictId { get; set; }

            [NameInMap("ModelUserData")]
            [Validation(Required=false)]
            public string ModelUserData { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            [NameInMap("PredictTemplateId")]
            [Validation(Required=false)]
            public string PredictTemplateId { get; set; }

            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

            [NameInMap("AutoStart")]
            [Validation(Required=false)]
            public string AutoStart { get; set; }

            [NameInMap("ProbabilityThresholds")]
            [Validation(Required=false)]
            public string ProbabilityThresholds { get; set; }

            [NameInMap("DetectIntervals")]
            [Validation(Required=false)]
            public string DetectIntervals { get; set; }

            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public string StreamType { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("ModelIds")]
            [Validation(Required=false)]
            public string ModelIds { get; set; }

            [NameInMap("FaceGroupId")]
            [Validation(Required=false)]
            public string FaceGroupId { get; set; }

        }

    }

}

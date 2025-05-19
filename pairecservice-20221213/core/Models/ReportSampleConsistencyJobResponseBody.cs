// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ReportSampleConsistencyJobResponseBody : TeaModel {
        [NameInMap("FeaturesDifference")]
        [Validation(Required=false)]
        public List<ReportSampleConsistencyJobResponseBodyFeaturesDifference> FeaturesDifference { get; set; }
        public class ReportSampleConsistencyJobResponseBodyFeaturesDifference : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            [NameInMap("FeatureType")]
            [Validation(Required=false)]
            public string FeatureType { get; set; }

            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

        }

        [NameInMap("ReplyTableFeatures")]
        [Validation(Required=false)]
        public long? ReplyTableFeatures { get; set; }

        [NameInMap("ReplyTableLostFeatures")]
        [Validation(Required=false)]
        public long? ReplyTableLostFeatures { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public long? RequestId { get; set; }

        [NameInMap("SampleTableFeatures")]
        [Validation(Required=false)]
        public long? SampleTableFeatures { get; set; }

        [NameInMap("SampleTableLostFeatures")]
        [Validation(Required=false)]
        public long? SampleTableLostFeatures { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QuerySampleConsistencyJobDifferenceResponseBody : TeaModel {
        [NameInMap("DifferenceHistogram")]
        [Validation(Required=false)]
        public List<QuerySampleConsistencyJobDifferenceResponseBodyDifferenceHistogram> DifferenceHistogram { get; set; }
        public class QuerySampleConsistencyJobDifferenceResponseBodyDifferenceHistogram : TeaModel {
            [NameInMap("Abscissa")]
            [Validation(Required=false)]
            public string Abscissa { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

        [NameInMap("NumberFeatureDifferences")]
        [Validation(Required=false)]
        public List<QuerySampleConsistencyJobDifferenceResponseBodyNumberFeatureDifferences> NumberFeatureDifferences { get; set; }
        public class QuerySampleConsistencyJobDifferenceResponseBodyNumberFeatureDifferences : TeaModel {
            [NameInMap("DiffValue")]
            [Validation(Required=false)]
            public double? DiffValue { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ReplyTableFeatureValue")]
            [Validation(Required=false)]
            public double? ReplyTableFeatureValue { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("SampleTableFeatureValue")]
            [Validation(Required=false)]
            public double? SampleTableFeatureValue { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StringFeatureDifferences")]
        [Validation(Required=false)]
        public List<QuerySampleConsistencyJobDifferenceResponseBodyStringFeatureDifferences> StringFeatureDifferences { get; set; }
        public class QuerySampleConsistencyJobDifferenceResponseBodyStringFeatureDifferences : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ReplyTableFeatureValue")]
            [Validation(Required=false)]
            public string ReplyTableFeatureValue { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("SampleTableFeatureValue")]
            [Validation(Required=false)]
            public string SampleTableFeatureValue { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

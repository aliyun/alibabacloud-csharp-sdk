// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregatorsResponseBody : TeaModel {
        [NameInMap("AggregatorsResult")]
        [Validation(Required=false)]
        public ListAggregatorsResponseBodyAggregatorsResult AggregatorsResult { get; set; }
        public class ListAggregatorsResponseBodyAggregatorsResult : TeaModel {
            [NameInMap("Aggregators")]
            [Validation(Required=false)]
            public List<ListAggregatorsResponseBodyAggregatorsResultAggregators> Aggregators { get; set; }
            public class ListAggregatorsResponseBodyAggregatorsResultAggregators : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                [NameInMap("AggregatorAccountCount")]
                [Validation(Required=false)]
                public long? AggregatorAccountCount { get; set; }

                [NameInMap("AggregatorCreateTimestamp")]
                [Validation(Required=false)]
                public long? AggregatorCreateTimestamp { get; set; }

                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

                [NameInMap("AggregatorName")]
                [Validation(Required=false)]
                public string AggregatorName { get; set; }

                [NameInMap("AggregatorStatus")]
                [Validation(Required=false)]
                public int? AggregatorStatus { get; set; }

                [NameInMap("AggregatorType")]
                [Validation(Required=false)]
                public string AggregatorType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListAggregatorsResponseBodyAggregatorsResultAggregatorsTags> Tags { get; set; }
                public class ListAggregatorsResponseBodyAggregatorsResultAggregatorsTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

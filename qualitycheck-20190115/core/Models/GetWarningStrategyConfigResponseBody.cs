// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetWarningStrategyConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWarningStrategyConfigResponseBodyData Data { get; set; }
        public class GetWarningStrategyConfigResponseBodyData : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IntervalTime")]
            [Validation(Required=false)]
            public long? IntervalTime { get; set; }

            [NameInMap("Lambda")]
            [Validation(Required=false)]
            public string Lambda { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("MaxNumber")]
            [Validation(Required=false)]
            public long? MaxNumber { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("WarningStrategyList")]
            [Validation(Required=false)]
            public GetWarningStrategyConfigResponseBodyDataWarningStrategyList WarningStrategyList { get; set; }
            public class GetWarningStrategyConfigResponseBodyDataWarningStrategyList : TeaModel {
                [NameInMap("warningStrategyList")]
                [Validation(Required=false)]
                public List<GetWarningStrategyConfigResponseBodyDataWarningStrategyListWarningStrategyList> WarningStrategyList { get; set; }
                public class GetWarningStrategyConfigResponseBodyDataWarningStrategyListWarningStrategyList : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    [NameInMap("DurationExpression")]
                    [Validation(Required=false)]
                    public long? DurationExpression { get; set; }

                    [NameInMap("HitNumber")]
                    [Validation(Required=false)]
                    public long? HitNumber { get; set; }

                    [NameInMap("HitNumberExpression")]
                    [Validation(Required=false)]
                    public long? HitNumberExpression { get; set; }

                    [NameInMap("HitRuleList")]
                    [Validation(Required=false)]
                    public string HitRuleList { get; set; }

                    [NameInMap("HitType")]
                    [Validation(Required=false)]
                    public long? HitType { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Range")]
                    [Validation(Required=false)]
                    public GetWarningStrategyConfigResponseBodyDataWarningStrategyListWarningStrategyListRange Range { get; set; }
                    public class GetWarningStrategyConfigResponseBodyDataWarningStrategyListWarningStrategyListRange : TeaModel {
                        [NameInMap("RangeNum")]
                        [Validation(Required=false)]
                        public long? RangeNum { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public long? Type { get; set; }

                    }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

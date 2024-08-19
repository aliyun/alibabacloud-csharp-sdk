// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetCipStatsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCipStatsResponseBodyData Data { get; set; }
        public class GetCipStatsResponseBodyData : TeaModel {
            [NameInMap("LabelStatChart")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataLabelStatChart> LabelStatChart { get; set; }
            public class GetCipStatsResponseBodyDataLabelStatChart : TeaModel {
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("TreeChart")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartTreeChart> TreeChart { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartTreeChart : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("VoiceTreeChart")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartVoiceTreeChart> VoiceTreeChart { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartVoiceTreeChart : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("X")]
                [Validation(Required=false)]
                public List<string> X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public List<GetCipStatsResponseBodyDataLabelStatChartY> Y { get; set; }
                public class GetCipStatsResponseBodyDataLabelStatChartY : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<long?> Data { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("Uids")]
            [Validation(Required=false)]
            public List<string> Uids { get; set; }

            [NameInMap("X")]
            [Validation(Required=false)]
            public List<string> X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataY> Y { get; set; }
            public class GetCipStatsResponseBodyDataY : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Z")]
            [Validation(Required=false)]
            public List<GetCipStatsResponseBodyDataZ> Z { get; set; }
            public class GetCipStatsResponseBodyDataZ : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

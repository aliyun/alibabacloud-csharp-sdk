// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselinesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselinesResponseBodyData Data { get; set; }
        public class ListBaselinesResponseBodyData : TeaModel {
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<ListBaselinesResponseBodyDataBaselines> Baselines { get; set; }
            public class ListBaselinesResponseBodyDataBaselines : TeaModel {
                [NameInMap("AlertEnabled")]
                [Validation(Required=false)]
                public bool? AlertEnabled { get; set; }

                [NameInMap("AlertMarginThreshold")]
                [Validation(Required=false)]
                public int? AlertMarginThreshold { get; set; }

                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                [NameInMap("BaselineType")]
                [Validation(Required=false)]
                public string BaselineType { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("OverTimeSettings")]
                [Validation(Required=false)]
                public List<ListBaselinesResponseBodyDataBaselinesOverTimeSettings> OverTimeSettings { get; set; }
                public class ListBaselinesResponseBodyDataBaselinesOverTimeSettings : TeaModel {
                    [NameInMap("Cycle")]
                    [Validation(Required=false)]
                    public int? Cycle { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

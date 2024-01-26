// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Status20200117.Models
{
    public class ListEventInProgressResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEventInProgressResponseBodyData> Data { get; set; }
        public class ListEventInProgressResponseBodyData : TeaModel {
            [NameInMap("EventUpdates")]
            [Validation(Required=false)]
            public List<ListEventInProgressResponseBodyDataEventUpdates> EventUpdates { get; set; }
            public class ListEventInProgressResponseBodyDataEventUpdates : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public long? PublishTime { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Impacts")]
            [Validation(Required=false)]
            public List<ListEventInProgressResponseBodyDataImpacts> Impacts { get; set; }
            public class ListEventInProgressResponseBodyDataImpacts : TeaModel {
                [NameInMap("Product")]
                [Validation(Required=false)]
                public ListEventInProgressResponseBodyDataImpactsProduct Product { get; set; }
                public class ListEventInProgressResponseBodyDataImpactsProduct : TeaModel {
                    [NameInMap("ProductId")]
                    [Validation(Required=false)]
                    public string ProductId { get; set; }

                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                }

                [NameInMap("RecoveryTime")]
                [Validation(Required=false)]
                public long? RecoveryTime { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public ListEventInProgressResponseBodyDataImpactsRegion Region { get; set; }
                public class ListEventInProgressResponseBodyDataImpactsRegion : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("RegionName")]
                    [Validation(Required=false)]
                    public string RegionName { get; set; }

                }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeEndPointEventListResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeEndPointEventListResponseBodyNodes> Nodes { get; set; }
        public class DescribeEndPointEventListResponseBodyNodes : TeaModel {
            [NameInMap("EventDataItems")]
            [Validation(Required=false)]
            public List<DescribeEndPointEventListResponseBodyNodesEventDataItems> EventDataItems { get; set; }
            public class DescribeEndPointEventListResponseBodyNodesEventDataItems : TeaModel {
                [NameInMap("EventList")]
                [Validation(Required=false)]
                public List<DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList> EventList { get; set; }
                public class DescribeEndPointEventListResponseBodyNodesEventDataItemsEventList : TeaModel {
                    [NameInMap("Acs")]
                    [Validation(Required=false)]
                    public string Acs { get; set; }

                    [NameInMap("EventCode")]
                    [Validation(Required=false)]
                    public string EventCode { get; set; }

                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                    [NameInMap("EventType")]
                    [Validation(Required=false)]
                    public string EventType { get; set; }

                    [NameInMap("Os")]
                    [Validation(Required=false)]
                    public string Os { get; set; }

                    [NameInMap("Sdk")]
                    [Validation(Required=false)]
                    public string Sdk { get; set; }

                    [NameInMap("StreamName")]
                    [Validation(Required=false)]
                    public string StreamName { get; set; }

                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public string StreamType { get; set; }

                    [NameInMap("TrackCode")]
                    [Validation(Required=false)]
                    public string TrackCode { get; set; }

                    [NameInMap("TrackName")]
                    [Validation(Required=false)]
                    public string TrackName { get; set; }

                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                    [NameInMap("TsInMs")]
                    [Validation(Required=false)]
                    public string TsInMs { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("Ts")]
                [Validation(Required=false)]
                public long? Ts { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

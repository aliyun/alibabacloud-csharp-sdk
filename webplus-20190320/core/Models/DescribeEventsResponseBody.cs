// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyEvents Events { get; set; }
        public class DescribeEventsResponseBodyEvents : TeaModel {
            [NameInMap("Event")]
            [Validation(Required=false)]
            public List<DescribeEventsResponseBodyEventsEvent> Event { get; set; }
            public class DescribeEventsResponseBodyEventsEvent : TeaModel {
                public string PrimaryUserName { get; set; }
                public string ObjectType { get; set; }
                public string EnventName { get; set; }
                public long? EventTimestamp { get; set; }
                public string SecondUserName { get; set; }
                public string MsgCode { get; set; }
                public string ObjectName { get; set; }
                public string EventMessage { get; set; }
                public string EventId { get; set; }
                public DescribeEventsResponseBodyEventsEventObjectAttrs ObjectAttrs { get; set; }
                public class DescribeEventsResponseBodyEventsEventObjectAttrs : TeaModel {
                    [NameInMap("ObjectAttr")]
                    [Validation(Required=false)]
                    public List<DescribeEventsResponseBodyEventsEventObjectAttrsObjectAttr> ObjectAttr { get; set; }
                    public class DescribeEventsResponseBodyEventsEventObjectAttrsObjectAttr : TeaModel {
                        [NameInMap("AttributeName")]
                        [Validation(Required=false)]
                        public string AttributeName { get; set; }

                        [NameInMap("AttributeValue")]
                        [Validation(Required=false)]
                        public string AttributeValue { get; set; }

                    }

                }
                public string AppId { get; set; }
                public string EventLevel { get; set; }
                public string ObjectId { get; set; }
                public DescribeEventsResponseBodyEventsEventMsgParams MsgParams { get; set; }
                public class DescribeEventsResponseBodyEventsEventMsgParams : TeaModel {
                    [NameInMap("MsgParam")]
                    [Validation(Required=false)]
                    public List<string> MsgParam { get; set; }

                }
                public string PrimaryUserId { get; set; }
                public string EnvId { get; set; }
                public string TraceId { get; set; }
                public string SecondUserId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}

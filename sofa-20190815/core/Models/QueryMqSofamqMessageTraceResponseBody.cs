// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqMessageTraceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMqSofamqMessageTraceResponseBodyData Data { get; set; }
        public class QueryMqSofamqMessageTraceResponseBodyData : TeaModel {
            [NameInMap("TrackList")]
            [Validation(Required=false)]
            public List<QueryMqSofamqMessageTraceResponseBodyDataTrackList> TrackList { get; set; }
            public class QueryMqSofamqMessageTraceResponseBodyDataTrackList : TeaModel {
                public string ConsumerGroup { get; set; }
                public string InstanceId { get; set; }
                public string TrackType { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeCustVariableDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeCustVariableDetailResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeCustVariableDetailResponseBodyResultObject : TeaModel {
            [NameInMap("condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            [NameInMap("dataVersion")]
            [Validation(Required=false)]
            public long? DataVersion { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public string EventCodes { get; set; }

            [NameInMap("historyValueType")]
            [Validation(Required=false)]
            public string HistoryValueType { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            [NameInMap("outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("timeType")]
            [Validation(Required=false)]
            public string TimeType { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("twCount")]
            [Validation(Required=false)]
            public string TwCount { get; set; }

            [NameInMap("velocityFC")]
            [Validation(Required=false)]
            public string VelocityFC { get; set; }

            [NameInMap("velocityTW")]
            [Validation(Required=false)]
            public string VelocityTW { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSceneAllEventNameCodeListResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSceneAllEventNameCodeListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSceneAllEventNameCodeListResponseBodyResultObject : TeaModel {
            [NameInMap("children")]
            [Validation(Required=false)]
            public List<DescribeSceneAllEventNameCodeListResponseBodyResultObjectChildren> Children { get; set; }
            public class DescribeSceneAllEventNameCodeListResponseBodyResultObjectChildren : TeaModel {
                [NameInMap("createType")]
                [Validation(Required=false)]
                public string CreateType { get; set; }

                [NameInMap("eventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                [NameInMap("eventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                [NameInMap("eventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

            [NameInMap("createType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

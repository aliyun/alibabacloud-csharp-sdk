// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceMessageRoutingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEdgeInstanceMessageRoutingResponseBodyData Data { get; set; }
        public class GetEdgeInstanceMessageRoutingResponseBodyData : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RouteContext")]
            [Validation(Required=false)]
            public GetEdgeInstanceMessageRoutingResponseBodyDataRouteContext RouteContext { get; set; }
            public class GetEdgeInstanceMessageRoutingResponseBodyDataRouteContext : TeaModel {
                [NameInMap("Qos")]
                [Validation(Required=false)]
                public string Qos { get; set; }

                [NameInMap("SourceApplicationName")]
                [Validation(Required=false)]
                public string SourceApplicationName { get; set; }

                [NameInMap("SourceFcFunctionName")]
                [Validation(Required=false)]
                public string SourceFcFunctionName { get; set; }

                [NameInMap("SourceFcServiceName")]
                [Validation(Required=false)]
                public string SourceFcServiceName { get; set; }

                [NameInMap("TargetApplicationName")]
                [Validation(Required=false)]
                public string TargetApplicationName { get; set; }

                [NameInMap("TargetFcFunctionName")]
                [Validation(Required=false)]
                public string TargetFcFunctionName { get; set; }

                [NameInMap("TargetFcServiceName")]
                [Validation(Required=false)]
                public string TargetFcServiceName { get; set; }

            }

            [NameInMap("SourceData")]
            [Validation(Required=false)]
            public string SourceData { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("TargetData")]
            [Validation(Required=false)]
            public string TargetData { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("TopicFilter")]
            [Validation(Required=false)]
            public string TopicFilter { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

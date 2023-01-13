// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceMessageRoutingResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetEdgeInstanceMessageRoutingResponseData Data { get; set; }
        public class GetEdgeInstanceMessageRoutingResponseData : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=true)]
            public long? GmtCreateTimestamp { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }

            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=true)]
            public long? GmtModifiedTimestamp { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("SourceData")]
            [Validation(Required=true)]
            public string SourceData { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=true)]
            public string SourceType { get; set; }

            [NameInMap("TargetData")]
            [Validation(Required=true)]
            public string TargetData { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=true)]
            public string TargetType { get; set; }

            [NameInMap("TopicFilter")]
            [Validation(Required=true)]
            public string TopicFilter { get; set; }

            [NameInMap("RouteContext")]
            [Validation(Required=true)]
            public GetEdgeInstanceMessageRoutingResponseDataRouteContext RouteContext { get; set; }
            public class GetEdgeInstanceMessageRoutingResponseDataRouteContext : TeaModel {
                [NameInMap("Qos")]
                [Validation(Required=true)]
                public string Qos { get; set; }

                [NameInMap("SourceApplicationName")]
                [Validation(Required=true)]
                public string SourceApplicationName { get; set; }

                [NameInMap("SourceFcFunctionName")]
                [Validation(Required=true)]
                public string SourceFcFunctionName { get; set; }

                [NameInMap("SourceFcServiceName")]
                [Validation(Required=true)]
                public string SourceFcServiceName { get; set; }

                [NameInMap("TargetApplicationName")]
                [Validation(Required=true)]
                public string TargetApplicationName { get; set; }

                [NameInMap("TargetFcFunctionName")]
                [Validation(Required=true)]
                public string TargetFcFunctionName { get; set; }

                [NameInMap("TargetFcServiceName")]
                [Validation(Required=true)]
                public string TargetFcServiceName { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceMessageRoutingResponse : TeaModel {
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
        public QueryEdgeInstanceMessageRoutingResponseData Data { get; set; }
        public class QueryEdgeInstanceMessageRoutingResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("MessageRouteList")]
            [Validation(Required=true)]
            public QueryEdgeInstanceMessageRoutingResponseDataMessageRouteList MessageRouteList { get; set; }
            public class QueryEdgeInstanceMessageRoutingResponseDataMessageRouteList : TeaModel {
                [NameInMap("MessageRoute")]
                [Validation(Required=true)]
                public List<QueryEdgeInstanceMessageRoutingResponseDataMessageRouteListMessageRoute> MessageRoute { get; set; }
                public class QueryEdgeInstanceMessageRoutingResponseDataMessageRouteListMessageRoute : TeaModel {
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

                    [NameInMap("RouteId")]
                    [Validation(Required=true)]
                    public int? RouteId { get; set; }

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
                    public QueryEdgeInstanceMessageRoutingResponseDataMessageRouteListMessageRouteRouteContext RouteContext { get; set; }
                    public class QueryEdgeInstanceMessageRoutingResponseDataMessageRouteListMessageRouteRouteContext : TeaModel {
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

    }

}

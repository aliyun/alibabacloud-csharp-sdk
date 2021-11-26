// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListGreyTagRouteResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGreyTagRouteResponseBodyData Data { get; set; }
        public class ListGreyTagRouteResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGreyTagRouteResponseBodyDataResult> Result { get; set; }
            public class ListGreyTagRouteResponseBodyDataResult : TeaModel {
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public List<ListGreyTagRouteResponseBodyDataResultDubboRules> DubboRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultDubboRules : TeaModel {
                    public string Condition { get; set; }
                    public string Group { get; set; }
                    public List<ListGreyTagRouteResponseBodyDataResultDubboRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultDubboRulesItems : TeaModel {
                        public string Cond { get; set; }
                        public string Expr { get; set; }
                        public int? Index { get; set; }
                        public string Name { get; set; }
                        public string Operator { get; set; }
                        public string Type { get; set; }
                        public string Value { get; set; }
                    }
                    public string MethodName { get; set; }
                    public string ServiceName { get; set; }
                    public string Version { get; set; }
                }
                public long? GreyTagRouteId { get; set; }
                public string Name { get; set; }
                public List<ListGreyTagRouteResponseBodyDataResultScRules> ScRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultScRules : TeaModel {
                    public string Condition { get; set; }
                    public List<ListGreyTagRouteResponseBodyDataResultScRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultScRulesItems : TeaModel {
                        public string Cond { get; set; }
                        public string Expr { get; set; }
                        public int? Index { get; set; }
                        public string Name { get; set; }
                        public string Operator { get; set; }
                        public string Type { get; set; }
                        public string Value { get; set; }
                    }
                    public string Path { get; set; }
                }
                public long? UpdateTime { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

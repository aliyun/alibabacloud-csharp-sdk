// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeGreyTagRouteResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGreyTagRouteResponseBodyData Data { get; set; }
        public class DescribeGreyTagRouteResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DubboRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataDubboRules> DubboRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataDubboRules : TeaModel {
                public string Condition { get; set; }
                public string Group { get; set; }
                public List<DescribeGreyTagRouteResponseBodyDataDubboRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataDubboRulesItems : TeaModel {
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
            [NameInMap("GreyTagRouteId")]
            [Validation(Required=false)]
            public long? GreyTagRouteId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ScRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataScRules> ScRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataScRules : TeaModel {
                public string Condition { get; set; }
                public List<DescribeGreyTagRouteResponseBodyDataScRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataScRulesItems : TeaModel {
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
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
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

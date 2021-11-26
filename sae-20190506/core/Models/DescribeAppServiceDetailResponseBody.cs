// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeAppServiceDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAppServiceDetailResponseBodyData Data { get; set; }
        public class DescribeAppServiceDetailResponseBodyData : TeaModel {
            [NameInMap("DubboApplicationName")]
            [Validation(Required=false)]
            public string DubboApplicationName { get; set; }
            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> Metadata { get; set; }
            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<DescribeAppServiceDetailResponseBodyDataMethods> Methods { get; set; }
            public class DescribeAppServiceDetailResponseBodyDataMethods : TeaModel {
                public string MethodController { get; set; }
                public string Name { get; set; }
                public string NameDetail { get; set; }
                public List<DescribeAppServiceDetailResponseBodyDataMethodsParameterDefinitions> ParameterDefinitions { get; set; }
                public class DescribeAppServiceDetailResponseBodyDataMethodsParameterDefinitions : TeaModel {
                    public string Description { get; set; }
                    public string Name { get; set; }
                    public string Type { get; set; }
                }
                public List<string> ParameterDetails { get; set; }
                public List<string> ParameterTypes { get; set; }
                public List<string> Paths { get; set; }
                public List<string> RequestMethods { get; set; }
                public string ReturnDetails { get; set; }
                public string ReturnType { get; set; }
            }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }
            [NameInMap("SpringApplicationName")]
            [Validation(Required=false)]
            public string SpringApplicationName { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

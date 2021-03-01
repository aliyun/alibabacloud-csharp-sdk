// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceDetailResponseBodyData Data { get; set; }
        public class GetServiceDetailResponseBodyData : TeaModel {
            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }
            [NameInMap("DubboApplicationName")]
            [Validation(Required=false)]
            public string DubboApplicationName { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }
            [NameInMap("SpringApplicationName")]
            [Validation(Required=false)]
            public string SpringApplicationName { get; set; }
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataMethods> Methods { get; set; }
            public class GetServiceDetailResponseBodyDataMethods : TeaModel {
                public string ParameterDetails { get; set; }
                public string ParameterNames { get; set; }
                public string Paths { get; set; }
                public string ParameterTypes { get; set; }
                public string ReturnType { get; set; }
                public string NameDetail { get; set; }
                public string ParameterDefinitions { get; set; }
                public GetServiceDetailResponseBodyDataMethodsReturnDefinition ReturnDefinition { get; set; }
                public class GetServiceDetailResponseBodyDataMethodsReturnDefinition : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }
                public string RequestMethods { get; set; }
                public string ReturnDetails { get; set; }
                public string Name { get; set; }
                public string MethodController { get; set; }
            }
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

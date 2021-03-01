// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetServiceListResponseBodyData> Data { get; set; }
        public class GetServiceListResponseBodyData : TeaModel {
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }

            [NameInMap("DubboApplicationName")]
            [Validation(Required=false)]
            public string DubboApplicationName { get; set; }

            [NameInMap("SpringApplicationName")]
            [Validation(Required=false)]
            public string SpringApplicationName { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<GetServiceListResponseBodyDataMethods> Methods { get; set; }
            public class GetServiceListResponseBodyDataMethods : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                [NameInMap("ParameterNames")]
                [Validation(Required=false)]
                public string ParameterNames { get; set; }

                [NameInMap("NameDetail")]
                [Validation(Required=false)]
                public string NameDetail { get; set; }

                [NameInMap("ReturnDetails")]
                [Validation(Required=false)]
                public string ReturnDetails { get; set; }

                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public string ParameterTypes { get; set; }

                [NameInMap("ParameterDetails")]
                [Validation(Required=false)]
                public string ParameterDetails { get; set; }

                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public string RequestMethods { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public string Paths { get; set; }

                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public string ParameterDefinitions { get; set; }

            }

        }

    }

}

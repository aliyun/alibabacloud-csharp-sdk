// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetServiceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetServiceListResponseBodyData> Data { get; set; }
        public class GetServiceListResponseBodyData : TeaModel {
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
            public Dictionary<string, object> Metadata { get; set; }

            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<GetServiceListResponseBodyDataMethods> Methods { get; set; }
            public class GetServiceListResponseBodyDataMethods : TeaModel {
                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public List<string> ParameterTypes { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public List<string> RequestMethods { get; set; }

                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

            }

            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

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

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

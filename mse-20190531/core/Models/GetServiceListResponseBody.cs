// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetServiceListResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data entries returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetServiceListResponseBodyData> Data { get; set; }
        public class GetServiceListResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the Dubbo application.
            /// </summary>
            [NameInMap("DubboApplicationName")]
            [Validation(Required=false)]
            public string DubboApplicationName { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }

            /// <summary>
            /// The group.
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The metadata.
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// The methods.
            /// </summary>
            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<GetServiceListResponseBodyDataMethods> Methods { get; set; }
            public class GetServiceListResponseBodyDataMethods : TeaModel {
                /// <summary>
                /// The controller of the method.
                /// </summary>
                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                /// <summary>
                /// The name of the method.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The data types of the parameters.
                /// </summary>
                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public List<string> ParameterTypes { get; set; }

                /// <summary>
                /// The paths.
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// The methods.
                /// </summary>
                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public List<string> RequestMethods { get; set; }

                /// <summary>
                /// The type of the return value.
                /// </summary>
                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

            }

            /// <summary>
            /// The type of the service registry.
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The type of the service.
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// The name of the Spring application.
            /// </summary>
            [NameInMap("SpringApplicationName")]
            [Validation(Required=false)]
            public string SpringApplicationName { get; set; }

            /// <summary>
            /// The version information.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceDetailResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceDetailResponseBodyData Data { get; set; }
        public class GetServiceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the Dubbo application.
            /// </summary>
            [NameInMap("DubboApplicationName")]
            [Validation(Required=false)]
            public string DubboApplicationName { get; set; }

            /// <summary>
            /// The name of the Enterprise Distributed Application Service (EDAS) application.
            /// </summary>
            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }

            /// <summary>
            /// The group to which the service belongs.
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The metadata.
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// The methods.
            /// </summary>
            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataMethods> Methods { get; set; }
            public class GetServiceDetailResponseBodyDataMethods : TeaModel {
                /// <summary>
                /// The controllers.
                /// </summary>
                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                /// <summary>
                /// The name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The specific name.
                /// </summary>
                [NameInMap("NameDetail")]
                [Validation(Required=false)]
                public string NameDetail { get; set; }

                /// <summary>
                /// The definition of the parameter.
                /// </summary>
                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public string ParameterDefinitions { get; set; }

                /// <summary>
                /// The details of the parameters.
                /// </summary>
                [NameInMap("ParameterDetails")]
                [Validation(Required=false)]
                public string ParameterDetails { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterNames")]
                [Validation(Required=false)]
                public string ParameterNames { get; set; }

                /// <summary>
                /// The data type of the parameter.
                /// </summary>
                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public string ParameterTypes { get; set; }

                /// <summary>
                /// The method path.
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public string Paths { get; set; }

                /// <summary>
                /// The request method.
                /// </summary>
                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public string RequestMethods { get; set; }

                /// <summary>
                /// The definition of the value returned by the method.
                /// </summary>
                [NameInMap("ReturnDefinition")]
                [Validation(Required=false)]
                public GetServiceDetailResponseBodyDataMethodsReturnDefinition ReturnDefinition { get; set; }
                public class GetServiceDetailResponseBodyDataMethodsReturnDefinition : TeaModel {
                    /// <summary>
                    /// The ID of the return value.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The type.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The details of the response.
                /// </summary>
                [NameInMap("ReturnDetails")]
                [Validation(Required=false)]
                public string ReturnDetails { get; set; }

                /// <summary>
                /// The data format of the response.
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
            /// The version number.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The message returned for the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

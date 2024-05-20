// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeAppServiceDetailResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// - **2xx**: indicates that the call was successful.
        /// - **3xx**: indicates that the call was redirected.
        /// - **4xx**: indicates that the call failed.
        /// - **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAppServiceDetailResponseBodyData Data { get; set; }
        public class DescribeAppServiceDetailResponseBodyData : TeaModel {
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
            /// The group to which the service belongs. You can create a custom group.
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The metadata. Example: `{side: "provider", port: "18081", preserved: {register: {source: "SPRING_CLOUD"}},…}`.
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// The methods.
            /// </summary>
            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<DescribeAppServiceDetailResponseBodyDataMethods> Methods { get; set; }
            public class DescribeAppServiceDetailResponseBodyDataMethods : TeaModel {
                /// <summary>
                /// The class to which the method belongs.
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
                /// The details of the method.
                /// </summary>
                [NameInMap("NameDetail")]
                [Validation(Required=false)]
                public string NameDetail { get; set; }

                /// <summary>
                /// The definition of the parameter.
                /// </summary>
                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public List<DescribeAppServiceDetailResponseBodyDataMethodsParameterDefinitions> ParameterDefinitions { get; set; }
                public class DescribeAppServiceDetailResponseBodyDataMethodsParameterDefinitions : TeaModel {
                    /// <summary>
                    /// The description of the parameter.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the parameter.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the parameter.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The details of the parameters.
                /// </summary>
                [NameInMap("ParameterDetails")]
                [Validation(Required=false)]
                public List<string> ParameterDetails { get; set; }

                /// <summary>
                /// The types of the parameters.
                /// </summary>
                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public List<string> ParameterTypes { get; set; }

                /// <summary>
                /// The request paths. Format:
                /// 
                /// `/path`
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// The request methods. Valid values:
                /// 
                /// *   **GET**
                /// *   **ALL**
                /// </summary>
                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public List<string> RequestMethods { get; set; }

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
            /// The name of the service.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServicePorts")]
            [Validation(Required=false)]
            public List<long?> ServicePorts { get; set; }

            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public List<string> ServiceTags { get; set; }

            /// <summary>
            /// The type of the service. Valid values:
            /// 
            /// *   **dubbo**
            /// *   **springCloud**
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// The name of the Spring Cloud application.
            /// </summary>
            [NameInMap("SpringApplicationName")]
            [Validation(Required=false)]
            public string SpringApplicationName { get; set; }

            /// <summary>
            /// The version of the service. You can create a custom version.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The returned error code. Valid values:
        /// 
        /// - If the call is successful, the **ErrorCode** parameter is not returned.
        /// - If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned information.
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
        /// Indicates whether the meta data was obtained. Valid values:
        /// 
        /// *   **true**: The metadata was obtained.
        /// *   **false**: The metadata failed to be obtained.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. The ID is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

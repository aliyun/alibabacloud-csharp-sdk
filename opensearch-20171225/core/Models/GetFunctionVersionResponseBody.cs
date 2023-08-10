// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionVersionResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// The maximum duration for which a task can be executed.
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        /// <summary>
        /// The error message.
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
        /// The result body.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionVersionResponseBodyResult Result { get; set; }
        public class GetFunctionVersionResponseBodyResult : TeaModel {
            /// <summary>
            /// The name of the feature.
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// The type of the feature. Valid values:
            /// 
            /// *   PAAS
            /// *   SAAS
            /// </summary>
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// The type of the model.
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// The configuration information.
            /// </summary>
            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public GetFunctionVersionResponseBodyResultVersionConfig VersionConfig { get; set; }
            public class GetFunctionVersionResponseBodyResultVersionConfig : TeaModel {
                /// <summary>
                /// The parameters that are used to create the instance.
                /// </summary>
                [NameInMap("CreateParameters")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigCreateParameters> CreateParameters { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigCreateParameters : TeaModel {
                    /// <summary>
                    /// The name of the parameter.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Indicates whether the parameter is required.
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public string Required { get; set; }

                }

                /// <summary>
                /// The dependencies of the instance.
                /// </summary>
                [NameInMap("Depends")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigDepends> Depends { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigDepends : TeaModel {
                    /// <summary>
                    /// The condition.
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// The dependency.
                    /// </summary>
                    [NameInMap("Dependency")]
                    [Validation(Required=false)]
                    public string Dependency { get; set; }

                    /// <summary>
                    /// The description.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                }

                /// <summary>
                /// The parameters that are used during online use of the instance.
                /// </summary>
                [NameInMap("UsageParameters")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigUsageParameters> UsageParameters { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigUsageParameters : TeaModel {
                    /// <summary>
                    /// The name of the instance.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Indicates whether the parameter is required.
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public string Required { get; set; }

                }

            }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            /// <summary>
            /// The name of the version.
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// The status of the request.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

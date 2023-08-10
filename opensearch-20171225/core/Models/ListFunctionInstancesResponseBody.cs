// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionInstancesResponseBody : TeaModel {
        /// <summary>
        /// The error code. If no error occurs, the parameter is left empty.
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
        /// The time consumed for the request, in milliseconds.
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        /// <summary>
        /// The error message. If no error occurs, the parameter is left empty.
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
        /// The information about the instances.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListFunctionInstancesResponseBodyResult> Result { get; set; }
        public class ListFunctionInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// The information about the instance.
            /// </summary>
            [NameInMap("Belongs")]
            [Validation(Required=false)]
            public ListFunctionInstancesResponseBodyResultBelongs Belongs { get; set; }
            public class ListFunctionInstancesResponseBodyResultBelongs : TeaModel {
                /// <summary>
                /// The category.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The industry.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The abbreviation of the language that applies.
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }

            /// <summary>
            /// The parameters of the instance.
            /// </summary>
            [NameInMap("CreateParameters")]
            [Validation(Required=false)]
            public List<ListFunctionInstancesResponseBodyResultCreateParameters> CreateParameters { get; set; }
            public class ListFunctionInstancesResponseBodyResultCreateParameters : TeaModel {
                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The cron expression used to schedule training, in the format of (Minutes Hours DayofMonth Month DayofWeek). If the value is empty, it indicates that no periodic training is performed.
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The extended information, which is a JSON string. It includes model evaluation information and error information.
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// The name of the feature.
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// The type of the feature.
            /// </summary>
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The type of the model.
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// How the instance is created. Valid values:
            /// 
            /// *   user: The instance is created by user.
            /// *   builtin: The instance is created by system.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The state of the instance. Valid values:
            /// 
            /// 1.  unavailable: No model is available. Models must be trained before you can use them.
            /// 2.  available: Models can be used.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The parameters that are used.
            /// </summary>
            [NameInMap("UsageParameters")]
            [Validation(Required=false)]
            public List<ListFunctionInstancesResponseBodyResultUsageParameters> UsageParameters { get; set; }
            public class ListFunctionInstancesResponseBodyResultUsageParameters : TeaModel {
                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

        }

        /// <summary>
        /// The status of the request.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

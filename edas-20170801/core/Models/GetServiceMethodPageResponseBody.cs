// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceMethodPageResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceMethodPageResponseBodyData Data { get; set; }
        public class GetServiceMethodPageResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The data about the method.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetServiceMethodPageResponseBodyDataResult> Result { get; set; }
            public class GetServiceMethodPageResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The method.
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
                /// The return value.
                /// </summary>
                [NameInMap("ReturnDefinition")]
                [Validation(Required=false)]
                public GetServiceMethodPageResponseBodyDataResultReturnDefinition ReturnDefinition { get; set; }
                public class GetServiceMethodPageResponseBodyDataResultReturnDefinition : TeaModel {
                    /// <summary>
                    /// The ID of the return value.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The data format of the response.
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
            /// The total number of entries.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The additional information that is returned.
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
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

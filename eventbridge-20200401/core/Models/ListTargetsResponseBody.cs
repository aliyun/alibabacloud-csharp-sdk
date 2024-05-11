// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListTargetsResponseBody : TeaModel {
        /// <summary>
        /// The returned response code. Valid values:
        /// 
        /// *   Success: The request is successful.
        /// *   Other codes: The request failed. For a list of error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTargetsResponseBodyData Data { get; set; }
        public class ListTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// If excess return values exist, this parameter is returned.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The event targets.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<ListTargetsResponseBodyDataTargets> Targets { get; set; }
            public class ListTargetsResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// The endpoint of the event target.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("ErrorsTolerance")]
                [Validation(Required=false)]
                public string ErrorsTolerance { get; set; }

                /// <summary>
                /// The name of the event bus.
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// The ID of the event target.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The parameters that are configured for the event target.
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<ListTargetsResponseBodyDataTargetsParamList> ParamList { get; set; }
                public class ListTargetsResponseBodyDataTargetsParamList : TeaModel {
                    /// <summary>
                    /// The format that is used by the event target parameter.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The resource parameter of the event target.
                    /// </summary>
                    [NameInMap("ResourceKey")]
                    [Validation(Required=false)]
                    public string ResourceKey { get; set; }

                    /// <summary>
                    /// The template that is used by the event target parameter.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value of the event target parameter.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The name of the event rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The type of the event target. For more information, see [Event target parameters](https://help.aliyun.com/document_detail/183698.html).
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The total number of entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The returned error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

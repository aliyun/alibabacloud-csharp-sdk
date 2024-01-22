// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeGreyTagRouteResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// - **2xx**: The call was successful.
        /// - **3xx**: The call was redirected.
        /// - **4xx**: The call failed.
        /// - **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the canary release rule.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGreyTagRouteResponseBodyData Data { get; set; }
        public class DescribeGreyTagRouteResponseBodyData : TeaModel {
            [NameInMap("AlbRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataAlbRules> AlbRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataAlbRules : TeaModel {
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                [NameInMap("ingressId")]
                [Validation(Required=false)]
                public string IngressId { get; set; }

                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataAlbRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataAlbRulesItems : TeaModel {
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

            }

            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The timestamp when the canary release rule was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the canary release rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The canary release rule of the Dubbo service.
            /// </summary>
            [NameInMap("DubboRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataDubboRules> DubboRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataDubboRules : TeaModel {
                /// <summary>
                /// The relationship between the conditions in the canary release rule. Valid values:
                /// 
                /// - **AND**: The conditions are in the logical AND relation. All conditions must be met at the same time.
                /// - **OR**: The conditions are in the logical OR relation. At least one of the conditions must be met.
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// The group of the Dubbo service that corresponds to the canary release rule.
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// The conditions.
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataDubboRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataDubboRulesItems : TeaModel {
                    /// <summary>
                    /// The comparison operator. Valid values: **>**, **<**, **>=**, **<=**, **==**, and **! =**.
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// The expression that is used to obtain the value of the parameter. Valid values:
                    /// 
                    /// - **Empty**: obtains the value of the parameter.
                    /// - **.name**: obtains the name property of the parameter. This expression works the same way as args0.getName().
                    /// - **.isEnabled()**: obtains the enabled property of the parameter. This expression works the same way as args0.isEnabled().
                    /// - **[0]**: indicates that the value of the parameter is an array and obtains the first value of the array. This expression works the same way as args0[0]. This expression does not start with a period (.).
                    /// - **.get(0)**: indicates that the value of the parameter is a list and obtains the first value of the list. This expression works the same way as args0.get(0).
                    /// - **.get("key")**: indicates that the value of the parameter is a map and obtains the value of the key in the map. This expression works the same way as args0.get("key").
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// The index of the parameter. The value 0 indicates the first parameter.
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// This parameter is not returned for Dubbo services.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The operator. Valid values:
                    /// 
                    /// - **rawvalue**: direct comparison.
                    /// - **list**: whitelist.
                    /// - **mod**: mods 100.
                    /// - **deterministic_proportional_steaming_division**: percentage.
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// This parameter is not returned for Dubbo services.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The value of the parameter. This value is compared with the value that is obtained based on the **expr** and **index** parameters.
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The method name of the Dubbo service.
                /// </summary>
                [NameInMap("methodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// The name of the Dubbo service.
                /// </summary>
                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// The version of the Dubbo service.
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The ID of the canary release rule. The ID is globally unique.
            /// </summary>
            [NameInMap("GreyTagRouteId")]
            [Validation(Required=false)]
            public long? GreyTagRouteId { get; set; }

            /// <summary>
            /// The name of the canary release rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The canary release rule of the Spring Cloud application.
            /// </summary>
            [NameInMap("ScRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataScRules> ScRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataScRules : TeaModel {
                /// <summary>
                /// The relationship between the conditions in the canary release rule. Valid values:
                /// 
                /// *   **AND**: The conditions are in the logical AND relation. All conditions must be met at the same time.
                /// *   **OR**: The conditions are in the logical OR relation. At least one of the conditions must be met.
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// The conditions.
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataScRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataScRulesItems : TeaModel {
                    /// <summary>
                    /// The comparison operator. Valid values: **>**, **<**, **>=**, **<=**, **==**, and **! =**.
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// This parameter is not returned for Spring Cloud applications.
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// This parameter is not returned for Spring Cloud applications.
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// The name of the parameter.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The operator. Valid values:
                    /// 
                    /// *   **rawvalue**: direct comparison.
                    /// *   **list**: whitelist.
                    /// *   **mod**: mods 100.
                    /// *   **deterministic_proportional_steaming_division**: percentage.
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// The type of the comparison. Valid values:
                    /// 
                    /// *   **param**: parameter
                    /// *   **cookie**: cookie
                    /// *   **header**: header
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The value of the parameter. This value is compared with the value that is obtained based on the **type** and **name** parameters.
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The path of the canary release rule of the Spring Cloud application.
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// The timestamp when the canary release rule was updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

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
        /// Indicates whether the information of the change order was queried. Valid values:
        /// 
        /// - **true**: The information was queried.
        /// - **false**: The information failed to be queried.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

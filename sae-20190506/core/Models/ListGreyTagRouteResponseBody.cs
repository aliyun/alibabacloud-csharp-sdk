// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListGreyTagRouteResponseBody : TeaModel {
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
        public ListGreyTagRouteResponseBodyData Data { get; set; }
        public class ListGreyTagRouteResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned on each page. Valid value: **1**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The returned result.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGreyTagRouteResponseBodyDataResult> Result { get; set; }
            public class ListGreyTagRouteResponseBodyDataResult : TeaModel {
                [NameInMap("AlbRules")]
                [Validation(Required=false)]
                public List<ListGreyTagRouteResponseBodyDataResultAlbRules> AlbRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultAlbRules : TeaModel {
                    [NameInMap("condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    [NameInMap("ingressId")]
                    [Validation(Required=false)]
                    public string IngressId { get; set; }

                    [NameInMap("items")]
                    [Validation(Required=false)]
                    public List<ListGreyTagRouteResponseBodyDataResultAlbRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultAlbRulesItems : TeaModel {
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

                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

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
                public List<ListGreyTagRouteResponseBodyDataResultDubboRules> DubboRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultDubboRules : TeaModel {
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
                    public List<ListGreyTagRouteResponseBodyDataResultDubboRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultDubboRulesItems : TeaModel {
                        /// <summary>
                        /// The comparison operator. Valid values: **>**, **<**, **>=**, **<=**, **==**, and **! =**.
                        /// </summary>
                        [NameInMap("cond")]
                        [Validation(Required=false)]
                        public string Cond { get; set; }

                        /// <summary>
                        /// The expression that is used to obtain the value of the parameter. The syntax of the expression must follow the standard of the SpEL. Valid values:
                        /// 
                        /// - **Empty**: obtains the value of the parameter.
                        /// - **.name**: obtains the name property of the parameter. This expression works the same way as args0.getName().
                        /// - **.isEnabled()**: obtains the enabled property of the parameter. This expression works the same way as args0.isEnabled().
                        /// - **[0]**: indicates that the value of the parameter is an array and obtains the first value of the array. This expression works the same way as args0[0]. This expression does not start with a period (.).
                        /// - **.get(0)**: indicates that the value of the parameter is a list and obtains the first value of the list. This expression works the same way as args0.get(0).
                        /// - **.get("key")**: indicates that the value of the parameter is a map and obtains the value of the key in the map. This expression works the same way as args0.get("key").  >  For more information about the expressions that are used to obtain parameter values, see  [Spring Expression Language (SpEL)](https://docs.spring.io/spring-integration/docs/current/reference/html/spel.html).
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
                /// The ID of the canary release rule.
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
                public List<ListGreyTagRouteResponseBodyDataResultScRules> ScRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultScRules : TeaModel {
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
                    public List<ListGreyTagRouteResponseBodyDataResultScRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultScRulesItems : TeaModel {
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
            /// The total number of canary release rules. Valid value: **1**.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

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
        /// The returned information. Valid values:
        /// 
        /// *   success: If the call is successful, **success** is returned.
        /// *   An error code: If the call fails, an error code is returned.
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

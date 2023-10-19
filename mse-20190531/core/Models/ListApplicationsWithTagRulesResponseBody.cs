// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListApplicationsWithTagRulesResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsWithTagRulesResponseBodyData Data { get; set; }
        public class ListApplicationsWithTagRulesResponseBodyData : TeaModel {
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
            /// The returned data.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListApplicationsWithTagRulesResponseBodyDataResult> Result { get; set; }
            public class ListApplicationsWithTagRulesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The application ID.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The application name.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The MSE namespace to which the application belongs.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The queried rules.
                /// </summary>
                [NameInMap("RouteRules")]
                [Validation(Required=false)]
                public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRules> RouteRules { get; set; }
                public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRules : TeaModel {
                    /// <summary>
                    /// Indicates whether the alert rule is enabled. Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// The rule ID.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The number of instances.
                    /// </summary>
                    [NameInMap("InstanceNum")]
                    [Validation(Required=false)]
                    public int? InstanceNum { get; set; }

                    /// <summary>
                    /// The rule name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The rate.
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    /// <summary>
                    /// The details of the routing rule.
                    /// </summary>
                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRules Rules { get; set; }
                    public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRules : TeaModel {
                        [NameInMap("dubbo")]
                        [Validation(Required=false)]
                        public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubbo> Dubbo { get; set; }
                        public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubbo : TeaModel {
                            [NameInMap("appId")]
                            [Validation(Required=false)]
                            public string AppId { get; set; }

                            [NameInMap("argumentItems")]
                            [Validation(Required=false)]
                            public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubboArgumentItems> ArgumentItems { get; set; }
                            public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubboArgumentItems : TeaModel {
                                [NameInMap("cond")]
                                [Validation(Required=false)]
                                public string Cond { get; set; }

                                [NameInMap("datum")]
                                [Validation(Required=false)]
                                public string Datum { get; set; }

                                [NameInMap("divisor")]
                                [Validation(Required=false)]
                                public int? Divisor { get; set; }

                                [NameInMap("expr")]
                                [Validation(Required=false)]
                                public string Expr { get; set; }

                                [NameInMap("index")]
                                [Validation(Required=false)]
                                public int? Index { get; set; }

                                [NameInMap("nameList")]
                                [Validation(Required=false)]
                                public List<string> NameList { get; set; }

                                [NameInMap("operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                [NameInMap("rate")]
                                [Validation(Required=false)]
                                public int? Rate { get; set; }

                                [NameInMap("remainder")]
                                [Validation(Required=false)]
                                public int? Remainder { get; set; }

                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            [NameInMap("condition")]
                            [Validation(Required=false)]
                            public string Condition { get; set; }

                            [NameInMap("group")]
                            [Validation(Required=false)]
                            public string Group { get; set; }

                            [NameInMap("methodName")]
                            [Validation(Required=false)]
                            public string MethodName { get; set; }

                            [NameInMap("paramTypes")]
                            [Validation(Required=false)]
                            public List<string> ParamTypes { get; set; }

                            [NameInMap("serviceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                            [NameInMap("tags")]
                            [Validation(Required=false)]
                            public List<string> Tags { get; set; }

                            [NameInMap("triggerPolicy")]
                            [Validation(Required=false)]
                            public string TriggerPolicy { get; set; }

                            [NameInMap("version")]
                            [Validation(Required=false)]
                            public string Version { get; set; }

                        }

                        [NameInMap("springcloud")]
                        [Validation(Required=false)]
                        public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloud> Springcloud { get; set; }
                        public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloud : TeaModel {
                            [NameInMap("appId")]
                            [Validation(Required=false)]
                            public string AppId { get; set; }

                            [NameInMap("condition")]
                            [Validation(Required=false)]
                            public string Condition { get; set; }

                            [NameInMap("enable")]
                            [Validation(Required=false)]
                            public bool? Enable { get; set; }

                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            [NameInMap("paths")]
                            [Validation(Required=false)]
                            public List<string> Paths { get; set; }

                            [NameInMap("priority")]
                            [Validation(Required=false)]
                            public int? Priority { get; set; }

                            [NameInMap("restItems")]
                            [Validation(Required=false)]
                            public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloudRestItems> RestItems { get; set; }
                            public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloudRestItems : TeaModel {
                                [NameInMap("cond")]
                                [Validation(Required=false)]
                                public string Cond { get; set; }

                                [NameInMap("datum")]
                                [Validation(Required=false)]
                                public string Datum { get; set; }

                                [NameInMap("divisor")]
                                [Validation(Required=false)]
                                public int? Divisor { get; set; }

                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("nameList")]
                                [Validation(Required=false)]
                                public List<string> NameList { get; set; }

                                [NameInMap("operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                [NameInMap("rate")]
                                [Validation(Required=false)]
                                public int? Rate { get; set; }

                                [NameInMap("remainder")]
                                [Validation(Required=false)]
                                public int? Remainder { get; set; }

                                [NameInMap("type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            [NameInMap("tags")]
                            [Validation(Required=false)]
                            public List<string> Tags { get; set; }

                            [NameInMap("triggerPolicy")]
                            [Validation(Required=false)]
                            public string TriggerPolicy { get; set; }

                        }

                    }

                    /// <summary>
                    /// The status.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The tag.
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                /// <summary>
                /// The route state. Valid values:
                /// 
                /// *   0: disabled
                /// *   1: enabled
                /// </summary>
                [NameInMap("RouteStatus")]
                [Validation(Required=false)]
                public long? RouteStatus { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   If the request is successful, a success message is returned.
        /// *   If the request fails, an error message is returned.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

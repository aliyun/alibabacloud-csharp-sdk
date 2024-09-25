// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListApplicationsWithTagRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsWithTagRulesResponseBodyData Data { get; set; }
        public class ListApplicationsWithTagRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListApplicationsWithTagRulesResponseBodyDataResult> Result { get; set; }
            public class ListApplicationsWithTagRulesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>daqijp6c31@xxx</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service-lottery-core</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The MSE namespace to which the application belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The queried rules.</para>
                /// </summary>
                [NameInMap("RouteRules")]
                [Validation(Required=false)]
                public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRules> RouteRules { get; set; }
                public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRules : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the alert rule is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c></description></item>
                    /// <item><description><c>false</c></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>653</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The number of instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("InstanceNum")]
                    [Validation(Required=false)]
                    public int? InstanceNum { get; set; }

                    /// <summary>
                    /// <para>The rule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dubbo</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    /// <summary>
                    /// <para>The details of the routing rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///       &quot;dubbo&quot;: [{
                    ///     &quot;serviceName&quot;: &quot;com.taobao.hsf.common.DemoService&quot;,
                    ///     &quot;group&quot;: &quot;&quot;,
                    ///     &quot;version&quot;: &quot;&quot;,
                    ///     &quot;methodName&quot;: &quot;sayHello&quot;,
                    ///     &quot;condition&quot;: &quot;AND&quot;,
                    ///     &quot;argumentItems&quot;: [{
                    ///         &quot;index&quot;: 0,
                    ///         &quot;expr&quot;: &quot;&quot;,
                    ///         &quot;operator&quot;: &quot;rawvalue&quot;,
                    ///         &quot;value&quot;: &quot;jim&quot;,
                    ///         &quot;cond&quot;: &quot;==&quot;
                    ///     }]
                    ///       }]
                    ///   }</para>
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
                    /// <para>The status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gray</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                /// <summary>
                /// <para>The route state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: disabled</description></item>
                /// <item><description>1: enabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteStatus")]
                [Validation(Required=false)]
                public long? RouteStatus { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, a success message is returned.</description></item>
        /// <item><description>If the request fails, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7466566F-F30F-4A29-965D-3E0AF21D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

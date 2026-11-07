// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListApplicationsWithTagRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsWithTagRulesResponseBodyData Data { get; set; }
        public class ListApplicationsWithTagRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The data structure.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListApplicationsWithTagRulesResponseBodyDataResult> Result { get; set; }
            public class ListApplicationsWithTagRulesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
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
                /// <para>The list of rules.</para>
                /// </summary>
                [NameInMap("RouteRules")]
                [Validation(Required=false)]
                public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRules> RouteRules { get; set; }
                public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRules : TeaModel {
                    /// <summary>
                    /// <para>The enabling status of the alert rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>true</c>: Enabled.</description></item>
                    /// <item><description><c>false</c>: Disabled.</description></item>
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
                    /// <para>The proportion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    /// <summary>
                    /// <para>The applicable routes of the rule.</para>
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
                        /// <summary>
                        /// <para>The Dubbo rule.</para>
                        /// </summary>
                        [NameInMap("dubbo")]
                        [Validation(Required=false)]
                        public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubbo> Dubbo { get; set; }
                        public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubbo : TeaModel {
                            /// <summary>
                            /// <para>The ID of the application.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><em><b>@</b></em></para>
                            /// </summary>
                            [NameInMap("appId")]
                            [Validation(Required=false)]
                            public string AppId { get; set; }

                            /// <summary>
                            /// <para>The list of parameter arguments.</para>
                            /// </summary>
                            [NameInMap("argumentItems")]
                            [Validation(Required=false)]
                            public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubboArgumentItems> ArgumentItems { get; set; }
                            public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesDubboArgumentItems : TeaModel {
                                /// <summary>
                                /// <para>The comparison operator. Valid values: &gt;=, &lt;=, &gt;, &lt;, and ==.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>==</para>
                                /// </summary>
                                [NameInMap("cond")]
                                [Validation(Required=false)]
                                public string Cond { get; set; }

                                /// <summary>
                                /// <para>The value to be compared for operators such as rawvalue.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30</para>
                                /// </summary>
                                [NameInMap("datum")]
                                [Validation(Required=false)]
                                public string Datum { get; set; }

                                /// <summary>
                                /// <para>The field required for the mod operator, which is the divisor.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30</para>
                                /// </summary>
                                [NameInMap("divisor")]
                                [Validation(Required=false)]
                                public int? Divisor { get; set; }

                                /// <summary>
                                /// <para>The expression. For more information, see the descriptions of other fields.</para>
                                /// </summary>
                                [NameInMap("expr")]
                                [Validation(Required=false)]
                                public string Expr { get; set; }

                                /// <summary>
                                /// <para>The parameter position, starting from 0.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("index")]
                                [Validation(Required=false)]
                                public int? Index { get; set; }

                                /// <summary>
                                /// <para>The list of names.</para>
                                /// </summary>
                                [NameInMap("nameList")]
                                [Validation(Required=false)]
                                public List<string> NameList { get; set; }

                                /// <summary>
                                /// <para>The operator. A value of rawvalue indicates direct comparison, mode indicates modulo operation, and list indicates a whitelist.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>rawvalue</para>
                                /// </summary>
                                [NameInMap("operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>The proportion rule, where 20% of traffic is routed to the node corresponding to this tag.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("rate")]
                                [Validation(Required=false)]
                                public int? Rate { get; set; }

                                /// <summary>
                                /// <para>The field required for the percentage operation, which is the percentage value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30</para>
                                /// </summary>
                                [NameInMap("remainder")]
                                [Validation(Required=false)]
                                public int? Remainder { get; set; }

                                /// <summary>
                                /// <para>The value used for comparison. The value obtained from the expression is compared with this value. If the operator is a list whitelist, separate multiple values with commas (,), such as 1,2,3.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1,2,3</para>
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The logical relationship among the following items. Valid values: AND and OR.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AND</para>
                            /// </summary>
                            [NameInMap("condition")]
                            [Validation(Required=false)]
                            public string Condition { get; set; }

                            /// <summary>
                            /// <para>The Dubbo service group.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>default</para>
                            /// </summary>
                            [NameInMap("group")]
                            [Validation(Required=false)]
                            public string Group { get; set; }

                            /// <summary>
                            /// <para>The Dubbo service method name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>hello</para>
                            /// </summary>
                            [NameInMap("methodName")]
                            [Validation(Required=false)]
                            public string MethodName { get; set; }

                            /// <summary>
                            /// <para>The list of parameter types.</para>
                            /// </summary>
                            [NameInMap("paramTypes")]
                            [Validation(Required=false)]
                            public List<string> ParamTypes { get; set; }

                            /// <summary>
                            /// <para>The service name (interface).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>HelloService</para>
                            /// </summary>
                            [NameInMap("serviceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                            /// <summary>
                            /// <para>The list of tags.</para>
                            /// </summary>
                            [NameInMap("tags")]
                            [Validation(Required=false)]
                            public List<string> Tags { get; set; }

                            /// <summary>
                            /// <para>The policy type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONTENT</para>
                            /// </summary>
                            [NameInMap("triggerPolicy")]
                            [Validation(Required=false)]
                            public string TriggerPolicy { get; set; }

                            /// <summary>
                            /// <para>The Dubbo service version.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.0.0</para>
                            /// </summary>
                            [NameInMap("version")]
                            [Validation(Required=false)]
                            public string Version { get; set; }

                        }

                        /// <summary>
                        /// <para>The Spring Cloud rule.</para>
                        /// </summary>
                        [NameInMap("springcloud")]
                        [Validation(Required=false)]
                        public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloud> Springcloud { get; set; }
                        public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloud : TeaModel {
                            /// <summary>
                            /// <para>The ID of the application.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><em><b>@</b></em></para>
                            /// </summary>
                            [NameInMap("appId")]
                            [Validation(Required=false)]
                            public string AppId { get; set; }

                            /// <summary>
                            /// <para>The logical relationship among the following items. Valid values: AND and OR.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AND</para>
                            /// </summary>
                            [NameInMap("condition")]
                            [Validation(Required=false)]
                            public string Condition { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the feature is enabled.</para>
                            /// </summary>
                            [NameInMap("enable")]
                            [Validation(Required=false)]
                            public bool? Enable { get; set; }

                            /// <summary>
                            /// <para>The path.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/hello</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// <para>The list of paths.</para>
                            /// </summary>
                            [NameInMap("paths")]
                            [Validation(Required=false)]
                            public List<string> Paths { get; set; }

                            /// <summary>
                            /// <para>The priority.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("priority")]
                            [Validation(Required=false)]
                            public int? Priority { get; set; }

                            /// <summary>
                            /// <para>The list of matching conditions for REST requests.</para>
                            /// </summary>
                            [NameInMap("restItems")]
                            [Validation(Required=false)]
                            public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloudRestItems> RestItems { get; set; }
                            public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRulesRulesSpringcloudRestItems : TeaModel {
                                /// <summary>
                                /// <para>The comparison operator. Valid values: &gt;=, &lt;=, &gt;, &lt;, and ==.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>==</para>
                                /// </summary>
                                [NameInMap("cond")]
                                [Validation(Required=false)]
                                public string Cond { get; set; }

                                /// <summary>
                                /// <para>The value to be compared for operators such as rawvalue.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("datum")]
                                [Validation(Required=false)]
                                public string Datum { get; set; }

                                /// <summary>
                                /// <para>The field required for the mod operator, which is the divisor.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30</para>
                                /// </summary>
                                [NameInMap("divisor")]
                                [Validation(Required=false)]
                                public int? Divisor { get; set; }

                                /// <summary>
                                /// <para>The name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>key</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>The field required for the list operator.</para>
                                /// </summary>
                                [NameInMap("nameList")]
                                [Validation(Required=false)]
                                public List<string> NameList { get; set; }

                                /// <summary>
                                /// <para>The operator. A value of rawvalue indicates direct comparison, mode indicates modulo operation, and list indicates a whitelist.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>rawvalue</para>
                                /// </summary>
                                [NameInMap("operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>The proportion rule, where 20% of traffic is routed to the node corresponding to this tag.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("rate")]
                                [Validation(Required=false)]
                                public int? Rate { get; set; }

                                /// <summary>
                                /// <para>The field required for the percentage operation, which is the percentage value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30</para>
                                /// </summary>
                                [NameInMap("remainder")]
                                [Validation(Required=false)]
                                public int? Remainder { get; set; }

                                /// <summary>
                                /// <para>The type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>test</para>
                                /// </summary>
                                [NameInMap("type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                /// <summary>
                                /// <para>The value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>test</para>
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The list of tags.</para>
                            /// </summary>
                            [NameInMap("tags")]
                            [Validation(Required=false)]
                            public List<string> Tags { get; set; }

                            /// <summary>
                            /// <para>The policy type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONTENT</para>
                            /// </summary>
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
                /// <para>The routing status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Disabled.</para>
                /// </description></item>
                /// <item><description><para>1: Enabled.</para>
                /// </description></item>
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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
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
        /// <item><description>If the request fails, the cause of the failure is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7466566F-F30F-4A29-965D-3E0AF21D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
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

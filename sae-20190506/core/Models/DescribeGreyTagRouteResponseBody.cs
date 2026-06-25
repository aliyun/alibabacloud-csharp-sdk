// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeGreyTagRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the API call or a POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client-side error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server-side error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the canary rule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGreyTagRouteResponseBodyData Data { get; set; }
        public class DescribeGreyTagRouteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The canary rules for the Application Load Balancer (ALB) instance.</para>
            /// </summary>
            [NameInMap("AlbRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataAlbRules> AlbRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataAlbRules : TeaModel {
                /// <summary>
                /// <para>The relationship between the conditions in the canary rule. Only <b>AND</b> is supported, which indicates that all conditions must be met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The ID of the Ingress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("ingressId")]
                [Validation(Required=false)]
                public string IngressId { get; set; }

                /// <summary>
                /// <para>The list of conditions.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataAlbRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataAlbRulesItems : TeaModel {
                    /// <summary>
                    /// <para>Currently supports ==.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>Not required for ALB applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// <para>Not required for ALB applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>The name of the element to match, such as a header or cookie name. This parameter is not used if type is set to sourceIp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The matching operator. Only <b>rawvalue</b> is supported, which indicates a direct comparison.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The type of request element to match against. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>sourceIp</b>: The source IP address.</para>
                    /// </description></item>
                    /// <item><description><para><b>cookie</b>: A cookie.</para>
                    /// </description></item>
                    /// <item><description><para><b>header</b>: A request header.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cookie</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value to match. This value is compared with the actual value of the element specified by <b>type</b> and <b>name</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The routing service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

            }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3faaf993-7aed-4bcd-b189-625e6a5a****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The creation timestamp of the rule, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1619007592013</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the canary rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The canary rules for the Dubbo service.</para>
            /// </summary>
            [NameInMap("DubboRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataDubboRules> DubboRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataDubboRules : TeaModel {
                /// <summary>
                /// <para>The relationship between the conditions in the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>AND</b>: All conditions must be met.</para>
                /// </description></item>
                /// <item><description><para><b>OR</b>: At least one condition must be met.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OR</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The service group to which the canary rule applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DUBBO</para>
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The list of conditions.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataDubboRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataDubboRulesItems : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator. Valid values are <b>&gt;</b>, <b>&lt;**, **&gt;=</b>, <b>&lt;=</b>, <b>==</b>, and <b>!=</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The expression that is used to obtain the parameter value. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Leave empty</b>: If left empty, the value of the parameter itself is used.</para>
                    /// </description></item>
                    /// <item><description><para><b>.name</b>: Obtains the value of the <c>name</c> attribute of the parameter. This is equivalent to <c>args0.getName()</c>.</para>
                    /// </description></item>
                    /// <item><description><para><b>.isEnabled()</b>: Obtains the value of the <c>enabled</c> attribute of the parameter. This is equivalent to <c>args0.isEnabled()</c>.</para>
                    /// </description></item>
                    /// <item><description><para><b>[0]</b>: The parameter must be an array. This expression obtains the first value of the array, which is equivalent to <c>args0[0]</c>. Note that the expression does not start with a period (.).</para>
                    /// </description></item>
                    /// <item><description><para><b>.get(0)</b>: The parameter must be a list. This expression obtains the first value of the list, which is equivalent to <c>args0.get(0)</c>.</para>
                    /// </description></item>
                    /// <item><description><para><b>.get(&quot;key&quot;)</b>: The parameter must be a map. This expression obtains the value that corresponds to a key. This is equivalent to <c>args0.get(&quot;key&quot;)</c>.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>.name</para>
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// <para>The parameter index. <c>0</c> indicates the first parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>Not used in Dubbo services.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The matching operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>rawvalue</b>: Performs a direct comparison.</para>
                    /// </description></item>
                    /// <item><description><para><b>list</b>: Matches against an allowlist of values.</para>
                    /// </description></item>
                    /// <item><description><para><b>mod</b>: Calculates the remainder of a division by 100.</para>
                    /// </description></item>
                    /// <item><description><para><b>deterministic_proportional_steaming_division</b>: Performs a percentage-based match.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>Not used in Dubbo services.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value to match. This value is compared with the actual value retrieved by using the specified <b>expr</b> and <b>index</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The method name of the Dubbo service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo</para>
                /// </summary>
                [NameInMap("methodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// <para>The Dubbo service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.edas.boot.EchoService</para>
                /// </summary>
                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

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
            /// <para>The globally unique ID of the canary rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("GreyTagRouteId")]
            [Validation(Required=false)]
            public long? GreyTagRouteId { get; set; }

            /// <summary>
            /// <para>The name of the canary rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The canary rules for the Spring Cloud application.</para>
            /// </summary>
            [NameInMap("ScRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataScRules> ScRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataScRules : TeaModel {
                /// <summary>
                /// <para>The relationship between the conditions in the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>AND</b>: All conditions must be met.</para>
                /// </description></item>
                /// <item><description><para><b>OR</b>: At least one condition must be met.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OR</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The list of conditions.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataScRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataScRulesItems : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator. Valid values are <b>&gt;</b>, <b>&lt;**, **&gt;=</b>, <b>&lt;=</b>, <b>==</b>, and <b>!=</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>Not used in Spring Cloud applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// <para>Not used in Spring Cloud applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>The name of the element to match, as specified by the type parameter. For example, a header name or cookie name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The matching operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>rawvalue</b>: Performs a direct comparison.</para>
                    /// </description></item>
                    /// <item><description><para><b>list</b>: Matches against an allowlist of values.</para>
                    /// </description></item>
                    /// <item><description><para><b>mod</b>: Calculates the remainder of a division by 100.</para>
                    /// </description></item>
                    /// <item><description><para><b>deterministic_proportional_steaming_division</b>: Performs a percentage-based match.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The type of request element to match against. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>param</b>: A request parameter.</para>
                    /// </description></item>
                    /// <item><description><para><b>cookie</b>: A cookie.</para>
                    /// </description></item>
                    /// <item><description><para><b>header</b>: A request header.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cookie</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value to match. This value is compared with the actual value of the element specified by <b>type</b> and <b>name</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The path to which the rule applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The timestamp of the rule\&quot;s last update, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1609434061000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the <b>ErrorCode</b> parameter is returned. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message that indicates the result of the call.</para>
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
        /// <para>9D29CBD0-45D3-410B-9826-52F86F90****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID for querying the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

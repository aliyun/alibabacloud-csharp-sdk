// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeGreyTagRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the canary release rule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGreyTagRouteResponseBodyData Data { get; set; }
        public class DescribeGreyTagRouteResponseBodyData : TeaModel {
            [NameInMap("AlbRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataAlbRules> AlbRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataAlbRules : TeaModel {
                /// <summary>
                /// <para>The condition mode of the canary release rule. Valid value: AND. This value indicates that that all conditions must be met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The ID of the gateway routing rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("ingressId")]
                [Validation(Required=false)]
                public string IngressId { get; set; }

                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataAlbRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataAlbRulesItems : TeaModel {
                    /// <summary>
                    /// <para>Valid value: ==.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>This parameter is not returned for applications that are associated with ALB instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// <para>This parameter is not returned for applications that are associated with Application Load Balancer (ALB) instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>The name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operator. Valid value: <b>rawvalue</b>. This value indicates direct comparison.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The type of the comparison. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>sourceIp</b>: SourceIp</description></item>
                    /// <item><description><b>cookie</b>: cookie</description></item>
                    /// <item><description><b>header</b>: header</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cookie</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the parameter. This value is compared with the value that is obtained based on the type and name parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3faaf993-7aed-4bcd-b189-625e6a5a****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The timestamp when the canary release rule was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1619007592013</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the canary release rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The canary release rule of the Dubbo service.</para>
            /// </summary>
            [NameInMap("DubboRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataDubboRules> DubboRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataDubboRules : TeaModel {
                /// <summary>
                /// <para>The relationship between the conditions in the canary release rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AND</b>: The conditions are in the logical AND relation. All conditions must be met at the same time.</description></item>
                /// <item><description><b>OR</b>: The conditions are in the logical OR relation. At least one of the conditions must be met.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OR</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The group of the Dubbo service that corresponds to the canary release rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DUBBO</para>
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The conditions.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataDubboRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataDubboRulesItems : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator. Valid values: <b>&gt;</b>, <b>&lt;**, **&gt;=</b>, <b>&lt;=</b>, <b>==</b>, and <b>! =</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The expression that is used to obtain the value of the parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Empty</b>: obtains the value of the parameter.</description></item>
                    /// <item><description><b>.name</b>: obtains the name property of the parameter. This expression works the same way as args0.getName().</description></item>
                    /// <item><description><b>.isEnabled()</b>: obtains the enabled property of the parameter. This expression works the same way as args0.isEnabled().</description></item>
                    /// <item><description><b>[0]</b>: indicates that the value of the parameter is an array and obtains the first value of the array. This expression works the same way as args0[0]. This expression does not start with a period (.).</description></item>
                    /// <item><description><b>.get(0)</b>: indicates that the value of the parameter is a list and obtains the first value of the list. This expression works the same way as args0.get(0).</description></item>
                    /// <item><description><b>.get(&quot;key&quot;)</b>: indicates that the value of the parameter is a map and obtains the value of the key in the map. This expression works the same way as args0.get(&quot;key&quot;).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>.name</para>
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// <para>The index of the parameter. The value 0 indicates the first parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>This parameter is not returned for Dubbo services.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>rawvalue</b>: direct comparison.</description></item>
                    /// <item><description><b>list</b>: whitelist.</description></item>
                    /// <item><description><b>mod</b>: mods 100.</description></item>
                    /// <item><description><b>deterministic_proportional_steaming_division</b>: percentage.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>This parameter is not returned for Dubbo services.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the parameter. This value is compared with the value that is obtained based on the <b>expr</b> and <b>index</b> parameters.</para>
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
                /// <para>The name of the Dubbo service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.edas.boot.EchoService</para>
                /// </summary>
                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The version of the Dubbo service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The ID of the canary release rule. The ID is globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("GreyTagRouteId")]
            [Validation(Required=false)]
            public long? GreyTagRouteId { get; set; }

            /// <summary>
            /// <para>The name of the canary release rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The canary release rule of the Spring Cloud application.</para>
            /// </summary>
            [NameInMap("ScRules")]
            [Validation(Required=false)]
            public List<DescribeGreyTagRouteResponseBodyDataScRules> ScRules { get; set; }
            public class DescribeGreyTagRouteResponseBodyDataScRules : TeaModel {
                /// <summary>
                /// <para>The relationship between the conditions in the canary release rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AND</b>: The conditions are in the logical AND relation. All conditions must be met at the same time.</description></item>
                /// <item><description><b>OR</b>: The conditions are in the logical OR relation. At least one of the conditions must be met.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OR</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The conditions.</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<DescribeGreyTagRouteResponseBodyDataScRulesItems> Items { get; set; }
                public class DescribeGreyTagRouteResponseBodyDataScRulesItems : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator. Valid values: <b>&gt;</b>, <b>&lt;**, **&gt;=</b>, <b>&lt;=</b>, <b>==</b>, and <b>! =</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>This parameter is not returned for Spring Cloud applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    /// <summary>
                    /// <para>This parameter is not returned for Spring Cloud applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    /// <summary>
                    /// <para>The name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>rawvalue</b>: direct comparison.</description></item>
                    /// <item><description><b>list</b>: whitelist.</description></item>
                    /// <item><description><b>mod</b>: mods 100.</description></item>
                    /// <item><description><b>deterministic_proportional_steaming_division</b>: percentage.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The type of the comparison. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>param</b>: parameter</description></item>
                    /// <item><description><b>cookie</b>: cookie</description></item>
                    /// <item><description><b>header</b>: header</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cookie</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the parameter. This value is compared with the value that is obtained based on the <b>type</b> and <b>name</b> parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The path of the canary release rule of the Spring Cloud application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the canary release rule was updated. Unit: milliseconds.</para>
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
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>Indicates whether the information of the change order was queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information was queried.</description></item>
        /// <item><description><b>false</b>: The information failed to be queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListGreyTagRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the interface or the POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A request error occurs.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurs.</para>
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
        /// <para>The information about the grayscale rule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGreyTagRouteResponseBodyData Data { get; set; }
        public class ListGreyTagRouteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page in a paged query. The value can only be <b>1</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGreyTagRouteResponseBodyDataResult> Result { get; set; }
            public class ListGreyTagRouteResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The grayscale rules created for an application for which an Application Load Balancer (ALB) Ingress is configured.</para>
                /// </summary>
                [NameInMap("AlbRules")]
                [Validation(Required=false)]
                public List<ListGreyTagRouteResponseBodyDataResultAlbRules> AlbRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultAlbRules : TeaModel {
                    /// <summary>
                    /// <para>The conditional pattern of the grayscale rule. Only AND is supported, which indicates that all conditions in the list must be met.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AND</para>
                    /// </summary>
                    [NameInMap("condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The Ingress ID.</para>
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
                    public List<ListGreyTagRouteResponseBodyDataResultAlbRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultAlbRulesItems : TeaModel {
                        /// <summary>
                        /// <para>Only == is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>==</para>
                        /// </summary>
                        [NameInMap("cond")]
                        [Validation(Required=false)]
                        public string Cond { get; set; }

                        /// <summary>
                        /// <para>This parameter is not applicable to ALB applications.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>N/A</para>
                        /// </summary>
                        [NameInMap("expr")]
                        [Validation(Required=false)]
                        public string Expr { get; set; }

                        /// <summary>
                        /// <para>This parameter is not applicable to ALB applications.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>N/A</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The parameter name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The operator. Valid values: Only rawvalue is supported, which indicates a direct comparison.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rawvalue</para>
                        /// </summary>
                        [NameInMap("operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The comparison type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>sourceIp</b>: SourceIp.</para>
                        /// </description></item>
                        /// <item><description><para><b>cookie</b>: Cookie.</para>
                        /// </description></item>
                        /// <item><description><para><b>header</b>: Header.</para>
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
                        /// <para>The parameter value. The value obtained based on type and name is compared with this value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>s-6366-e3****-99**</para>
                    /// </summary>
                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                /// <summary>
                /// <para>The timestamp when the rule was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1619007592013</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The grayscale rules for Dubbo services.</para>
                /// </summary>
                [NameInMap("DubboRules")]
                [Validation(Required=false)]
                public List<ListGreyTagRouteResponseBodyDataResultDubboRules> DubboRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultDubboRules : TeaModel {
                    /// <summary>
                    /// <para>The conditional pattern of the grayscale rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>AND</b>: All conditions in the list must be met.</para>
                    /// </description></item>
                    /// <item><description><para><b>OR</b>: Any condition in the list can be met.</para>
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
                    /// <para>The group of the Dubbo service that corresponds to the grayscale rule.</para>
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
                    public List<ListGreyTagRouteResponseBodyDataResultDubboRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultDubboRulesItems : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator. Valid values: <b>&gt;</b>, <b>&lt;**, **&gt;=</b>, <b>&lt;=</b>, <b>==</b>, and <b>!=</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>==</para>
                        /// </summary>
                        [NameInMap("cond")]
                        [Validation(Required=false)]
                        public string Cond { get; set; }

                        /// <summary>
                        /// <para>The expression that is used to obtain the parameter value. The syntax follows the Spring Expression Language (SpEL). Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>Leave it empty</b>: Obtains the value of the current parameter.</para>
                        /// </description></item>
                        /// <item><description><para><b>.name</b>: Obtains the name property of the parameter. This is equivalent to args0.getName().</para>
                        /// </description></item>
                        /// <item><description><para><b>.isEnabled()</b>: Obtains the enabled property of the parameter. This is equivalent to args0.isEnabled().</para>
                        /// </description></item>
                        /// <item><description><para><b>[0]</b>: Obtains the first value of the array. This is equivalent to args0[0]. Note that the expression does not start with a period (.).</para>
                        /// </description></item>
                        /// <item><description><para><b>.get(0)</b>: Obtains the first value of the list. This is equivalent to args0.get(0).</para>
                        /// </description></item>
                        /// <item><description><para><b>.get(&quot;key&quot;)</b>: Obtains the value that corresponds to the specified key from the map. This is equivalent to args0.get(&quot;key&quot;).</para>
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
                        /// <para>The parameter number. 0 indicates the first parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>This parameter is not applicable to Dubbo services.</para>
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
                        /// <item><description><para><b>rawvalue</b>: Direct comparison.</para>
                        /// </description></item>
                        /// <item><description><para><b>list</b>: Whitelist.</para>
                        /// </description></item>
                        /// <item><description><para><b>mod</b>: Modulo 100 operation.</para>
                        /// </description></item>
                        /// <item><description><para><b>deterministic_proportional_steaming_division</b>: Percentage.</para>
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
                        /// <para>This parameter is not applicable to Dubbo services.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>N/A</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The parameter value. The value obtained based on <b>expr</b> and <b>index</b> is compared with this value.</para>
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
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GreyTagRouteId")]
                [Validation(Required=false)]
                public long? GreyTagRouteId { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule-name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The grayscale rules for Spring Cloud.</para>
                /// </summary>
                [NameInMap("ScRules")]
                [Validation(Required=false)]
                public List<ListGreyTagRouteResponseBodyDataResultScRules> ScRules { get; set; }
                public class ListGreyTagRouteResponseBodyDataResultScRules : TeaModel {
                    /// <summary>
                    /// <para>The conditional pattern of the grayscale rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>AND</b>: All conditions in the list must be met.</para>
                    /// </description></item>
                    /// <item><description><para><b>OR</b>: Any condition in the list can be met.</para>
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
                    public List<ListGreyTagRouteResponseBodyDataResultScRulesItems> Items { get; set; }
                    public class ListGreyTagRouteResponseBodyDataResultScRulesItems : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator. Valid values: <b>&gt;</b>, <b>&lt;**, **&gt;=</b>, <b>&lt;=</b>, <b>==</b>, and <b>!=</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>==</para>
                        /// </summary>
                        [NameInMap("cond")]
                        [Validation(Required=false)]
                        public string Cond { get; set; }

                        /// <summary>
                        /// <para>This parameter is not applicable to Spring Cloud applications.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>N/A</para>
                        /// </summary>
                        [NameInMap("expr")]
                        [Validation(Required=false)]
                        public string Expr { get; set; }

                        /// <summary>
                        /// <para>This parameter is not applicable to Spring Cloud applications.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>N/A</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The parameter name.</para>
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
                        /// <item><description><para><b>rawvalue</b>: Direct comparison.</para>
                        /// </description></item>
                        /// <item><description><para><b>list</b>: Whitelist.</para>
                        /// </description></item>
                        /// <item><description><para><b>mod</b>: Modulo 100 operation.</para>
                        /// </description></item>
                        /// <item><description><para><b>deterministic_proportional_steaming_division</b>: Percentage.</para>
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
                        /// <para>The comparison type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>param</b>: Parameter.</para>
                        /// </description></item>
                        /// <item><description><para><b>cookie</b>: Cookie.</para>
                        /// </description></item>
                        /// <item><description><para><b>header</b>: Header.</para>
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
                        /// <para>The parameter value. The value obtained based on <b>type</b> and <b>name</b> is compared with this value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The path that corresponds to the grayscale rule for the Spring Cloud application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/path</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                /// <summary>
                /// <para>The timestamp when the rule was updated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1609434061000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries. The value can only be <b>1</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, a specific error code is returned.</para>
        /// </description></item>
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
        /// <para>9D29CBD0-45D3-410B-9826-52F86F90****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the query succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The query succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The query failed.</para>
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
        /// <para>The trace ID, which is used to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

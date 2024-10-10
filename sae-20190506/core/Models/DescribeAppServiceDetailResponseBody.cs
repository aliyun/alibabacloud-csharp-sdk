// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeAppServiceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the call was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the call was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the call failed.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAppServiceDetailResponseBodyData Data { get; set; }
        public class DescribeAppServiceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the Dubbo application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-consumer</para>
            /// </summary>
            [NameInMap("DubboApplicationName")]
            [Validation(Required=false)]
            public string DubboApplicationName { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou-micro-service-******</para>
            /// </summary>
            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }

            /// <summary>
            /// <para>The group to which the service belongs. You can create a custom group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>springCloud</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The metadata. Example: <c>{side: &quot;provider&quot;, port: &quot;18081&quot;, preserved: {register: {source: &quot;SPRING_CLOUD&quot;}},…}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{side: &quot;provider&quot;, port: &quot;18081&quot;, preserved: {register: {source: &quot;SPRING_CLOUD&quot;}},…}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The methods.</para>
            /// </summary>
            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<DescribeAppServiceDetailResponseBodyDataMethods> Methods { get; set; }
            public class DescribeAppServiceDetailResponseBodyDataMethods : TeaModel {
                /// <summary>
                /// <para>The class to which the method belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.serverless.sae.controller.EchoController</para>
                /// </summary>
                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                /// <summary>
                /// <para>The name of the method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>echo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The details of the method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("NameDetail")]
                [Validation(Required=false)]
                public string NameDetail { get; set; }

                /// <summary>
                /// <para>The definition of the parameter.</para>
                /// </summary>
                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public List<DescribeAppServiceDetailResponseBodyDataMethodsParameterDefinitions> ParameterDefinitions { get; set; }
                public class DescribeAppServiceDetailResponseBodyDataMethodsParameterDefinitions : TeaModel {
                    /// <summary>
                    /// <para>The description of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>description</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>arg0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>java.lang.String</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The details of the parameters.</para>
                /// </summary>
                [NameInMap("ParameterDetails")]
                [Validation(Required=false)]
                public List<string> ParameterDetails { get; set; }

                /// <summary>
                /// <para>The types of the parameters.</para>
                /// </summary>
                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public List<string> ParameterTypes { get; set; }

                /// <summary>
                /// <para>The request paths. Format:</para>
                /// <para><c>/path</c></para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// <para>The request methods. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>GET</b></description></item>
                /// <item><description><b>ALL</b></description></item>
                /// </list>
                /// </summary>
                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public List<string> RequestMethods { get; set; }

                /// <summary>
                /// <para>The details of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReturnDetails")]
                [Validation(Required=false)]
                public string ReturnDetails { get; set; }

                /// <summary>
                /// <para>The data format of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

            }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-provider</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServicePorts")]
            [Validation(Required=false)]
            public List<long?> ServicePorts { get; set; }

            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public List<string> ServiceTags { get; set; }

            /// <summary>
            /// <para>The type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>dubbo</b></description></item>
            /// <item><description><b>springCloud</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>springCloud</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The name of the Spring Cloud application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-provider</para>
            /// </summary>
            [NameInMap("SpringApplicationName")]
            [Validation(Required=false)]
            public string SpringApplicationName { get; set; }

            /// <summary>
            /// <para>The version of the service. You can create a custom version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The returned error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned information.</para>
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
        /// <para>B2C7874F-F109-5B34-8618-2C10BBA2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the meta data was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The metadata was obtained.</description></item>
        /// <item><description><b>false</b>: The metadata failed to be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. The ID is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b16399316402420740034918e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

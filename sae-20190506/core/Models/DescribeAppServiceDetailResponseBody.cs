// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeAppServiceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the API call or a POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: success.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: redirection.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: client error.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: server error.</para>
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
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou-micro-service-******</para>
            /// </summary>
            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }

            /// <summary>
            /// <para>The service group. This is a custom parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>springCloud</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The metadata. Example: <c>{side: &quot;provider&quot;, port: &quot;18081&quot;, preserved: {register: {source: &quot;SPRING_CLOUD&quot;}},…}</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>{side: &quot;provider&quot;, port: &quot;18081&quot;, preserved: {register: {source: &quot;SPRING_CLOUD&quot;}},…}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The list of methods.</para>
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
                /// <para>The method name.</para>
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
                /// <para>The parameter definitions.</para>
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
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>arg0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The parameter type.</para>
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
                /// <para>The parameter types.</para>
                /// </summary>
                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public List<string> ParameterTypes { get; set; }

                /// <summary>
                /// <para>The request paths.</para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// <para>The request methods.</para>
                /// </summary>
                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public List<string> RequestMethods { get; set; }

                /// <summary>
                /// <para>The details of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReturnDetails")]
                [Validation(Required=false)]
                public string ReturnDetails { get; set; }

                /// <summary>
                /// <para>The return type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

            }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-provider</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The ports used by the service.</para>
            /// </summary>
            [NameInMap("ServicePorts")]
            [Validation(Required=false)]
            public List<long?> ServicePorts { get; set; }

            /// <summary>
            /// <para>The protocol used by the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// <para>The tags of the service.</para>
            /// </summary>
            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public List<string> ServiceTags { get; set; }

            /// <summary>
            /// <para>The service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>dubbo</b></para>
            /// </description></item>
            /// <item><description><para><b>springCloud</b></para>
            /// </description></item>
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
            /// <para>The service version. This is a custom parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, the <b>ErrorCode</b> field is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the <b>ErrorCode</b> field is returned. For more information, see the list of <b>error codes</b> in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information returned.</para>
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
        /// <para>B2C7874F-F109-5B34-8618-2C10BBA2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the metadata was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The metadata was obtained.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The metadata failed to be obtained.</para>
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
        /// <para>The call chain ID. Use this ID for a term query of call details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b16399316402420740034918e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

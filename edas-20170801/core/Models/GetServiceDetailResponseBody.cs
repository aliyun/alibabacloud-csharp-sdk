// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceDetailResponseBodyData Data { get; set; }
        public class GetServiceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the Dubbo application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cartservice</para>
            /// </summary>
            [NameInMap("DubboApplicationName")]
            [Validation(Required=false)]
            public string DubboApplicationName { get; set; }

            /// <summary>
            /// <para>The name of the Enterprise Distributed Application Service (EDAS) application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test123</para>
            /// </summary>
            [NameInMap("EdasAppName")]
            [Validation(Required=false)]
            public string EdasAppName { get; set; }

            /// <summary>
            /// <para>The group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dubbo</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>The methods.</para>
            /// </summary>
            [NameInMap("Methods")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataMethods> Methods { get; set; }
            public class GetServiceDetailResponseBodyDataMethods : TeaModel {
                /// <summary>
                /// <para>The controllers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.aliware.edas.DemoController</para>
                /// </summary>
                [NameInMap("MethodController")]
                [Validation(Required=false)]
                public string MethodController { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>feign2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The specific name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NameDetail")]
                [Validation(Required=false)]
                public string NameDetail { get; set; }

                /// <summary>
                /// <para>The parameter definitions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;description&quot;:&quot;&quot;,&quot;name&quot;:&quot;arg0&quot;,&quot;type&quot;:&quot;java.lang.String&quot;}]</para>
                /// </summary>
                [NameInMap("ParameterDefinitions")]
                [Validation(Required=false)]
                public string ParameterDefinitions { get; set; }

                /// <summary>
                /// <para>The parameter details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ParameterDetails")]
                [Validation(Required=false)]
                public string ParameterDetails { get; set; }

                /// <summary>
                /// <para>The parameter names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ParameterNames")]
                [Validation(Required=false)]
                public string ParameterNames { get; set; }

                /// <summary>
                /// <para>The parameter types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;java.lang.String&quot;]</para>
                /// </summary>
                [NameInMap("ParameterTypes")]
                [Validation(Required=false)]
                public string ParameterTypes { get; set; }

                /// <summary>
                /// <para>The method paths.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;/consumer-echo/feign/{str}&quot;]</para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public string Paths { get; set; }

                /// <summary>
                /// <para>The request methods.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("RequestMethods")]
                [Validation(Required=false)]
                public string RequestMethods { get; set; }

                /// <summary>
                /// <para>The definition of the value returned by the method.</para>
                /// </summary>
                [NameInMap("ReturnDefinition")]
                [Validation(Required=false)]
                public GetServiceDetailResponseBodyDataMethodsReturnDefinition ReturnDefinition { get; set; }
                public class GetServiceDetailResponseBodyDataMethodsReturnDefinition : TeaModel {
                    /// <summary>
                    /// <para>The ID of the return value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The type of the response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>foo</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The response details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReturnDetails")]
                [Validation(Required=false)]
                public string ReturnDetails { get; set; }

                /// <summary>
                /// <para>The type of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("ReturnType")]
                [Validation(Required=false)]
                public string ReturnType { get; set; }

            }

            /// <summary>
            /// <para>The type of the service registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas.service.consumer</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The type of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>springCloud</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The name of the Spring application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas.service.consumer</para>
            /// </summary>
            [NameInMap("SpringApplicationName")]
            [Validation(Required=false)]
            public string SpringApplicationName { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpDubboTranscoder : TeaModel {
        /// <summary>
        /// <para>The Dubbo service group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEV</para>
        /// </summary>
        [NameInMap("dubboServiceGroup")]
        [Validation(Required=false)]
        public string DubboServiceGroup { get; set; }

        /// <summary>
        /// <para>The Dubbo service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.example.DemoService</para>
        /// </summary>
        [NameInMap("dubboServiceName")]
        [Validation(Required=false)]
        public string DubboServiceName { get; set; }

        /// <summary>
        /// <para>The Dubbo service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("dubboServiceVersion")]
        [Validation(Required=false)]
        public string DubboServiceVersion { get; set; }

        /// <summary>
        /// <para>The method mapping list.</para>
        /// </summary>
        [NameInMap("methodMapList")]
        [Validation(Required=false)]
        public List<HttpDubboTranscoderMethodMapList> MethodMapList { get; set; }
        public class HttpDubboTranscoderMethodMapList : TeaModel {
            /// <summary>
            /// <para>The Dubbo method name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sayName</para>
            /// </summary>
            [NameInMap("dubboMethodName")]
            [Validation(Required=false)]
            public string DubboMethodName { get; set; }

            /// <summary>
            /// <para>The HTTP method. Valid values: ALL_GET. ALL_POST. ALL_PUT. ALL_DELETE. ALL_PATCH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL_GET</para>
            /// </summary>
            [NameInMap("httpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            /// <summary>
            /// <para>The method matching path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mytestzbk/sayhello</para>
            /// </summary>
            [NameInMap("methodPath")]
            [Validation(Required=false)]
            public string MethodPath { get; set; }

            /// <summary>
            /// <para>The parameter mapping list.</para>
            /// </summary>
            [NameInMap("paramMapsList")]
            [Validation(Required=false)]
            public List<HttpDubboTranscoderMethodMapListParamMapsList> ParamMapsList { get; set; }
            public class HttpDubboTranscoderMethodMapListParamMapsList : TeaModel {
                /// <summary>
                /// <para>The key used to extract the input parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("extractKey")]
                [Validation(Required=false)]
                public string ExtractKey { get; set; }

                /// <summary>
                /// <para>The input parameter location. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALL_QUERY_PARAMETER: Request parameter.</description></item>
                /// <item><description>ALL_HEADER: Request header.</description></item>
                /// <item><description>ALL_PATH: URI of the request.</description></item>
                /// <item><description>ALL_BODY: Request body.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL_QUERY_PARAMETER</para>
                /// </summary>
                [NameInMap("extractKeySpec")]
                [Validation(Required=false)]
                public string ExtractKeySpec { get; set; }

                /// <summary>
                /// <para>The backend parameter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("mappingType")]
                [Validation(Required=false)]
                public string MappingType { get; set; }

            }

            /// <summary>
            /// <para>The header pass-through type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PASS_ALL: Pass through all headers.</description></item>
            /// <item><description>PASS_NOT: Do not pass through headers.</description></item>
            /// <item><description>PASS_ASSIGN: Pass through specified headers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASS_NOT</para>
            /// </summary>
            [NameInMap("passThroughAllHeaders")]
            [Validation(Required=false)]
            public string PassThroughAllHeaders { get; set; }

            /// <summary>
            /// <para>The list of specified pass-through headers.</para>
            /// </summary>
            [NameInMap("passThroughList")]
            [Validation(Required=false)]
            public List<string> PassThroughList { get; set; }

        }

    }

}

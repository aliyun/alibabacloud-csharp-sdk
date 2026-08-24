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
        /// </summary>
        [NameInMap("dubboServiceGroup")]
        [Validation(Required=false)]
        public string DubboServiceGroup { get; set; }

        /// <summary>
        /// <para>The Dubbo service name.</para>
        /// </summary>
        [NameInMap("dubboServiceName")]
        [Validation(Required=false)]
        public string DubboServiceName { get; set; }

        /// <summary>
        /// <para>The Dubbo service version.</para>
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
                /// <para>The input parameter location. Valid values: ALL_QUERY_PARAMETER: request parameter. ALL_HEADER: request header. ALL_PATH: URI of the request. ALL_BODY: request body.</para>
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
            /// <para>The header pass-through type. Valid values: PASS_ALL: passes through all headers. PASS_NOT: does not pass through any headers. PASS_ASSIGN: passes through specified headers.</para>
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

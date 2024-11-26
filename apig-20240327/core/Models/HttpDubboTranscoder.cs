// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpDubboTranscoder : TeaModel {
        [NameInMap("dubboServiceGroup")]
        [Validation(Required=false)]
        public string DubboServiceGroup { get; set; }

        [NameInMap("dubboServiceName")]
        [Validation(Required=false)]
        public string DubboServiceName { get; set; }

        [NameInMap("dubboServiceVersion")]
        [Validation(Required=false)]
        public string DubboServiceVersion { get; set; }

        [NameInMap("mothedMapList")]
        [Validation(Required=false)]
        public List<HttpDubboTranscoderMothedMapList> MothedMapList { get; set; }
        public class HttpDubboTranscoderMothedMapList : TeaModel {
            [NameInMap("dubboMothedName")]
            [Validation(Required=false)]
            public string DubboMothedName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL_GET</para>
            /// </summary>
            [NameInMap("httpMothed")]
            [Validation(Required=false)]
            public string HttpMothed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/mytestzbk/sayhello</para>
            /// </summary>
            [NameInMap("mothedpath")]
            [Validation(Required=false)]
            public string Mothedpath { get; set; }

            [NameInMap("paramMapsList")]
            [Validation(Required=false)]
            public List<HttpDubboTranscoderMothedMapListParamMapsList> ParamMapsList { get; set; }
            public class HttpDubboTranscoderMothedMapListParamMapsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("extractKey")]
                [Validation(Required=false)]
                public string ExtractKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALL_QUERY_PARAMETER</para>
                /// </summary>
                [NameInMap("extractKeySpec")]
                [Validation(Required=false)]
                public string ExtractKeySpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>java.lang.String</para>
                /// </summary>
                [NameInMap("mappingType")]
                [Validation(Required=false)]
                public string MappingType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PASS_NOT</para>
            /// </summary>
            [NameInMap("passThroughAllHeaders")]
            [Validation(Required=false)]
            public string PassThroughAllHeaders { get; set; }

            [NameInMap("passThroughList")]
            [Validation(Required=false)]
            public List<string> PassThroughList { get; set; }

        }

    }

}

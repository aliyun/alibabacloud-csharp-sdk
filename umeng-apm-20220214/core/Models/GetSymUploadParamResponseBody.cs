// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetSymUploadParamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSymUploadParamResponseBodyData Data { get; set; }
        public class GetSymUploadParamResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>LTAI5tM4ZXXXXX</para>
            /// </summary>
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eyJjYWxsYmFja1VybCI6Imh0dHBzOi8vYXBtLnVtZW5nLmNvbS9oc2Yvc3ltL29zcy9ub3RpZnlNc2ciLCJjYqc29uIn0=</para>
            /// </summary>
            [NameInMap("callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tmp/20220428/5fb6001a73749c24fd9cb356_f49a08dc1225438188c109fcf92eb9f3/symbol.zip</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMjAyMi0wNC0yOFQwNDoxMzo0MS43OTJaIiwiY29uZGl0aW9ucyI6W1siZXEiLCIka2V5IiwidG1WpveGZTSXNJbU5oYkd4aVlXTnJRbTlrZVZSNWNHVWlPaUpoY0hCc2FXTmhkR2x2Ymk5cWMyOXVJbjA9In1dfQ==</para>
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f67c435e08d164f41f6e522a2b5d1d7feb93000</para>
            /// </summary>
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://quickbird.oss-cn-shanghai.aliyuncs.com">https://quickbird.oss-cn-shanghai.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("uploadAddress")]
            [Validation(Required=false)]
            public string UploadAddress { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>succeed in handling request</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f07c516457690916816858d94ea</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

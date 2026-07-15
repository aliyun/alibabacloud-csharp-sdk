// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetPluginClassResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPluginClassResponseBodyData Data { get; set; }
        public class GetPluginClassResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The plug-in alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Key Auth</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The plug-in description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authentication based on API Key</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The document key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc-key-auth</para>
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// <para>The plug-in name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-auth</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The publish status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("publishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// <para>The plug-in type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Auth</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The Wasm plug-in programming language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TinyGo</para>
            /// </summary>
            [NameInMap("wasmLanguage")]
            [Validation(Required=false)]
            public string WasmLanguage { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>29D8B6AE-326F-51AA-83F8-CC00DAF513F8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

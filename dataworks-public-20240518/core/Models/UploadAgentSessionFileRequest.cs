// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadAgentSessionFileRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>attachment-rpc-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public UploadAgentSessionFileRequestParams Params { get; set; }
        public class UploadAgentSessionFileRequestParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b1946ac92492d2347c6235b4d2611184</para>
            /// </summary>
            [NameInMap("ContentMd5")]
            [Validation(Required=false)]
            public string ContentMd5 { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sample.csv</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb</para>
            /// </summary>
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepare</para>
            /// </summary>
            [NameInMap("UploadMode")]
            [Validation(Required=false)]
            public string UploadMode { get; set; }

        }

    }

}

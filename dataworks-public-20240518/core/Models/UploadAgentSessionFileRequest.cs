// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadAgentSessionFileRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC correlation identifier for the current request. The Id in the response returns this value as is to correlate the request and response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attachment-rpc-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. The example uses 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The parameter object for the upload stage. The prepare step issues the upload URL, and the complete step confirms that the file has been written to the target session instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public UploadAgentSessionFileRequestParams Params { get; set; }
        public class UploadAgentSessionFileRequestParams : TeaModel {
            /// <summary>
            /// <para>The MD5 hash of the original bytes in 32-character lowercase hexadecimal format. This parameter is required for both prepare and complete, and the values must be consistent.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b1946ac92492d2347c6235b4d2611184</para>
            /// </summary>
            [NameInMap("ContentMd5")]
            [Validation(Required=false)]
            public string ContentMd5 { get; set; }

            /// <summary>
            /// <para>The original file name. The maximum length is 255 bytes in UTF-8 encoding.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sample.csv</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the target agent session.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The number of original bytes. Valid values: 1 to 10485760 (10 MiB). This parameter is required for both prepare and complete, and the values must be consistent.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The upload identifier returned by prepare. This parameter is required when UploadMode is set to complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb</para>
            /// </summary>
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            /// <summary>
            /// <para>The required upload stage. The prepare step issues a public OSS PUT URL without starting a cold session instance. The complete step resumes the session and allows the runtime to download the file.</para>
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

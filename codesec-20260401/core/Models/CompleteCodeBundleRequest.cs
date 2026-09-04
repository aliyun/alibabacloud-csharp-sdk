// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CompleteCodeBundleRequest : TeaModel {
        /// <summary>
        /// <para>Declared uploaded object size; should match OSS <b><c>Content-Length</c></b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("byteSize")]
        [Validation(Required=false)]
        public long? ByteSize { get; set; }

        /// <summary>
        /// <para>MIME type stored on the bundle (often <b><c>application/octet-stream</c></b> for presigned PUT).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/octet-stream</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

    }

}

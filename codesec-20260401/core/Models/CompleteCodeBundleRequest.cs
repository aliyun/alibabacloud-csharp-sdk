// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CompleteCodeBundleRequest : TeaModel {
        /// <summary>
        /// <para>The declared size of the uploaded object. This value must match the OSS Content-Length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("byteSize")]
        [Validation(Required=false)]
        public long? ByteSize { get; set; }

        /// <summary>
        /// <para>The MIME type of the stored code bundle. This is typically application/octet-stream for pre-signed PUT operations.</para>
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

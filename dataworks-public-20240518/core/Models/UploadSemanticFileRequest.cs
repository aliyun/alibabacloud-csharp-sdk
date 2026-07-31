// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadSemanticFileRequest : TeaModel {
        /// <summary>
        /// <para>The MIME type of the object to upload. Maximum length: 128 characters. This value is included in the signature of UploadUrl. Use the same Content-Type when you perform the PUT request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/pdf</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The original file name of the reference file to upload. Maximum length: 255 characters. When FileId is used for singleTableFile, only CSV or XLSX files are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reference.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The size of the file to upload, in bytes. This value is recorded as attachment metadata. Specify the actual file size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("SizeBytes")]
        [Validation(Required=false)]
        public long? SizeBytes { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeComfyUserDataUploadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The content type of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/jpeg</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The MD5 hash of the file to be uploaded. This value must be the file\&quot;s actual MD5 hash. The file size is also verified during the upload.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54d6911ba6d59dbe68990835a409f18c</para>
        /// </summary>
        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>The name of the file to upload. The filename can be a single file, such as \<c>1.jpg\\</c>, or include a path, such as \<c>directory1/1.jpg\\</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myfile</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The actual size of the file in bytes. This value must be the exact size of the file. The file size is verified when you use the upload URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("FileSizeBytes")]
        [Validation(Required=false)]
        public long? FileSizeBytes { get; set; }

    }

}

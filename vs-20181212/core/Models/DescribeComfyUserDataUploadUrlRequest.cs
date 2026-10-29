// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeComfyUserDataUploadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The content type of the file to be uploaded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/jpeg</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The MD5 value of the file to be uploaded. This value must be the exact MD5 value of the file. The file MD5 value is verified when the upload URL is used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54d6911ba6d59dbe68990835a409f18c</para>
        /// </summary>
        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>The name of the file to be uploaded. The file name format can be a single file name (such as 1.jpg) or a path format (such as directory1/1.jpg).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myfile</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The actual size of the file to be uploaded, in bytes. This value must be the exact size of the file in bytes. The file size is verified when the upload URL is used.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class UploadTranslationFileRequest : TeaModel {
        /// <summary>
        /// <para>The API key that identifies the identity of the member accounts. You can obtain it from the RuiYiBao console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-2***s</para>
        /// </summary>
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        /// <summary>
        /// <para>The file. The SDK supports direct upload and temporary authorized upload.</para>
        /// <list type="bullet">
        /// <item><description><b>Direct upload</b>: Use UploadTranslationFileAdvance in the SDK for direct upload. The Java field type is InputStream, and the Python type is BinaryIO.</description></item>
        /// <item><description><b>Temporary authorized upload</b>: Use AuthorizeFileUpload and UploadTranslationFile in the SDK for temporary authorized upload.<list type="bullet">
        /// <item><description>Step 1: Call AuthorizeFileUpload to obtain a temporary OSS upload credential, then upload the file to obtain the complete file URL.</description></item>
        /// <item><description>Step 2: Call UploadTranslationFile and pass the URL to the File field.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notes on temporary authorized upload</para>
        /// <list type="bullet">
        /// <item><description>You need to additionally import OpenPlatform(2019-12-19) - AuthorizeFileUpload to obtain a temporary OssPolicy. For information about how to upload files, refer to <a href="https://www.alibabacloud.com/help/en/oss/user-guide/uploading-objects-to-oss-directly-from-clients/">Upload objects directly from clients to OSS</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>File size limit</para>
        /// <list type="bullet">
        /// <item><description>The maximum file size is 500 MB.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://gtm-pop-file-upload-zhangjiakou.oss-cn-zhangjiakou.aliyuncs.com/467a_208353582454045230_c8a22285d0b14873aefdcb7eaa7f9046">http://gtm-pop-file-upload-zhangjiakou.oss-cn-zhangjiakou.aliyuncs.com/467a_208353582454045230_c8a22285d0b14873aefdcb7eaa7f9046</a></para>
        /// </summary>
        [NameInMap("File")]
        [Validation(Required=false)]
        public string File { get; set; }

        /// <summary>
        /// <para>The name of the uploaded file.</para>
        /// <para><notice>Make sure the correct file name (including the extension) is provided. Otherwise, file parsing will fail.</notice></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testfile_202511.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

    }

}

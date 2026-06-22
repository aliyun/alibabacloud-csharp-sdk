// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateFileUncompressionTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>Leave this parameter empty unless you have specific requirements.</b></para>
        /// <para>The chained authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access other entity resources</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For details, click Notification. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// <remarks>
        /// <para>Intelligent Media Management API callbacks do not support custom webhook addresses. Use MNS instead.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The password for the encrypted compressed package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The list of files to decompress. If this parameter is empty, the entire compressed package is decompressed. The default value is empty.</para>
        /// </summary>
        [NameInMap("SelectedFiles")]
        [Validation(Required=false)]
        public string SelectedFilesShrink { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) address where the compressed file is stored.</para>
        /// <para>The OSS address must be in the \<c>oss\\://${Bucket}/${Object}\\</c> format. \<c>${Bucket}\\</c> is the name of the OSS bucket in the same region as the current project. \<c>${Object}\\</c> is the full path of the file, including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.zip</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The destination OSS address for the decompressed files. The selected files or the entire compressed package are decompressed to this address.</para>
        /// <para>The OSS address must be in the \<c>oss\\://${Bucket}/${Object}\\</c> format. \<c>${Bucket}\\</c> is the name of the OSS bucket in the same region as the current project. \<c>${Object}\\</c> is the full path of the file, including the file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-dir/</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>Custom user information. It is returned in the asynchronous notification message to help you associate the notification with your system. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

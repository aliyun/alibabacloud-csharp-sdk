// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateFileCompressionTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The compression format for file packaging.</para>
        /// <remarks>
        /// <para>Currently, only the zip format is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zip</para>
        /// </summary>
        [NameInMap("CompressedFormat")]
        [Validation(Required=false)]
        public string CompressedFormat { get; set; }

        /// <summary>
        /// <para><b>If you do not have special requirements, leave this parameter empty.</b></para>
        /// <para>The chained authorization configuration. This parameter is not required. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For more information, see the Notification data type. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// <remarks>
        /// <para>IMM API callbacks do not currently support specifying a webhook address. Use MNS instead.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

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
        /// <para>The address where the file manifest is stored. The file manifest stores the \<c>Sources\\</c> structure in JSON format on OSS. This is suitable for scenarios with many files to package.</para>
        /// <remarks>
        /// <para>Specify either this parameter or <c>Sources</c>. In the manifest file, the <c>URI</c> parameter is required and the <c>Alias</c> parameter is optional. \<c>SourceManifestURI\\</c> supports up to 80,000 packaging rules.</para>
        /// <remarks>
        /// <para>Warning: When you save the content to OSS, specify the OSS address of the file for this parameter.</para>
        /// </remarks>
        /// </remarks>
        /// <para>The following is an example of the file structure:</para>
        /// <pre><c>[{&quot;URI&quot;:&quot;oss://&lt;bucket&gt;/&lt;object&gt;&quot;, &quot;Alias&quot;:&quot;/new-dir/new-name&quot;}]
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.json</para>
        /// </summary>
        [NameInMap("SourceManifestURI")]
        [Validation(Required=false)]
        public string SourceManifestURI { get; set; }

        /// <summary>
        /// <para>A list of files to package and their packaging rules.</para>
        /// <remarks>
        /// <para>Specify either this parameter or \<c>SourceManifestURI\\</c>. \<c>Sources\\</c> supports a maximum of 100 packaging rules.</para>
        /// <remarks>
        /// <para>Warning: If you have more than 100 packaging rules, use the \<c>SourceManifestURI\\</c> parameter.</para>
        /// </remarks>
        /// </remarks>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

        /// <summary>
        /// <para>The OSS address of the output file. The compressed file is named after the file name in this path, such as <c>name.zip</c>.</para>
        /// <para>The OSS address must be in the \<c>oss\\://${Bucket}/${Object}\\</c> format. \<c>${Bucket}\\</c> is the name of the OSS bucket that is in the same region as the current project. \<c>${Object}\\</c> is the full path of the file, including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-target-object.zip</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>Custom user data. This data is returned in the asynchronous notification message, which helps you associate the notification with your internal system. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

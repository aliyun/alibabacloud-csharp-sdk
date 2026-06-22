// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateImageToPDFTaskRequest : TeaModel {
        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The chained authorization configuration. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For more information, click Notification. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

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
        /// <para>A list of input images. The images are converted in the order of their URIs in this list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateImageToPDFTaskRequestSources> Sources { get; set; }
        public class CreateImageToPDFTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>The rotation angle of the image in degrees. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (default)</para>
            /// </description></item>
            /// <item><description><para>90</para>
            /// </description></item>
            /// <item><description><para>180</para>
            /// </description></item>
            /// <item><description><para>270</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Rotate")]
            [Validation(Required=false)]
            public long? Rotate { get; set; }

            /// <summary>
            /// <para>The OSS address of the source image.</para>
            /// <para>The address must be in the \<c>oss\\://${Bucket}/${Object}\\</c> format. \<c>${Bucket}`\\` must be an OSS bucket in the same region as the project. \\</c>${Object}<c>\\</c> must be the full path of the file, including its file name extension.</para>
            /// <para>Supported formats: JPG, JP2, PNG, TIFF, WebP, BMP, and SVG.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://examplebucket/sampleobject.jpg</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>Custom tags used to search for and filter asynchronous tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;User&quot;: &quot;Jane&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The OSS address where the output PDF file is stored.</para>
        /// <para>The address must be in the \<c>oss\\://${bucketname}/${objectname}\\</c> format. \<c>${bucketname}\\</c> must be an OSS bucket in the same region as the project. \<c>${objectname}\\</c> must be the path of the file, including the file name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/outputDocument.pdf</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>Custom user information that is returned in the asynchronous notification message. This helps you associate the notification message with your system. The maximum length is 2048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

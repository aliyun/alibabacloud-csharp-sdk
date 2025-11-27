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
        /// <para>The authorization chain settings. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The list of images. The sequence of image URIs in the list determines the order in which they are converted.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateImageToPDFTaskRequestSources> Sources { get; set; }
        public class CreateImageToPDFTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>The rotation angle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0 (default)</description></item>
            /// <item><description>90</description></item>
            /// <item><description>180</description></item>
            /// <item><description>270</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Rotate")]
            [Validation(Required=false)]
            public long? Rotate { get; set; }

            /// <summary>
            /// <para>The OSS URI of the input image.</para>
            /// <para>Specify the OSS URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
            /// <para>The operation supports the following image formats: JPG, JP2, PNG, TIFF, WebP, BMP, and SVG.</para>
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
        /// <para>The custom tags. You can search for or filter asynchronous tasks by custom tag.</para>
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
        /// <para>The OSS URI of the output file.</para>
        /// <para>Specify the OSS URI in the oss://${bucketname}/${objectname} format, where ${bucketname} is the name of the bucket in the same region as the current project and ${objectname} is the path of the object with the extension included.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/outputDocument.pdf</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The custom information, which is returned in an asynchronous notification and facilitates notification management. The maximum length of the value is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

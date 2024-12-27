// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateImageSplicingTaskRequest : TeaModel {
        /// <summary>
        /// <para>The width or height with which the input images must align. Valid values: 1 to 4096. Unit: px.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>Direction</b> to <c>vertical</c>, this parameter specifies the width with which the input images must align.</description></item>
        /// <item><description>If you set <b>Direction</b> to <c>horizontal</c>, this parameter specifies the height with which the input images must align.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the width or height of the first input image is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192</para>
        /// </summary>
        [NameInMap("Align")]
        [Validation(Required=false)]
        public long? Align { get; set; }

        /// <summary>
        /// <para>The padding color of the spaces specified by <c>Padding</c> and <c>Margin</c>. Colors encoded in the <c>#FFFFFF</c> format and colors that are related to preset keywords such as <c>red</c> and <c>alpha</c> are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>red</para>
        /// </summary>
        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// <para>The authorization chain. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The splicing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vertical (default): All input images are vertically aligned and have the same width.</description></item>
        /// <item><description>horizontal: All input images are horizontally aligned and have the same height.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vertical</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The compression format of the output image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>jpg (default)</description></item>
        /// <item><description>png</description></item>
        /// <item><description>webp</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// <para>The empty space or border around the edges of the output image. Default value: 0. Unit: px.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Margin")]
        [Validation(Required=false)]
        public long? Margin { get; set; }

        /// <summary>
        /// <para>The notification settings. For more information, click Notification. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The space between component images in the output image. Default value: 0. Unit: px.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Padding")]
        [Validation(Required=false)]
        public long? Padding { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The compression quality of the output image. This parameter takes effect only for JPG and WebP images. Valid values: 0 to 100. Default value: 80.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        /// <summary>
        /// <para>The scaling mode of the input images that are vertically or horizontally aligned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>fit (default): Input images are scaled proportionally, and black edges are not retained.</description></item>
        /// <item><description>stretch: Input images are stretched to fill the space.</description></item>
        /// <item><description>horizon: Input images are horizontally stretched.</description></item>
        /// <item><description>vertical: Input images are vertically stretched.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stretch</para>
        /// </summary>
        [NameInMap("ScaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        /// <summary>
        /// <para>The input images. The images are sliced in the order of the input image URIs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateImageSplicingTaskRequestSources> Sources { get; set; }
        public class CreateImageSplicingTaskRequestSources : TeaModel {
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
            /// <para>The Object Storage Service (OSS) bucket in which you store the input images.</para>
            /// <para>Specify the value in the oss://${Bucket}/${Object} format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region as the current project. <c>${Object}</c> specifies the complete path to the input images that have an extension.</para>
            /// <para>The following image formats are supported: jpg and png.</para>
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
        /// <para>The OSS bucket in which you want to store the output image.</para>
        /// <para>Specify the value in the oss://${bucketname}/${objectname} format. ${bucketname} specifies the name of the OSS bucket that resides in the same region as the current project. ${objectname} specifies the path to the output image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/outputImage.jpg</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The user data, which is returned as asynchronous notifications to help manage notifications within your system. The maximum length of the user data is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

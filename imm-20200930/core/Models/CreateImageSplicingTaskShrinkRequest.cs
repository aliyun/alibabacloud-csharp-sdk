// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateImageSplicingTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The alignment value, in pixels, for the width or height of the images to be stitched. The value can range from 1 to 4096.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>Direction</b> to <c>vertical</c>, this parameter specifies the width alignment.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>Direction</b> to <c>horizontal</c>, this parameter specifies the height alignment.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the width or height of the first image is used for alignment by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192</para>
        /// </summary>
        [NameInMap("Align")]
        [Validation(Required=false)]
        public long? Align { get; set; }

        /// <summary>
        /// <para>The fill color for the areas specified by <c>Padding</c> and <c>Margin</c>. The value can be in the <c>#FFFFFF</c> format or a keyword such as <c>red</c> or <c>alpha</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>red</para>
        /// </summary>
        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// <para>The chained authorization configuration. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The image stitching method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>vertical (default): Stitches images vertically. The widths of all images must be the same.</para>
        /// </description></item>
        /// <item><description><para>horizontal: Stitches images horizontally. The heights of all images must be the same.</para>
        /// </description></item>
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
        /// <item><description><para>jpg (default)</para>
        /// </description></item>
        /// <item><description><para>png</para>
        /// </description></item>
        /// <item><description><para>webp</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// <para>The blank margin, in pixels, of the stitched image. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Margin")]
        [Validation(Required=false)]
        public long? Margin { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For information about the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The space, in pixels, between sub-images in the stitched image. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Padding")]
        [Validation(Required=false)]
        public long? Padding { get; set; }

        /// <summary>
        /// <para>The project name. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The compression quality of the output image. This parameter is valid only for JPG and WebP images. The value range is 0 to 100. The default value is 80.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        /// <summary>
        /// <para>The scaling method used when the width or height of an image is aligned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>fit (default): Scales the image without adding black bars. Only proportional scaling is supported.</para>
        /// </description></item>
        /// <item><description><para>stretch: Stretches the image to fill the space.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stretch</para>
        /// </summary>
        [NameInMap("ScaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        /// <summary>
        /// <para>The list of input images. The images are stitched in the order of their URIs in the list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

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
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The OSS URI where the output image is stored.</para>
        /// <para>The URI must be in the oss\://${bucketname}/${objectname} format. ${bucketname} is the name of the OSS bucket that is in the same region as the project. ${objectname} is the path of the file, including the file name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/outputImage.jpg</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The custom information. This information is returned in the asynchronous notification message. Use this information to associate the notification message with your system. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

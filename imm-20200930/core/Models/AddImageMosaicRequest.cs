// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AddImageMosaicRequest : TeaModel {
        /// <summary>
        /// <para><b>If you do not have special requirements, leave this parameter empty.</b></para>
        /// <para>The configurations of authorization chains. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The encoding of the output image. By default, the output image uses the same encoding as the input image. Valid values: jpg, png, and webp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jpg</para>
        /// </summary>
        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

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
        /// <para>The quality of the output image. This parameter applies only to JPG and WebP images. Valid values: 0 to 100. Default value: 80.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// <para>The OSS URI of the input image.</para>
        /// <para>Specify the OSS URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// <para>Supported formats of input images include JPG, PNG, TIFF, JP2, and BMP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/sampleobject.jpg</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The OSS URI of the output image.</para>
        /// <para>Specify the OSS URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/outputImage.jpg</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The bounding boxes and processing parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<AddImageMosaicRequestTargets> Targets { get; set; }
        public class AddImageMosaicRequestTargets : TeaModel {
            /// <summary>
            /// <para>The radius of the Gaussian blur. Valid values: 1 to 50. Default value: 3. Unit: pixels.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for a Gaussian blur.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BlurRadius")]
            [Validation(Required=false)]
            public int? BlurRadius { get; set; }

            /// <summary>
            /// <para>The position of the bounding box.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Boundary")]
            [Validation(Required=false)]
            public AddImageMosaicRequestTargetsBoundary Boundary { get; set; }
            public class AddImageMosaicRequestTargetsBoundary : TeaModel {
                /// <summary>
                /// <para>The height of the bounding box. The value can be an integer greater than or equal to 0 or a decimal within the range of [0,1):</para>
                /// <list type="bullet">
                /// <item><description>An integer value greater than or equal to 0 indicates the height of the bounding box in pixels.</description></item>
                /// <item><description>A decimal value within the range of [0,1) indicates the height of the bounding box as a ratio of its height to the image height.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                /// <summary>
                /// <para>The reference position of the bounding box on the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>topright: the upper-right corner.</description></item>
                /// <item><description>topleft: the upper-left corner. This is the default value.</description></item>
                /// <item><description>bottomright: the lower-right corner.</description></item>
                /// <item><description>bottomleft: the lower-left corner.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topleft</para>
                /// </summary>
                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// <para>The width of the bounding box. The value can be an integer greater than or equal to 0 or a decimal within the range of [0,1):</para>
                /// <list type="bullet">
                /// <item><description>An integer value greater than or equal to 0 indicates the width of the bounding box in pixels.</description></item>
                /// <item><description>A decimal value within the range of [0,1) indicates the width of the bounding box as a ratio of its width to the image width.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// <para>The horizontal offset relative to the reference position. The value can be an integer greater than or equal to 0 or a decimal within the range of [0,1):</para>
                /// <list type="bullet">
                /// <item><description>An integer value greater than or equal to 0 indicates the horizontal offset in pixels.</description></item>
                /// <item><description>A decimal value within the range of [0,1) indicates the horizontal offset as a ratio of the offset to the image width.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The vertical offset relative to the reference position. The value can be an integer greater than or equal to 0 or a decimal within the range of [0,1):</para>
                /// <list type="bullet">
                /// <item><description>An integer value greater than or equal to 0 indicates the vertical offset in pixels.</description></item>
                /// <item><description>A decimal value within the range of [0,1) indicates the vertical offset as a ratio of the offset to the image height.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

            /// <summary>
            /// <para>The color of the color shape. You can specify a color by using a color code such as<c>#RRGGBB</c> or preset color names such as <c>red</c> and <c>white</c>. The default value is #FFFFFF, which is white.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for solid color shapes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>#FFFFFF</para>
            /// </summary>
            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            /// <summary>
            /// <para>The radius of the mosaic. Default value: 5. Unit: pixels.</para>
            /// <remarks>
            /// <para> This parameter does not take effect for Gaussian blurs and solid color shapes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MosaicRadius")]
            [Validation(Required=false)]
            public int? MosaicRadius { get; set; }

            /// <summary>
            /// <para>The standard deviation of the Gaussian blur. The value must be greater than 0. Default value: 5.</para>
            /// <remarks>
            /// <para> This parameter takes effect only for a Gaussian blur.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Sigma")]
            [Validation(Required=false)]
            public int? Sigma { get; set; }

            /// <summary>
            /// <para>The type of the mosaic effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>square: squares.</description></item>
            /// <item><description>diamond: diamonds.</description></item>
            /// <item><description>hexagon: hexagons.</description></item>
            /// <item><description>blur: Gaussian blurs.</description></item>
            /// <item><description>pure: solid color shapes.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>square</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}

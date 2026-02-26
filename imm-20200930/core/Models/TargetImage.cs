// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetImage : TeaModel {
        /// <summary>
        /// <para>The animated images.</para>
        /// </summary>
        [NameInMap("Animations")]
        [Validation(Required=false)]
        public List<TargetImageAnimations> Animations { get; set; }
        public class TargetImageAnimations : TeaModel {
            /// <summary>
            /// <para>The format of the animated image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>gif</description></item>
            /// <item><description>webp</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gif</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The frame rate of the animated image. You can use this parameter together with the Interval parameter to slow down the animation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public double? FrameRate { get; set; }

            /// <summary>
            /// <para>The height of the animated image. By default, the animated image has the same height as the source video. The value of the parameter can be an integer or a decimal.</para>
            /// <list type="bullet">
            /// <item><description>An integer: the number of pixels. Valid values: [1,4096].</description></item>
            /// <item><description>A decimal: the ratio relative to the height of the target image resolution. Valid values: (0,1).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>The time interval for extracting frames. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            /// <summary>
            /// <para>The number of extracted frames. The default value is 0, which indicates that frames are extracted until the end of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The resizing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>stretch: stretches the image to fill the entire space. This is the default value.</description></item>
            /// <item><description>crop: resizes and crops the image.</description></item>
            /// <item><description>fill: resizes the image and keeps the black border.</description></item>
            /// <item><description>fit: resizes the image and removes the black border.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            /// <summary>
            /// <para>The start time for extracting frames. Unit: seconds. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <para>The URI of the animated image.</para>
            /// <para>The OSS URI follows the oss://bucket/object format, where bucket is the name of the bucket in the same region as the current project and object is the path of the object with the extension included.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/animations</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>The width of the animated image. By default, the animated image has the same width as the source video. The value of the parameter can be an integer or a decimal.</para>
            /// <list type="bullet">
            /// <item><description>An integer: the number of pixels. Valid values: [1,4096].</description></item>
            /// <item><description>A decimal: the ratio relative to the width of the target image resolution. Valid values: (0,1).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

        }

        /// <summary>
        /// <para>The frames.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<TargetImageSnapshots> Snapshots { get; set; }
        public class TargetImageSnapshots : TeaModel {
            /// <summary>
            /// <para>The format of the frame. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>jpg</description></item>
            /// <item><description>png</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jpg</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The height of the frame image. By default, the image has the same height as the source video. The value of the parameter can be an integer or a decimal.</para>
            /// <list type="bullet">
            /// <item><description>An integer: the number of pixels. Valid values: [1,4096].</description></item>
            /// <item><description>A decimal: the ratio relative to the height of the target image resolution. Valid values: (0,1).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>The time interval of frame capturing in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>interval</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The number of frames. The default value is 0, which indicates that frames are captured until the end of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The resizing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>stretch: stretches the image to fill the entire space. This is the default value.</description></item>
            /// <item><description>crop: resizes and crops the image.</description></item>
            /// <item><description>fill: resizes the image and keeps the black border.</description></item>
            /// <item><description>fit: resizes the image and removes the black border.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            /// <summary>
            /// <para>The time in seconds at which frame capturing starts. The default value is 0, which indicates that frame capturing starts at the beginning of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            /// <summary>
            /// <para>The OSS URI of the frame.</para>
            /// <para>The OSS URI follows the oss://bucket/object format, where bucket is the name of the bucket in the same region as the current project and object is the path of the object with the extension included.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/snapshots</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>The width of the frame image. By default, the image has the same width as the source video. The value of the parameter can be an integer or a decimal.</para>
            /// <list type="bullet">
            /// <item><description>An integer: the number of pixels. Valid values: [1,4096].</description></item>
            /// <item><description>A decimal: the ratio relative to the width of the target image resolution. Valid values: (0,1).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

        }

        /// <summary>
        /// <para>The sprites.</para>
        /// </summary>
        [NameInMap("Sprites")]
        [Validation(Required=false)]
        public List<TargetImageSprites> Sprites { get; set; }
        public class TargetImageSprites : TeaModel {
            /// <summary>
            /// <para>The format of the sprite. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>jpg</description></item>
            /// <item><description>png</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jpg</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The time interval of frame capturing in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            /// <summary>
            /// <para>The margin between the small images and the edges of the sprite. Default value: 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Margin")]
            [Validation(Required=false)]
            public int? Margin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>interval</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The number of small images in the sprite. The default value is 0, which indicates that frames are captured until the end of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The padding between small images. Default value: 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Pad")]
            [Validation(Required=false)]
            public int? Pad { get; set; }

            /// <summary>
            /// <para>The height of individual small images. The default value is 1. The value can be an integer or a decimal.</para>
            /// <list type="bullet">
            /// <item><description>An integer: the number of pixels. Valid values: (1,4096).</description></item>
            /// <item><description>A decimal: the ratio relative to the height of the target video resolution. Valid values: (0,1].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("ScaleHeight")]
            [Validation(Required=false)]
            public float? ScaleHeight { get; set; }

            /// <summary>
            /// <para>The resizing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>stretch: stretches the image to fill the entire space. This is the default value.</description></item>
            /// <item><description>crop: resizes and crops the image.</description></item>
            /// <item><description>fill: resizes the image and keeps the black border.</description></item>
            /// <item><description>fit: resizes the image and removes the black border.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            /// <summary>
            /// <para>The width of individual small images. The default value is 1. The value can be an integer or a decimal.</para>
            /// <list type="bullet">
            /// <item><description>An integer: the number of pixels. Valid values: (1,4096).</description></item>
            /// <item><description>A decimal: the ratio relative to the width of the target video resolution. Valid values: (0,1].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("ScaleWidth")]
            [Validation(Required=false)]
            public float? ScaleWidth { get; set; }

            /// <summary>
            /// <para>The time in seconds at which frame capturing starts. The default value is 0, which indicates that frame capturing starts at the beginning of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            /// <summary>
            /// <para>The number of small images in each column. Default value: 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TileHeight")]
            [Validation(Required=false)]
            public int? TileHeight { get; set; }

            /// <summary>
            /// <para>The number of small images in each row. Default value: 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TileWidth")]
            [Validation(Required=false)]
            public int? TileWidth { get; set; }

            /// <summary>
            /// <para>The URI of the sprite in Object Storage Service (OSS).</para>
            /// <para>The OSS URI follows the oss://bucket/object format, where bucket is the name of the bucket in the same region as the current project and object is the path of the object with the extension included.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/sprites</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        /// <summary>
        /// <para>The input for the snapshot job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestInput Input { get; set; }
        public class SubmitSnapshotJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input media asset.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>Type</c> is <c>OSS</c>, specify the OSS URL of the input file.</para>
            /// </description></item>
            /// <item><description><para>If <c>Type</c> is <c>Media</c>, specify the ID of the media asset.</para>
            /// </description></item>
            /// </list>
            /// <para>The OSS URL must be in one of the following formats:</para>
            /// <ol>
            /// <item><description><para><c>oss://bucket/object</c></para>
            /// </description></item>
            /// <item><description><para><c>http(s)://bucket.oss-[RegionId].aliyuncs.com/object</c>
            /// <br>In these formats, <c>bucket</c> is the name of an OSS bucket located in the same region as the current project, and <c>object</c> is the file path.<br></para>
            /// </description></item>
            /// </ol>
            /// <remarks>
            /// <para>The OSS bucket specified in the URL must be added to IMS <a href="https://help.aliyun.com/document_detail/609918.html">storage management</a> before use.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>OSS</c>: an OSS file URL.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: a media asset ID.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the snapshot job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleJob</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output destination for the snapshot job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestOutput Output { get; set; }
        public class SubmitSnapshotJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The output media asset.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>Type</c> is <c>OSS</c>, specify the OSS URL for the output file.</para>
            /// </description></item>
            /// <item><description><para>If <c>Type</c> is <c>Media</c>, specify the ID of the output media asset.</para>
            /// </description></item>
            /// </list>
            /// <para>The OSS URL must be in one of the following formats:</para>
            /// <ol>
            /// <item><description><para><c>oss://bucket/object</c></para>
            /// </description></item>
            /// <item><description><para><c>http(s)://bucket.oss-[RegionId].aliyuncs.com/object</c></para>
            /// </description></item>
            /// </ol>
            /// <para>In these formats, <c>bucket</c> is the name of an OSS bucket located in the same region as the current project, and <c>object</c> is the file path.</para>
            /// <list type="bullet">
            /// <item><description><para>When capturing multiple static snapshots, the <c>object</c> must contain the <c>{Count}</c> placeholder.</para>
            /// </description></item>
            /// <item><description><para>When capturing a sprite, the <c>object</c> must contain the <c>{TileCount}</c> placeholder.</para>
            /// </description></item>
            /// <item><description><para>For WebVTT snapshots, the filename in the <c>object</c> path must end with <c>.vtt</c>.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The OSS bucket specified in the URL must be added to IMS <a href="https://help.aliyun.com/document_detail/609918.html">storage management</a> before use.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/output-{Count}.jpg</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the output. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>OSS</c>: an OSS file URL.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: a media asset ID.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The scheduling configuration.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSnapshotJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

        }

        /// <summary>
        /// <para>The snapshot template configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestTemplateConfig TemplateConfig { get; set; }
        public class SubmitSnapshotJobRequestTemplateConfig : TeaModel {
            /// <summary>
            /// <para>Parameters used to override settings in the specified template.</para>
            /// </summary>
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitSnapshotJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitSnapshotJobRequestTemplateConfigOverwriteParams : TeaModel {
                /// <summary>
                /// <para>The threshold for detecting and filtering black content in the first frame. This applies only to multi-frame snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("BlackLevel")]
                [Validation(Required=false)]
                public int? BlackLevel { get; set; }

                /// <summary>
                /// <para>The number of snapshots to capture.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The frame type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>intra</para>
                /// </summary>
                [NameInMap("FrameType")]
                [Validation(Required=false)]
                public string FrameType { get; set; }

                /// <summary>
                /// <para>The output image height.</para>
                /// 
                /// <b>Example:</b>
                /// <para>480</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>The interval between snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// <para>Specifies whether to stitch snapshots into a single sprite. This applies only to WebVTT snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSptFrag")]
                [Validation(Required=false)]
                public bool? IsSptFrag { get; set; }

                /// <summary>
                /// <para>The threshold for determining whether a pixel is black.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("PixelBlackThreshold")]
                [Validation(Required=false)]
                public int? PixelBlackThreshold { get; set; }

                /// <summary>
                /// <para>The sprite configuration.</para>
                /// </summary>
                [NameInMap("SpriteSnapshotConfig")]
                [Validation(Required=false)]
                public SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig SpriteSnapshotConfig { get; set; }
                public class SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig : TeaModel {
                    /// <summary>
                    /// <para>The height of each tile. Default: the height of the output snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>480</para>
                    /// </summary>
                    [NameInMap("CellHeight")]
                    [Validation(Required=false)]
                    public int? CellHeight { get; set; }

                    /// <summary>
                    /// <para>The width of each tile. Default: the width of the output snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("CellWidth")]
                    [Validation(Required=false)]
                    public int? CellWidth { get; set; }

                    /// <summary>
                    /// <para>The background color.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>#000000</para>
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <para>The number of columns in the sprite grid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public int? Columns { get; set; }

                    /// <summary>
                    /// <para>The number of rows in the sprite grid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Lines")]
                    [Validation(Required=false)]
                    public int? Lines { get; set; }

                    /// <summary>
                    /// <para>The margin around the sprite, in pixels. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Margin")]
                    [Validation(Required=false)]
                    public int? Margin { get; set; }

                    /// <summary>
                    /// <para>The padding between tiles, in pixels. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Padding")]
                    [Validation(Required=false)]
                    public int? Padding { get; set; }

                }

                /// <summary>
                /// <para>The start time for capturing snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                /// <summary>
                /// <para>The snapshot type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sprite</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The output image width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>The snapshot template ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Custom user data, passed as a JSON-formatted string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test parameter&quot;: &quot;test value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

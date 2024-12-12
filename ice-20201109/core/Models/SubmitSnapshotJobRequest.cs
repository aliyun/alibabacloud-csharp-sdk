// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        /// <summary>
        /// <para>The snapshot input.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestInput Input { get; set; }
        public class SubmitSnapshotJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input file. If Type is set to OSS, the URL of an OSS object is returned. If Type is set to Media, the ID of a media asset is returned. The URL of an OSS object can be in one of the following formats:</para>
            /// <ol>
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object In the URL, bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object URL in OSS.</description></item>
            /// </ol>
            /// <remarks>
            /// <para> Before you use the OSS bucket in the URL, you must add the bucket on the <a href="https://help.aliyun.com/document_detail/609918.html">Storage Management</a> page of the Intelligent Media Services (IMS) console.</para>
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
            /// <para>The type of the input file. Valid values:</para>
            /// <ol>
            /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
            /// </ol>
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
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleJob</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The snapshot output.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestOutput Output { get; set; }
        public class SubmitSnapshotJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The output file. If Type is set to OSS, the URL of an OSS object is returned. If Type is set to Media, the ID of a media asset is returned. The URL of an OSS object can be in one of the following formats:</para>
            /// <ol>
            /// <item><description>oss://bucket/object</description></item>
            /// <item><description>http(s)://bucket.oss-[RegionId].aliyuncs.com/object</description></item>
            /// </ol>
            /// <para>In the URL, bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object URL in OSS. If multiple static snapshots were captured, the object must contain the &quot;{Count}&quot; placeholder. In the case of a sprite, the object must contain the &quot;{TileCount}&quot; placeholder. The suffix of the WebVTT snapshot objects must be &quot;.vtt&quot;.</para>
            /// <remarks>
            /// <para> Before you use the OSS bucket in the URL, you must add the bucket on the <a href="https://help.aliyun.com/document_detail/609918.html">Storage Management</a> page of the IMS console.</para>
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
            /// <para>The type of the output file. Valid values:</para>
            /// <ol>
            /// <item><description>OSS: an OSS object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
            /// </ol>
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
        /// <para>The scheduling settings.</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSnapshotJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue that is used to run the job.</para>
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
            /// <para>The parameters that are used to overwrite the corresponding parameters.</para>
            /// </summary>
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitSnapshotJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitSnapshotJobRequestTemplateConfigOverwriteParams : TeaModel {
                /// <summary>
                /// <para>The threshold that is used to filter out black frames for the first snapshot to be captured. This feature is available if you request the system to capture multiple snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("BlackLevel")]
                [Validation(Required=false)]
                public int? BlackLevel { get; set; }

                /// <summary>
                /// <para>The number of snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The type of the frame.</para>
                /// 
                /// <b>Example:</b>
                /// <para>intra</para>
                /// </summary>
                [NameInMap("FrameType")]
                [Validation(Required=false)]
                public string FrameType { get; set; }

                /// <summary>
                /// <para>The height of a captured snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>480</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>The interval at which snapshots are captured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// <para>The WebVTT snapshot configuration that specifies whether to merge the output snapshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSptFrag")]
                [Validation(Required=false)]
                public bool? IsSptFrag { get; set; }

                /// <summary>
                /// <para>The color value threshold that determines whether a pixel is black.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("PixelBlackThreshold")]
                [Validation(Required=false)]
                public int? PixelBlackThreshold { get; set; }

                /// <summary>
                /// <para>The configuration of the sprite snapshot.</para>
                /// </summary>
                [NameInMap("SpriteSnapshotConfig")]
                [Validation(Required=false)]
                public SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig SpriteSnapshotConfig { get; set; }
                public class SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig : TeaModel {
                    /// <summary>
                    /// <para>The height of a single snapshot before tiling. The default value is the height of the output snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>480</para>
                    /// </summary>
                    [NameInMap("CellHeight")]
                    [Validation(Required=false)]
                    public int? CellHeight { get; set; }

                    /// <summary>
                    /// <para>The width of a single snapshot before tiling. The default value is the width of the output snapshot.</para>
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
                    /// <para>The number of columns that the image sprite contains.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public int? Columns { get; set; }

                    /// <summary>
                    /// <para>The number of rows that the image sprite contains.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Lines")]
                    [Validation(Required=false)]
                    public int? Lines { get; set; }

                    /// <summary>
                    /// <para>The width of the frame. Default value: 0. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Margin")]
                    [Validation(Required=false)]
                    public int? Margin { get; set; }

                    /// <summary>
                    /// <para>The spacing between two adjacent snapshots. Default value: 0. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Padding")]
                    [Validation(Required=false)]
                    public int? Padding { get; set; }

                }

                /// <summary>
                /// <para>The point in time at which the system starts to capture snapshots in the input video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                /// <summary>
                /// <para>The snapshot type. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sprite</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The width of a captured snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <para>The template ID.</para>
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
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test parameter&quot;: &quot;test value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

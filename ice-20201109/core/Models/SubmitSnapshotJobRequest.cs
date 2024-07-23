// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSnapshotJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestInput Input { get; set; }
        public class SubmitSnapshotJobRequestInput : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>SampleJob</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestOutput Output { get; set; }
        public class SubmitSnapshotJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/output-{Count}.jpg</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSnapshotJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>96e8864746a0b6f3</b></b></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public SubmitSnapshotJobRequestTemplateConfig TemplateConfig { get; set; }
        public class SubmitSnapshotJobRequestTemplateConfig : TeaModel {
            [NameInMap("OverwriteParams")]
            [Validation(Required=false)]
            public SubmitSnapshotJobRequestTemplateConfigOverwriteParams OverwriteParams { get; set; }
            public class SubmitSnapshotJobRequestTemplateConfigOverwriteParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("BlackLevel")]
                [Validation(Required=false)]
                public int? BlackLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>intra</para>
                /// </summary>
                [NameInMap("FrameType")]
                [Validation(Required=false)]
                public string FrameType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>480</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSptFrag")]
                [Validation(Required=false)]
                public bool? IsSptFrag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("PixelBlackThreshold")]
                [Validation(Required=false)]
                public int? PixelBlackThreshold { get; set; }

                [NameInMap("SpriteSnapshotConfig")]
                [Validation(Required=false)]
                public SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig SpriteSnapshotConfig { get; set; }
                public class SubmitSnapshotJobRequestTemplateConfigOverwriteParamsSpriteSnapshotConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>480</para>
                    /// </summary>
                    [NameInMap("CellHeight")]
                    [Validation(Required=false)]
                    public int? CellHeight { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("CellWidth")]
                    [Validation(Required=false)]
                    public int? CellWidth { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>#000000</para>
                    /// </summary>
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public int? Columns { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Lines")]
                    [Validation(Required=false)]
                    public int? Lines { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Margin")]
                    [Validation(Required=false)]
                    public int? Margin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Padding")]
                    [Validation(Required=false)]
                    public int? Padding { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Sprite</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>{&quot;test parameter&quot;: &quot;test value&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

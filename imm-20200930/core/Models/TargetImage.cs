// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetImage : TeaModel {
        [NameInMap("Animations")]
        [Validation(Required=false)]
        public List<TargetImageAnimations> Animations { get; set; }
        public class TargetImageAnimations : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public double? FrameRate { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

        }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<TargetImageSnapshots> Snapshots { get; set; }
        public class TargetImageSnapshots : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

        }

        [NameInMap("Sprites")]
        [Validation(Required=false)]
        public List<TargetImageSprites> Sprites { get; set; }
        public class TargetImageSprites : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            [NameInMap("Margin")]
            [Validation(Required=false)]
            public int? Margin { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            [NameInMap("Pad")]
            [Validation(Required=false)]
            public int? Pad { get; set; }

            [NameInMap("ScaleHeight")]
            [Validation(Required=false)]
            public float? ScaleHeight { get; set; }

            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            [NameInMap("ScaleWidth")]
            [Validation(Required=false)]
            public float? ScaleWidth { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            [NameInMap("TileHeight")]
            [Validation(Required=false)]
            public int? TileHeight { get; set; }

            [NameInMap("TileWidth")]
            [Validation(Required=false)]
            public int? TileWidth { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

    }

}

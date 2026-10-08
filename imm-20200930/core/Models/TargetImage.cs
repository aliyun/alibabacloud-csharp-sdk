// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetImage : TeaModel {
        /// <summary>
        /// <para>Animations</para>
        /// </summary>
        [NameInMap("Animations")]
        [Validation(Required=false)]
        public List<TargetImageAnimations> Animations { get; set; }
        public class TargetImageAnimations : TeaModel {
            /// <summary>
            /// <para>Format</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gif</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>FrameRate</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public double? FrameRate { get; set; }

            /// <summary>
            /// <para>Height</para>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>Interval</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            /// <summary>
            /// <para>Number</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>ScaleType</para>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            /// <summary>
            /// <para>StartTime</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public double? StartTime { get; set; }

            /// <summary>
            /// <para>URI</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/animations</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>Width</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

        }

        /// <summary>
        /// <para>Snapshots</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<TargetImageSnapshots> Snapshots { get; set; }
        public class TargetImageSnapshots : TeaModel {
            /// <summary>
            /// <para>Format</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jpg</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Height</para>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public double? Height { get; set; }

            /// <summary>
            /// <para>Interval</para>
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
            /// <para>Number</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>ScaleType</para>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            /// <summary>
            /// <para>StartTime</para>
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
            /// <para>URI</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/snapshots</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            /// <summary>
            /// <para>Width</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public double? Width { get; set; }

        }

        /// <summary>
        /// <para>Sprites</para>
        /// </summary>
        [NameInMap("Sprites")]
        [Validation(Required=false)]
        public List<TargetImageSprites> Sprites { get; set; }
        public class TargetImageSprites : TeaModel {
            /// <summary>
            /// <para>Format</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jpg</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>Interval</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public double? Interval { get; set; }

            /// <summary>
            /// <para>Margin</para>
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
            /// <para>Number</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>Pad</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Pad")]
            [Validation(Required=false)]
            public int? Pad { get; set; }

            /// <summary>
            /// <para>ScaleHeight</para>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("ScaleHeight")]
            [Validation(Required=false)]
            public float? ScaleHeight { get; set; }

            /// <summary>
            /// <para>ScaleType</para>
            /// 
            /// <b>Example:</b>
            /// <para>crop</para>
            /// </summary>
            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            /// <summary>
            /// <para>ScaleWidth</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("ScaleWidth")]
            [Validation(Required=false)]
            public float? ScaleWidth { get; set; }

            /// <summary>
            /// <para>StartTime</para>
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
            /// <para>TileHeight</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TileHeight")]
            [Validation(Required=false)]
            public int? TileHeight { get; set; }

            /// <summary>
            /// <para>TileWidth</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TileWidth")]
            [Validation(Required=false)]
            public int? TileWidth { get; set; }

            /// <summary>
            /// <para>URI</para>
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

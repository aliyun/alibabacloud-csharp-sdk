// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class CreateMPULayoutRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Only a single ID is supported. You can create and query application IDs in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The maximum number of audio mixes. Valid values: <b>0</b> to <b>6</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AudioMixCount")]
        [Validation(Required=false)]
        public int? AudioMixCount { get; set; }

        /// <summary>
        /// <para>The name of the layout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LayoutName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of panes in the layout.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<CreateMPULayoutRequestPanes> Panes { get; set; }
        public class CreateMPULayoutRequestPanes : TeaModel {
            /// <summary>
            /// <para>The height of the pane, represented as a normalized percentage. Valid values: <b>0.0 &lt; Height ≤ 1.0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public float? Height { get; set; }

            /// <summary>
            /// <para>Specifies the main pane. Each layout can have only one main pane.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: secondary pane.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: main pane.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MajorPane")]
            [Validation(Required=false)]
            public int? MajorPane { get; set; }

            /// <summary>
            /// <para>The pane ID. Panes are sorted from top left to bottom right, starting from 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// <para>The width of the pane, represented as a normalized percentage. Valid values: <b>0.0 &lt; Width ≤ 1.0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public float? Width { get; set; }

            /// <summary>
            /// <para>The X-coordinate, represented as a normalized percentage. Valid values: <b>0.0 ≤ X ≤ 1.0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public float? X { get; set; }

            /// <summary>
            /// <para>The Y-coordinate, represented as a normalized percentage. Valid values: <b>0.0 ≤ Y ≤ 1.0</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public float? Y { get; set; }

            /// <summary>
            /// <para>The stacking order. A value of 0 indicates the bottom layer. A value of 1 indicates the layer above 0, and so on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ZOrder")]
            [Validation(Required=false)]
            public int? ZOrder { get; set; }

        }

    }

}

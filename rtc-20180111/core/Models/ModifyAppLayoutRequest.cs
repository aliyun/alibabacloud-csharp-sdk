// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppLayoutRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. Create and query through the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Idempotent parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Layout.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Layout")]
        [Validation(Required=false)]
        public ModifyAppLayoutRequestLayout Layout { get; set; }
        public class ModifyAppLayoutRequestLayout : TeaModel {
            /// <summary>
            /// <para>Layout ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123121231313</para>
            /// </summary>
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            /// <summary>
            /// <para>Layout name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>List of panes.</para>
            /// </summary>
            [NameInMap("Panes")]
            [Validation(Required=false)]
            public List<ModifyAppLayoutRequestLayoutPanes> Panes { get; set; }
            public class ModifyAppLayoutRequestLayoutPanes : TeaModel {
                /// <summary>
                /// <para>Pane height, normalized percentage. Height ranges from 0.0&lt;Height≤1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public double? Height { get; set; }

                /// <summary>
                /// <para>Pane ID, starting from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PaneId")]
                [Validation(Required=false)]
                public long? PaneId { get; set; }

                /// <summary>
                /// <para>Pane width, normalized percentage. Width ranges from 0.0&lt;Width≤1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public double? Width { get; set; }

                /// <summary>
                /// <para>X coordinate, normalized percentage. The X coordinate ranges from 0.0 to 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// <para>Y coordinate, normalized percentage. The Y coordinate ranges from 0.0 to 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

                /// <summary>
                /// <para>Stacking order. 0 is the bottom layer, 1 is above 0, and so on.</para>
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

}

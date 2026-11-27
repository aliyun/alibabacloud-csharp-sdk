// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppLayoutsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of layouts.</para>
        /// </summary>
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public List<DescribeAppLayoutsResponseBodyLayouts> Layouts { get; set; }
        public class DescribeAppLayoutsResponseBodyLayouts : TeaModel {
            /// <summary>
            /// <para>The layout ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167466539798442****</para>
            /// </summary>
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            /// <summary>
            /// <para>The layout name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of panes.</para>
            /// </summary>
            [NameInMap("Panes")]
            [Validation(Required=false)]
            public List<DescribeAppLayoutsResponseBodyLayoutsPanes> Panes { get; set; }
            public class DescribeAppLayoutsResponseBodyLayoutsPanes : TeaModel {
                /// <summary>
                /// <para>The pane height, as a normalized percentage. The value range for Height is 0.0 &lt; Height ≤ 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                /// <summary>
                /// <para>The pane ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PaneId")]
                [Validation(Required=false)]
                public int? PaneId { get; set; }

                /// <summary>
                /// <para>The pane width, as a normalized percentage. The value range for Width is 0.0 &lt; Width ≤ 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// <para>The X coordinate, as a normalized percentage. The value range for X is 0.0 ≤ X ≤ 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// <para>The Y coordinate, as a normalized percentage. The value range for Y is 0.0 ≤ Y ≤ 1.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                /// <summary>
                /// <para>The Z-order. 0 is the bottom layer, 1 is above 0, and so on.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}

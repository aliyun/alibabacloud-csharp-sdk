// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeSystemLayoutListResponseBody : TeaModel {
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public DescribeSystemLayoutListResponseBodyLayouts Layouts { get; set; }
        public class DescribeSystemLayoutListResponseBodyLayouts : TeaModel {
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public List<DescribeSystemLayoutListResponseBodyLayoutsLayout> Layout { get; set; }
            public class DescribeSystemLayoutListResponseBodyLayoutsLayout : TeaModel {
                /// <summary>
                /// <para>AudioMixCount。</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AudioMixCount")]
                [Validation(Required=false)]
                public int? AudioMixCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public long? LayoutId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Panes")]
                [Validation(Required=false)]
                public DescribeSystemLayoutListResponseBodyLayoutsLayoutPanes Panes { get; set; }
                public class DescribeSystemLayoutListResponseBodyLayoutsLayoutPanes : TeaModel {
                    [NameInMap("Panes")]
                    [Validation(Required=false)]
                    public List<DescribeSystemLayoutListResponseBodyLayoutsLayoutPanesPanes> Panes { get; set; }
                    public class DescribeSystemLayoutListResponseBodyLayoutsLayoutPanesPanes : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.25</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        /// <summary>
                        /// <para>MajorPane。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("MajorPane")]
                        [Validation(Required=false)]
                        public int? MajorPane { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("PaneId")]
                        [Validation(Required=false)]
                        public int? PaneId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.25</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.25</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.25</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                        /// <summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}

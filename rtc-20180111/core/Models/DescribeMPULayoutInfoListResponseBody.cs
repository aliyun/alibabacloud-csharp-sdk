// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeMPULayoutInfoListResponseBody : TeaModel {
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public DescribeMPULayoutInfoListResponseBodyLayouts Layouts { get; set; }
        public class DescribeMPULayoutInfoListResponseBodyLayouts : TeaModel {
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public List<DescribeMPULayoutInfoListResponseBodyLayoutsLayout> Layout { get; set; }
            public class DescribeMPULayoutInfoListResponseBodyLayoutsLayout : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AudioMixCount")]
                [Validation(Required=false)]
                public int? AudioMixCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public long? LayoutId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LayoutName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Panes")]
                [Validation(Required=false)]
                public DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanes Panes { get; set; }
                public class DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanes : TeaModel {
                    [NameInMap("Panes")]
                    [Validation(Required=false)]
                    public List<DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanesPanes> Panes { get; set; }
                    public class DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanesPanes : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.5</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        /// <summary>
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
                        /// <para>0.5</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.5</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.5</para>
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
        /// <para>760bad53276431c499e30dc36f6b26be</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}

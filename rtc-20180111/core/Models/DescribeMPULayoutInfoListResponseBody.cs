// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeMPULayoutInfoListResponseBody : TeaModel {
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public DescribeMPULayoutInfoListResponseBodyLayouts Layouts { get; set; }
        public class DescribeMPULayoutInfoListResponseBodyLayouts : TeaModel {
            [NameInMap("Layout")]
            [Validation(Required=false)]
            public List<DescribeMPULayoutInfoListResponseBodyLayoutsLayout> Layout { get; set; }
            public class DescribeMPULayoutInfoListResponseBodyLayoutsLayout : TeaModel {
                public long? LayoutId { get; set; }
                public DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanes Panes { get; set; }
                public class DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanes : TeaModel {
                    [NameInMap("Panes")]
                    [Validation(Required=false)]
                    public List<DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanesPanes> Panes { get; set; }
                    public class DescribeMPULayoutInfoListResponseBodyLayoutsLayoutPanesPanes : TeaModel {
                        [NameInMap("MajorPane")]
                        [Validation(Required=false)]
                        public int? MajorPane { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                        [NameInMap("PaneId")]
                        [Validation(Required=false)]
                        public int? PaneId { get; set; }

                        [NameInMap("ZOrder")]
                        [Validation(Required=false)]
                        public int? ZOrder { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                    }

                }
                public string Name { get; set; }
                public int? AudioMixCount { get; set; }
            }
        };

    }

}

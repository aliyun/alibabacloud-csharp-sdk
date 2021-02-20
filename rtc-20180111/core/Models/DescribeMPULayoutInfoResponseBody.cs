// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeMPULayoutInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Layout")]
        [Validation(Required=false)]
        public DescribeMPULayoutInfoResponseBodyLayout Layout { get; set; }
        public class DescribeMPULayoutInfoResponseBodyLayout : TeaModel {
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public long? LayoutId { get; set; }
            [NameInMap("Panes")]
            [Validation(Required=false)]
            public DescribeMPULayoutInfoResponseBodyLayoutPanes Panes { get; set; }
            public class DescribeMPULayoutInfoResponseBodyLayoutPanes : TeaModel {
                [NameInMap("Panes")]
                [Validation(Required=false)]
                public List<DescribeMPULayoutInfoResponseBodyLayoutPanesPanes> Panes { get; set; }
                public class DescribeMPULayoutInfoResponseBodyLayoutPanesPanes : TeaModel {
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
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("AudioMixCount")]
            [Validation(Required=false)]
            public int? AudioMixCount { get; set; }
        };

    }

}

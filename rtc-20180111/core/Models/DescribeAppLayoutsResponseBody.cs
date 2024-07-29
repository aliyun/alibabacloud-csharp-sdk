// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppLayoutsResponseBody : TeaModel {
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public List<DescribeAppLayoutsResponseBodyLayouts> Layouts { get; set; }
        public class DescribeAppLayoutsResponseBodyLayouts : TeaModel {
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Panes")]
            [Validation(Required=false)]
            public List<DescribeAppLayoutsResponseBodyLayoutsPanes> Panes { get; set; }
            public class DescribeAppLayoutsResponseBodyLayoutsPanes : TeaModel {
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                [NameInMap("PaneId")]
                [Validation(Required=false)]
                public int? PaneId { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterComponentsResponseBody : TeaModel {
        [NameInMap("Components")]
        [Validation(Required=false)]
        public DescribeCasterComponentsResponseBodyComponents Components { get; set; }
        public class DescribeCasterComponentsResponseBodyComponents : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<DescribeCasterComponentsResponseBodyComponentsComponent> Component { get; set; }
            public class DescribeCasterComponentsResponseBodyComponentsComponent : TeaModel {
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public string BorderColor { get; set; }

                [NameInMap("BorderWidthNormalized")]
                [Validation(Required=false)]
                public float? BorderWidthNormalized { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("SizeNormalized")]
                [Validation(Required=false)]
                public float? SizeNormalized { get; set; }

                [NameInMap("FontName")]
                [Validation(Required=false)]
                public string FontName { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

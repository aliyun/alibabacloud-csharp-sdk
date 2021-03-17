// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ChangeImageSizeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChangeImageSizeResponseBodyData Data { get; set; }
        public class ChangeImageSizeResponseBodyData : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
            [NameInMap("RetainLocation")]
            [Validation(Required=false)]
            public ChangeImageSizeResponseBodyDataRetainLocation RetainLocation { get; set; }
            public class ChangeImageSizeResponseBodyDataRetainLocation : TeaModel {
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public int? Y { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public int? X { get; set; }

            }
        };

    }

}

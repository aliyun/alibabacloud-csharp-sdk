// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class RecolorHDImageRequest : TeaModel {
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("RefUrl")]
        [Validation(Required=false)]
        public string RefUrl { get; set; }

        [NameInMap("ColorCount")]
        [Validation(Required=false)]
        public int? ColorCount { get; set; }

        [NameInMap("Degree")]
        [Validation(Required=false)]
        public string Degree { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("ColorTemplate")]
        [Validation(Required=false)]
        public List<RecolorHDImageRequestColorTemplate> ColorTemplate { get; set; }
        public class RecolorHDImageRequestColorTemplate : TeaModel {
            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

        }

    }

}

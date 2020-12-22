// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class FaceTidyupRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("ShapeType")]
        [Validation(Required=false)]
        public int? ShapeType { get; set; }

        [NameInMap("Strength")]
        [Validation(Required=false)]
        public float? Strength { get; set; }

    }

}

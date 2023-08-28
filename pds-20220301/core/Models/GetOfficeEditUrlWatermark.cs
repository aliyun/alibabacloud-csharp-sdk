// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetOfficeEditUrlWatermark : TeaModel {
        [NameInMap("fillstyle")]
        [Validation(Required=false)]
        public string Fillstyle { get; set; }

        [NameInMap("font")]
        [Validation(Required=false)]
        public string Font { get; set; }

        [NameInMap("horizontal")]
        [Validation(Required=false)]
        public long? Horizontal { get; set; }

        [NameInMap("rotate")]
        [Validation(Required=false)]
        public double? Rotate { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("vertical")]
        [Validation(Required=false)]
        public long? Vertical { get; set; }

    }

}

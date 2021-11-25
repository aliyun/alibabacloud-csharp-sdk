// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetOfficePreviewURLRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SrcType")]
        [Validation(Required=false)]
        public string SrcType { get; set; }

        [NameInMap("SrcUri")]
        [Validation(Required=false)]
        public string SrcUri { get; set; }

        [NameInMap("WatermarkFillStyle")]
        [Validation(Required=false)]
        public string WatermarkFillStyle { get; set; }

        [NameInMap("WatermarkFont")]
        [Validation(Required=false)]
        public string WatermarkFont { get; set; }

        [NameInMap("WatermarkHorizontal")]
        [Validation(Required=false)]
        public int? WatermarkHorizontal { get; set; }

        [NameInMap("WatermarkRotate")]
        [Validation(Required=false)]
        public float? WatermarkRotate { get; set; }

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public int? WatermarkType { get; set; }

        [NameInMap("WatermarkValue")]
        [Validation(Required=false)]
        public string WatermarkValue { get; set; }

        [NameInMap("WatermarkVertical")]
        [Validation(Required=false)]
        public int? WatermarkVertical { get; set; }

    }

}

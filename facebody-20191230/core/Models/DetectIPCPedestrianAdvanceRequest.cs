// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectIPCPedestrianAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("ImageData")]
        [Validation(Required=false)]
        public string ImageData { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}

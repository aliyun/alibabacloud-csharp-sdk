// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class FaceBeautyAdvanceRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("Sharp")]
        [Validation(Required=false)]
        public float? Sharp { get; set; }

        [NameInMap("Smooth")]
        [Validation(Required=false)]
        public float? Smooth { get; set; }

        [NameInMap("White")]
        [Validation(Required=false)]
        public float? White { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class FaceFilterAdvanceRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Strength")]
        [Validation(Required=false)]
        public float? Strength { get; set; }

    }

}

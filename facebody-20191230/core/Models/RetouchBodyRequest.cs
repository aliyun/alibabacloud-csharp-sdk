// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RetouchBodyRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("SlimDegree")]
        [Validation(Required=false)]
        public float? SlimDegree { get; set; }

        [NameInMap("LengthenDegree")]
        [Validation(Required=false)]
        public float? LengthenDegree { get; set; }

    }

}

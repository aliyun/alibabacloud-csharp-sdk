// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class VerifyFaceMaskAdvanceRequest : TeaModel {
        [NameInMap("ImageData")]
        [Validation(Required=false)]
        public byte[] ImageData { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("RefData")]
        [Validation(Required=false)]
        public byte[] RefData { get; set; }

        [NameInMap("RefUrl")]
        [Validation(Required=false)]
        public Stream RefUrlObject { get; set; }

    }

}

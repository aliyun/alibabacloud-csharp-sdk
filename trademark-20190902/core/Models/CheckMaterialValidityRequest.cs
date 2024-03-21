// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class CheckMaterialValidityRequest : TeaModel {
        [NameInMap("BusinessLicenseOssKey")]
        [Validation(Required=false)]
        public string BusinessLicenseOssKey { get; set; }

        [NameInMap("CardNumber")]
        [Validation(Required=false)]
        public string CardNumber { get; set; }

        [NameInMap("IdCardName")]
        [Validation(Required=false)]
        public string IdCardName { get; set; }

        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        [NameInMap("IdCardOssKey")]
        [Validation(Required=false)]
        public string IdCardOssKey { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public long? MaterialId { get; set; }

        [NameInMap("MaterialRegion")]
        [Validation(Required=false)]
        public int? MaterialRegion { get; set; }

        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public int? MaterialType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PersonalType")]
        [Validation(Required=false)]
        public long? PersonalType { get; set; }

    }

}

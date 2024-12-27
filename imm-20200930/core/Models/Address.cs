// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Address : TeaModel {
        [NameInMap("AddressLine")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("District")]
        [Validation(Required=false)]
        public string District { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("Township")]
        [Validation(Required=false)]
        public string Township { get; set; }

    }

}

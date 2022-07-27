// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetSecretParametersRequest : TeaModel {
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("WithDecryption")]
        [Validation(Required=false)]
        public bool? WithDecryption { get; set; }

    }

}

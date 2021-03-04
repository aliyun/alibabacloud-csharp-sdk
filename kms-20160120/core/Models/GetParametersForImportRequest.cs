// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetParametersForImportRequest : TeaModel {
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("WrappingAlgorithm")]
        [Validation(Required=false)]
        public string WrappingAlgorithm { get; set; }

        [NameInMap("WrappingKeySpec")]
        [Validation(Required=false)]
        public string WrappingKeySpec { get; set; }

    }

}

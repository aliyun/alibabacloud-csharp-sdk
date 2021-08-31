// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateSupplierInformationRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OperationIp")]
        [Validation(Required=false)]
        public string OperationIp { get; set; }

        [NameInMap("OperationMfaPresent")]
        [Validation(Required=false)]
        public bool? OperationMfaPresent { get; set; }

    }

}

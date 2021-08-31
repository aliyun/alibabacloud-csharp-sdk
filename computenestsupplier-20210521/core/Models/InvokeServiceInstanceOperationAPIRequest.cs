/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class InvokeServiceInstanceOperationAPIRequest : TeaModel {
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OperationProduct")]
        [Validation(Required=false)]
        public string OperationProduct { get; set; }

        [NameInMap("OperationAction")]
        [Validation(Required=false)]
        public string OperationAction { get; set; }

        [NameInMap("OperationVersion")]
        [Validation(Required=false)]
        public string OperationVersion { get; set; }

        [NameInMap("OperationParameters")]
        [Validation(Required=false)]
        public string OperationParameters { get; set; }

    }

}

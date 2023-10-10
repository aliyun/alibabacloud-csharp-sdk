// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class QuotasValue : TeaModel {
        /// <summary>
        /// The value of the quota. If the quota limit is reached, submit an application in the [Quota Center console](https://quotas.console.aliyun.com/products/csk/quotas) to increase the quota.
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public string Quota { get; set; }

        /// <summary>
        /// The quota code.
        /// </summary>
        [NameInMap("operation_code")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// Indicates whether the quota is adjustable.
        /// </summary>
        [NameInMap("adjustable")]
        [Validation(Required=false)]
        public bool? Adjustable { get; set; }

        /// <summary>
        /// The unit.
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}

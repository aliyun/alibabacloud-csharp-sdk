// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class EvaluateLocalExtendDiskResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the instance is available. Valid values: true and false.
        /// </summary>
        [NameInMap("Available")]
        [Validation(Required=false)]
        public string Available { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The data transfer type supported by the instance.
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public string DBInstanceTransType { get; set; }

        /// <summary>
        /// The maximum value of the local disk. Unit: GB.
        /// </summary>
        [NameInMap("LocalUpgradeDiskLimit")]
        [Validation(Required=false)]
        public long? LocalUpgradeDiskLimit { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

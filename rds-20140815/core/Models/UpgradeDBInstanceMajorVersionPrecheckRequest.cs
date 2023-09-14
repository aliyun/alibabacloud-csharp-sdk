// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceMajorVersionPrecheckRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The new major engine version of the instance. The new major engine version must be later than the original major engine version.
        /// </summary>
        [NameInMap("TargetMajorVersion")]
        [Validation(Required=false)]
        public string TargetMajorVersion { get; set; }

    }

}

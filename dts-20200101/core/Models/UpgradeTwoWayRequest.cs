// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class UpgradeTwoWayRequest : TeaModel {
        /// <summary>
        /// The instance class of the two-way synchronization task. Valid values: **large**, **medium**, **micro**, and **small**.
        /// 
        /// >  For more information, see [Specifications of data synchronization instances](~~26605~~).
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The ID of the data synchronization instance. You can call the [DescribeDtsJobs](~~209702~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the DTS instance. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

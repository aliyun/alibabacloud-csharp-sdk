// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupClientsRequest : TeaModel {
        /// <summary>
        /// The region in which the anti-ransomware feature is supported.
        /// > You can call the [DescribeSupportRegion](~~DescribeSupportRegion~~) operation to query the regions in which the anti-ransomware feature is supported.
        /// </summary>
        [NameInMap("SupportRegionId")]
        [Validation(Required=false)]
        public string SupportRegionId { get; set; }

    }

}

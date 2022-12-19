// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskProgressRequest : TeaModel {
        /// <summary>
        /// The ID of the virus scan task.
        /// 
        /// >  You can call the [StartVirusScanTask](~~StartVirusScanTask~~) operation to query the IDs of virus scan tasks.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}

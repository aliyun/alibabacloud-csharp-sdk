// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class StopSyncMigrationJobRequest : TeaModel {
        [NameInMap("jobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

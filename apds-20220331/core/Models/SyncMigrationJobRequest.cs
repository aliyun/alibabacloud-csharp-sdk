// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class SyncMigrationJobRequest : TeaModel {
        [NameInMap("jobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("operationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

    }

}

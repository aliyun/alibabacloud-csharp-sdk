// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSQLLogTemplatesRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("MinAvgConsume")]
        [Validation(Required=false)]
        public float? MinAvgConsume { get; set; }

        [NameInMap("MaxAvgConsume")]
        [Validation(Required=false)]
        public float? MaxAvgConsume { get; set; }

        [NameInMap("MinAvgScanRows")]
        [Validation(Required=false)]
        public float? MinAvgScanRows { get; set; }

        [NameInMap("MaxAvgScanRows")]
        [Validation(Required=false)]
        public float? MaxAvgScanRows { get; set; }

        [NameInMap("PagingId")]
        [Validation(Required=false)]
        public string PagingId { get; set; }

        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        [NameInMap("SortMethod")]
        [Validation(Required=false)]
        public string SortMethod { get; set; }

        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("ChildDBInstanceIDs")]
        [Validation(Required=false)]
        public string ChildDBInstanceIDs { get; set; }

    }

}

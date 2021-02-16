// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSQLLogRecordsRequest : TeaModel {
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

        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        [NameInMap("SortMethod")]
        [Validation(Required=false)]
        public string SortMethod { get; set; }

        [NameInMap("MinConsume")]
        [Validation(Required=false)]
        public long? MinConsume { get; set; }

        [NameInMap("MaxConsume")]
        [Validation(Required=false)]
        public long? MaxConsume { get; set; }

        [NameInMap("MinScanRows")]
        [Validation(Required=false)]
        public long? MinScanRows { get; set; }

        [NameInMap("MaxScanRows")]
        [Validation(Required=false)]
        public long? MaxScanRows { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("ThreadID")]
        [Validation(Required=false)]
        public string ThreadID { get; set; }

        [NameInMap("PagingID")]
        [Validation(Required=false)]
        public string PagingID { get; set; }

        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        [NameInMap("ChildDBInstanceIDs")]
        [Validation(Required=false)]
        public string ChildDBInstanceIDs { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}

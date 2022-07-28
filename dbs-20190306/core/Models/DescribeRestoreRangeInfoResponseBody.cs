// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreRangeInfoResponseBody : TeaModel {
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeRestoreRangeInfoResponseBodyItems Items { get; set; }
        public class DescribeRestoreRangeInfoResponseBodyItems : TeaModel {
            [NameInMap("DBSRecoverRange")]
            [Validation(Required=false)]
            public List<DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRange> DBSRecoverRange { get; set; }
            public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRange : TeaModel {
                public long? BeginTimestampForRestore { get; set; }
                public long? EndTimestampForRestore { get; set; }
                public DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupList FullBackupList { get; set; }
                public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupList : TeaModel {
                    [NameInMap("FullBackupDetail")]
                    [Validation(Required=false)]
                    public List<DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupListFullBackupDetail> FullBackupDetail { get; set; }
                    public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupListFullBackupDetail : TeaModel {
                        [NameInMap("BackupSetId")]
                        [Validation(Required=false)]
                        public string BackupSetId { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                    }

                }
                public string RangeType { get; set; }
                public string SourceEndpointInstanceID { get; set; }
                public string SourceEndpointInstanceType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

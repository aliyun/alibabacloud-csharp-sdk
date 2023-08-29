// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class PartitionProfile : TeaModel {
        [NameInMap("AccessNum")]
        [Validation(Required=false)]
        public long? AccessNum { get; set; }

        [NameInMap("AccessNumMonthly")]
        [Validation(Required=false)]
        public long? AccessNumMonthly { get; set; }

        [NameInMap("AccessNumWeekly")]
        [Validation(Required=false)]
        public long? AccessNumWeekly { get; set; }

        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("FileCnt")]
        [Validation(Required=false)]
        public long? FileCnt { get; set; }

        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("LastAccessNumTime")]
        [Validation(Required=false)]
        public string LastAccessNumTime { get; set; }

        [NameInMap("LastAccessTime")]
        [Validation(Required=false)]
        public string LastAccessTime { get; set; }

        [NameInMap("LastModifyTime")]
        [Validation(Required=false)]
        public string LastModifyTime { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("ObjectAccessNum")]
        [Validation(Required=false)]
        public long? ObjectAccessNum { get; set; }

        [NameInMap("ObjectAccessNumMonthly")]
        [Validation(Required=false)]
        public long? ObjectAccessNumMonthly { get; set; }

        [NameInMap("ObjectAccessNumWeekly")]
        [Validation(Required=false)]
        public long? ObjectAccessNumWeekly { get; set; }

        [NameInMap("ObjectCnt")]
        [Validation(Required=false)]
        public long? ObjectCnt { get; set; }

        [NameInMap("ObjectSize")]
        [Validation(Required=false)]
        public long? ObjectSize { get; set; }

        [NameInMap("PartitionName")]
        [Validation(Required=false)]
        public string PartitionName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}

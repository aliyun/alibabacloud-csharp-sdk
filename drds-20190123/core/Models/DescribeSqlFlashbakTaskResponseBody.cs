// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeSqlFlashbakTaskResponseBody : TeaModel {
        [NameInMap("SqlFlashbackTasks")]
        [Validation(Required=false)]
        public DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasks SqlFlashbackTasks { get; set; }
        public class DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasks : TeaModel {
            [NameInMap("SqlFlashbackTask")]
            [Validation(Required=false)]
            public List<DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasksSqlFlashbackTask> SqlFlashbackTask { get; set; }
            public class DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasksSqlFlashbackTask : TeaModel {
                public string TableName { get; set; }
                public long? SearchEndTime { get; set; }
                public long? ExpireTime { get; set; }
                public string DownloadUrl { get; set; }
                public int? RecallProgress { get; set; }
                public string InstId { get; set; }
                public string SqlPk { get; set; }
                public int? RecallType { get; set; }
                public long? GmtModified { get; set; }
                public long? SearchStartTime { get; set; }
                public string DbName { get; set; }
                public long? SqlCounter { get; set; }
                public int? RecallRestoreType { get; set; }
                public long? GmtCreate { get; set; }
                public string TraceId { get; set; }
                public long? Id { get; set; }
                public int? RecallStatus { get; set; }
                public string SqlType { get; set; }
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTasksResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTasksResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTasksResponseBodyItems : TeaModel {
            [NameInMap("AllowCancel")]
            [Validation(Required=false)]
            public string AllowCancel { get; set; }

            [NameInMap("AllowChange")]
            [Validation(Required=false)]
            public string AllowChange { get; set; }

            [NameInMap("ChangeLevel")]
            [Validation(Required=false)]
            public string ChangeLevel { get; set; }

            [NameInMap("ChangeLevelEn")]
            [Validation(Required=false)]
            public string ChangeLevelEn { get; set; }

            [NameInMap("ChangeLevelZh")]
            [Validation(Required=false)]
            public string ChangeLevelZh { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("CurrentAVZ")]
            [Validation(Required=false)]
            public string CurrentAVZ { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Impact")]
            [Validation(Required=false)]
            public string Impact { get; set; }

            [NameInMap("ImpactEn")]
            [Validation(Required=false)]
            public string ImpactEn { get; set; }

            [NameInMap("ImpactZh")]
            [Validation(Required=false)]
            public string ImpactZh { get; set; }

            [NameInMap("InsComment")]
            [Validation(Required=false)]
            public string InsComment { get; set; }

            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SubInsNames")]
            [Validation(Required=false)]
            public List<string> SubInsNames { get; set; }

            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("TaskTypeEn")]
            [Validation(Required=false)]
            public string TaskTypeEn { get; set; }

            [NameInMap("TaskTypeZh")]
            [Validation(Required=false)]
            public string TaskTypeZh { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

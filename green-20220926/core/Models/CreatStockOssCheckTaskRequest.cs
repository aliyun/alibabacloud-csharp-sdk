// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreatStockOssCheckTaskRequest : TeaModel {
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        [NameInMap("CallbackId")]
        [Validation(Required=false)]
        public string CallbackId { get; set; }

        [NameInMap("DistinctHistoryTasks")]
        [Validation(Required=false)]
        public bool? DistinctHistoryTasks { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExecuteDate")]
        [Validation(Required=false)]
        public int? ExecuteDate { get; set; }

        [NameInMap("ExecuteTime")]
        [Validation(Required=false)]
        public string ExecuteTime { get; set; }

        [NameInMap("Freeze")]
        [Validation(Required=false)]
        public bool? Freeze { get; set; }

        [NameInMap("FreezeHighRisk1")]
        [Validation(Required=false)]
        public bool? FreezeHighRisk1 { get; set; }

        [NameInMap("FreezeHighRisk2")]
        [Validation(Required=false)]
        public bool? FreezeHighRisk2 { get; set; }

        [NameInMap("FreezeMediumRisk1")]
        [Validation(Required=false)]
        public bool? FreezeMediumRisk1 { get; set; }

        [NameInMap("FreezeMediumRisk2")]
        [Validation(Required=false)]
        public bool? FreezeMediumRisk2 { get; set; }

        [NameInMap("FreezeType")]
        [Validation(Required=false)]
        public string FreezeType { get; set; }

        [NameInMap("IsInc")]
        [Validation(Required=false)]
        public bool? IsInc { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        [NameInMap("PrefixFilterType")]
        [Validation(Required=false)]
        public string PrefixFilterType { get; set; }

        [NameInMap("PrefixFilters")]
        [Validation(Required=false)]
        public string PrefixFilters { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ScanLimit")]
        [Validation(Required=false)]
        public long? ScanLimit { get; set; }

        [NameInMap("ScanNoFileType")]
        [Validation(Required=false)]
        public bool? ScanNoFileType { get; set; }

        [NameInMap("ScanResourceType")]
        [Validation(Required=false)]
        public string ScanResourceType { get; set; }

        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TaskCycle")]
        [Validation(Required=false)]
        public int? TaskCycle { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryOTAJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOTAJobResponseBodyData Data { get; set; }
        public class QueryOTAJobResponseBodyData : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("FirmwareId")]
            [Validation(Required=false)]
            public string FirmwareId { get; set; }
            [NameInMap("UtcStartTime")]
            [Validation(Required=false)]
            public string UtcStartTime { get; set; }
            [NameInMap("UtcEndTime")]
            [Validation(Required=false)]
            public string UtcEndTime { get; set; }
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }
            [NameInMap("JobDesc")]
            [Validation(Required=false)]
            public string JobDesc { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("UtcScheduleTime")]
            [Validation(Required=false)]
            public string UtcScheduleTime { get; set; }
            [NameInMap("RetryInterval")]
            [Validation(Required=false)]
            public int? RetryInterval { get; set; }
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public int? RetryCount { get; set; }
            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }
            [NameInMap("TargetSelection")]
            [Validation(Required=false)]
            public string TargetSelection { get; set; }
            [NameInMap("SelectionType")]
            [Validation(Required=false)]
            public string SelectionType { get; set; }
            [NameInMap("GrayPercent")]
            [Validation(Required=false)]
            public string GrayPercent { get; set; }
            [NameInMap("MaximumPerMinute")]
            [Validation(Required=false)]
            public int? MaximumPerMinute { get; set; }
            [NameInMap("DestVersion")]
            [Validation(Required=false)]
            public string DestVersion { get; set; }
            [NameInMap("UtcScheduleFinishTime")]
            [Validation(Required=false)]
            public string UtcScheduleFinishTime { get; set; }
            [NameInMap("OverwriteMode")]
            [Validation(Required=false)]
            public int? OverwriteMode { get; set; }
            [NameInMap("DynamicMode")]
            [Validation(Required=false)]
            public int? DynamicMode { get; set; }
            [NameInMap("SrcVersions")]
            [Validation(Required=false)]
            public QueryOTAJobResponseBodyDataSrcVersions SrcVersions { get; set; }
            public class QueryOTAJobResponseBodyDataSrcVersions : TeaModel {
                [NameInMap("SrcVersion")]
                [Validation(Required=false)]
                public List<string> SrcVersion { get; set; }

            }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public QueryOTAJobResponseBodyDataTags Tags { get; set; }
            public class QueryOTAJobResponseBodyDataTags : TeaModel {
                [NameInMap("OtaTagDTO")]
                [Validation(Required=false)]
                public List<QueryOTAJobResponseBodyDataTagsOtaTagDTO> OtaTagDTO { get; set; }
                public class QueryOTAJobResponseBodyDataTagsOtaTagDTO : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }
        };

    }

}

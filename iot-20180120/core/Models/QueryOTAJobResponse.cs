// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryOTAJobResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryOTAJobResponseData Data { get; set; }
        public class QueryOTAJobResponseData : TeaModel {
            [NameInMap("DestVersion")]
            [Validation(Required=true)]
            public string DestVersion { get; set; }

            [NameInMap("DownloadProtocol")]
            [Validation(Required=true)]
            public string DownloadProtocol { get; set; }

            [NameInMap("DynamicMode")]
            [Validation(Required=true)]
            public int? DynamicMode { get; set; }

            [NameInMap("FirmwareId")]
            [Validation(Required=true)]
            public string FirmwareId { get; set; }

            [NameInMap("GrayPercent")]
            [Validation(Required=true)]
            public string GrayPercent { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=true)]
            public string GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=true)]
            public string GroupName { get; set; }

            [NameInMap("JobDesc")]
            [Validation(Required=true)]
            public string JobDesc { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=true)]
            public string JobId { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=true)]
            public string JobStatus { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=true)]
            public string JobType { get; set; }

            [NameInMap("MaximumPerMinute")]
            [Validation(Required=true)]
            public int? MaximumPerMinute { get; set; }

            [NameInMap("MultiModuleMode")]
            [Validation(Required=true)]
            public bool? MultiModuleMode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("NeedConfirm")]
            [Validation(Required=true)]
            public bool? NeedConfirm { get; set; }

            [NameInMap("NeedPush")]
            [Validation(Required=true)]
            public bool? NeedPush { get; set; }

            [NameInMap("OverwriteMode")]
            [Validation(Required=true)]
            public int? OverwriteMode { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("RetryCount")]
            [Validation(Required=true)]
            public int? RetryCount { get; set; }

            [NameInMap("RetryInterval")]
            [Validation(Required=true)]
            public int? RetryInterval { get; set; }

            [NameInMap("SelectionType")]
            [Validation(Required=true)]
            public string SelectionType { get; set; }

            [NameInMap("TargetSelection")]
            [Validation(Required=true)]
            public string TargetSelection { get; set; }

            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=true)]
            public int? TimeoutInMinutes { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=true)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcEndTime")]
            [Validation(Required=true)]
            public string UtcEndTime { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=true)]
            public string UtcModified { get; set; }

            [NameInMap("UtcScheduleFinishTime")]
            [Validation(Required=true)]
            public string UtcScheduleFinishTime { get; set; }

            [NameInMap("UtcScheduleTime")]
            [Validation(Required=true)]
            public string UtcScheduleTime { get; set; }

            [NameInMap("UtcStartTime")]
            [Validation(Required=true)]
            public string UtcStartTime { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=true)]
            public QueryOTAJobResponseDataTags Tags { get; set; }
            public class QueryOTAJobResponseDataTags : TeaModel {
                [NameInMap("OtaTagDTO")]
                [Validation(Required=true)]
                public List<QueryOTAJobResponseDataTagsOtaTagDTO> OtaTagDTO { get; set; }
                public class QueryOTAJobResponseDataTagsOtaTagDTO : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=true)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=true)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("SrcVersions")]
            [Validation(Required=true)]
            public QueryOTAJobResponseDataSrcVersions SrcVersions { get; set; }
            public class QueryOTAJobResponseDataSrcVersions : TeaModel {
                /// <summary>
                /// SrcVersion
                /// </summary>
                [NameInMap("SrcVersion")]
                [Validation(Required=true)]
                public List<string> SrcVersion { get; set; }

            }

        }

    }

}

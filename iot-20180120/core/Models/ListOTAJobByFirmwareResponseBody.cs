// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAJobByFirmwareResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTAJobByFirmwareResponseBodyData Data { get; set; }
        public class ListOTAJobByFirmwareResponseBodyData : TeaModel {
            [NameInMap("SimpleOTAJobInfo")]
            [Validation(Required=false)]
            public List<ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfo> SimpleOTAJobInfo { get; set; }
            public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfo : TeaModel {
                [NameInMap("FirmwareId")]
                [Validation(Required=false)]
                public string FirmwareId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("SelectionType")]
                [Validation(Required=false)]
                public string SelectionType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTags Tags { get; set; }
                public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTags : TeaModel {
                    [NameInMap("OtaTagDTO")]
                    [Validation(Required=false)]
                    public List<ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO> OtaTagDTO { get; set; }
                    public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TargetSelection")]
                [Validation(Required=false)]
                public string TargetSelection { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcEndTime")]
                [Validation(Required=false)]
                public string UtcEndTime { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

                [NameInMap("UtcStartTime")]
                [Validation(Required=false)]
                public string UtcStartTime { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAJobByFirmwareResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListOTAJobByFirmwareResponseData Data { get; set; }
        public class ListOTAJobByFirmwareResponseData : TeaModel {
            [NameInMap("SimpleOTAJobInfo")]
            [Validation(Required=true)]
            public List<ListOTAJobByFirmwareResponseDataSimpleOTAJobInfo> SimpleOTAJobInfo { get; set; }
            public class ListOTAJobByFirmwareResponseDataSimpleOTAJobInfo : TeaModel {
                public string JobId { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string ProductKey { get; set; }
                public string FirmwareId { get; set; }
                public string UtcStartTime { get; set; }
                public string UtcEndTime { get; set; }
                public string JobStatus { get; set; }
                public string JobType { get; set; }
                public string TargetSelection { get; set; }
                public string SelectionType { get; set; }
                public ListOTAJobByFirmwareResponseDataSimpleOTAJobInfoTags Tags { get; set; }
                public class ListOTAJobByFirmwareResponseDataSimpleOTAJobInfoTags : TeaModel {
                    [NameInMap("OtaTagDTO")]
                    [Validation(Required=true)]
                    public List<ListOTAJobByFirmwareResponseDataSimpleOTAJobInfoTagsOtaTagDTO> OtaTagDTO { get; set; }
                    public class ListOTAJobByFirmwareResponseDataSimpleOTAJobInfoTagsOtaTagDTO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=true)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=true)]
                        public string Value { get; set; }

                    }

                }
            }
        };

    }

}

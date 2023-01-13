// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAJobByDeviceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListOTAJobByDeviceResponseData Data { get; set; }
        public class ListOTAJobByDeviceResponseData : TeaModel {
            [NameInMap("SimpleOTAJobInfo")]
            [Validation(Required=true)]
            public List<ListOTAJobByDeviceResponseDataSimpleOTAJobInfo> SimpleOTAJobInfo { get; set; }
            public class ListOTAJobByDeviceResponseDataSimpleOTAJobInfo : TeaModel {
                [NameInMap("FirmwareId")]
                [Validation(Required=true)]
                public string FirmwareId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=true)]
                public string JobId { get; set; }

                [NameInMap("JobStatus")]
                [Validation(Required=true)]
                public string JobStatus { get; set; }

                [NameInMap("JobType")]
                [Validation(Required=true)]
                public string JobType { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("SelectionType")]
                [Validation(Required=true)]
                public string SelectionType { get; set; }

                [NameInMap("TargetSelection")]
                [Validation(Required=true)]
                public string TargetSelection { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=true)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcEndTime")]
                [Validation(Required=true)]
                public string UtcEndTime { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=true)]
                public string UtcModified { get; set; }

                [NameInMap("UtcStartTime")]
                [Validation(Required=true)]
                public string UtcStartTime { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=true)]
                public ListOTAJobByDeviceResponseDataSimpleOTAJobInfoTags Tags { get; set; }
                public class ListOTAJobByDeviceResponseDataSimpleOTAJobInfoTags : TeaModel {
                    [NameInMap("OtaTagDTO")]
                    [Validation(Required=true)]
                    public List<ListOTAJobByDeviceResponseDataSimpleOTAJobInfoTagsOtaTagDTO> OtaTagDTO { get; set; }
                    public class ListOTAJobByDeviceResponseDataSimpleOTAJobInfoTagsOtaTagDTO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=true)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=true)]
                        public string Value { get; set; }

                    }

                }

            }

        }

    }

}

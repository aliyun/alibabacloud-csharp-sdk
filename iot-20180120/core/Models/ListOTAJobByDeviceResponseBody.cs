// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAJobByDeviceResponseBody : TeaModel {
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

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTAJobByDeviceResponseBodyData Data { get; set; }
        public class ListOTAJobByDeviceResponseBodyData : TeaModel {
            [NameInMap("SimpleOTAJobInfo")]
            [Validation(Required=false)]
            public List<ListOTAJobByDeviceResponseBodyDataSimpleOTAJobInfo> SimpleOTAJobInfo { get; set; }
            public class ListOTAJobByDeviceResponseBodyDataSimpleOTAJobInfo : TeaModel {
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
                public ListOTAJobByDeviceResponseBodyDataSimpleOTAJobInfoTags Tags { get; set; }
                public class ListOTAJobByDeviceResponseBodyDataSimpleOTAJobInfoTags : TeaModel {
                    [NameInMap("OtaTagDTO")]
                    [Validation(Required=false)]
                    public List<ListOTAJobByDeviceResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO> OtaTagDTO { get; set; }
                    public class ListOTAJobByDeviceResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

    }

}

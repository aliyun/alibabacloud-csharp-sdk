// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryJobResponse : TeaModel {
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

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryJobResponseData Data { get; set; }
        public class QueryJobResponseData : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=true)]
            public string JobId { get; set; }
            [NameInMap("JobName")]
            [Validation(Required=true)]
            public string JobName { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=true)]
            public string UtcCreate { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }
            [NameInMap("JobDocument")]
            [Validation(Required=true)]
            public string JobDocument { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=true)]
            public string UtcModified { get; set; }
            [NameInMap("RolloutConfig")]
            [Validation(Required=true)]
            public QueryJobResponseDataRolloutConfig RolloutConfig { get; set; }
            public class QueryJobResponseDataRolloutConfig : TeaModel {
                [NameInMap("MaximumPerMinute")]
                [Validation(Required=true)]
                public int? MaximumPerMinute { get; set; }

            }
            [NameInMap("TimeoutConfig")]
            [Validation(Required=true)]
            public QueryJobResponseDataTimeoutConfig TimeoutConfig { get; set; }
            public class QueryJobResponseDataTimeoutConfig : TeaModel {
                [NameInMap("InProgressTimeoutInMinutes")]
                [Validation(Required=true)]
                public int? InProgressTimeoutInMinutes { get; set; }

            }
            [NameInMap("JobFile")]
            [Validation(Required=true)]
            public QueryJobResponseDataJobFile JobFile { get; set; }
            public class QueryJobResponseDataJobFile : TeaModel {
                [NameInMap("FileUrl")]
                [Validation(Required=true)]
                public string FileUrl { get; set; }

                [NameInMap("SignMethod")]
                [Validation(Required=true)]
                public string SignMethod { get; set; }

                [NameInMap("Sign")]
                [Validation(Required=true)]
                public string Sign { get; set; }

            }
            [NameInMap("TargetConfig")]
            [Validation(Required=true)]
            public QueryJobResponseDataTargetConfig TargetConfig { get; set; }
            public class QueryJobResponseDataTargetConfig : TeaModel {
                [NameInMap("TargetGroup")]
                [Validation(Required=true)]
                public string TargetGroup { get; set; }

                [NameInMap("TargetProduct")]
                [Validation(Required=true)]
                public string TargetProduct { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=true)]
                public string TargetType { get; set; }

                [NameInMap("TargetDevices")]
                [Validation(Required=true)]
                public QueryJobResponseDataTargetConfigTargetDevices TargetDevices { get; set; }
                public class QueryJobResponseDataTargetConfigTargetDevices : TeaModel {
                    [NameInMap("targetDevices")]
                    [Validation(Required=true)]
                    public List<QueryJobResponseDataTargetConfigTargetDevicesTargetDevices> TargetDevices { get; set; }
                    public class QueryJobResponseDataTargetConfigTargetDevicesTargetDevices : TeaModel {
                        public string ProductKey { get; set; }
                        public string DeviceName { get; set; }
                    }
                };

            }
        };

    }

}

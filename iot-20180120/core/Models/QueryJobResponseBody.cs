// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryJobResponseBodyData Data { get; set; }
        public class QueryJobResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("JobDocument")]
            [Validation(Required=false)]
            public string JobDocument { get; set; }
            [NameInMap("JobFile")]
            [Validation(Required=false)]
            public QueryJobResponseBodyDataJobFile JobFile { get; set; }
            public class QueryJobResponseBodyDataJobFile : TeaModel {
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                [NameInMap("SignMethod")]
                [Validation(Required=false)]
                public string SignMethod { get; set; }

            }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }
            [NameInMap("RolloutConfig")]
            [Validation(Required=false)]
            public QueryJobResponseBodyDataRolloutConfig RolloutConfig { get; set; }
            public class QueryJobResponseBodyDataRolloutConfig : TeaModel {
                [NameInMap("MaximumPerMinute")]
                [Validation(Required=false)]
                public int? MaximumPerMinute { get; set; }

                [NameInMap("MessageQoS")]
                [Validation(Required=false)]
                public string MessageQoS { get; set; }

            }
            [NameInMap("ScheduledTime")]
            [Validation(Required=false)]
            public long? ScheduledTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TargetConfig")]
            [Validation(Required=false)]
            public QueryJobResponseBodyDataTargetConfig TargetConfig { get; set; }
            public class QueryJobResponseBodyDataTargetConfig : TeaModel {
                [NameInMap("TargetDevices")]
                [Validation(Required=false)]
                public QueryJobResponseBodyDataTargetConfigTargetDevices TargetDevices { get; set; }
                public class QueryJobResponseBodyDataTargetConfigTargetDevices : TeaModel {
                    [NameInMap("targetDevices")]
                    [Validation(Required=false)]
                    public List<QueryJobResponseBodyDataTargetConfigTargetDevicesTargetDevices> TargetDevices { get; set; }
                    public class QueryJobResponseBodyDataTargetConfigTargetDevicesTargetDevices : TeaModel {
                        public string DeviceName { get; set; }
                        public string ProductKey { get; set; }
                    }
                };

                [NameInMap("TargetGroup")]
                [Validation(Required=false)]
                public string TargetGroup { get; set; }

                [NameInMap("TargetProduct")]
                [Validation(Required=false)]
                public string TargetProduct { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }
            [NameInMap("TimeoutConfig")]
            [Validation(Required=false)]
            public QueryJobResponseBodyDataTimeoutConfig TimeoutConfig { get; set; }
            public class QueryJobResponseBodyDataTimeoutConfig : TeaModel {
                [NameInMap("InProgressTimeoutInMinutes")]
                [Validation(Required=false)]
                public int? InProgressTimeoutInMinutes { get; set; }

            }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

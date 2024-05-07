// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetStatisticsRecordsByFeeIdResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetStatisticsRecordsByFeeIdResponseBodyData> Data { get; set; }
        public class GetStatisticsRecordsByFeeIdResponseBodyData : TeaModel {
            /// <summary>
            /// appid
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("BeginAt")]
            [Validation(Required=false)]
            public string BeginAt { get; set; }

            [NameInMap("ChargeDuration")]
            [Validation(Required=false)]
            public int? ChargeDuration { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            [NameInMap("DetectionDuration")]
            [Validation(Required=false)]
            public int? DetectionDuration { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public int? DeviceType { get; set; }

            [NameInMap("EndAt")]
            [Validation(Required=false)]
            public string EndAt { get; set; }

            [NameInMap("FeeId")]
            [Validation(Required=false)]
            public string FeeId { get; set; }

            [NameInMap("Hour")]
            [Validation(Required=false)]
            public int? Hour { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<GetStatisticsRecordsByFeeIdResponseBodyErrors> Errors { get; set; }
        public class GetStatisticsRecordsByFeeIdResponseBodyErrors : TeaModel {
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

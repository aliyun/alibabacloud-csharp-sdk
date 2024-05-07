// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class UploadReportResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadReportResponseBodyData Data { get; set; }
        public class UploadReportResponseBodyData : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("MetaUrl")]
            [Validation(Required=false)]
            public string MetaUrl { get; set; }

            [NameInMap("OuterBusinessId")]
            [Validation(Required=false)]
            public string OuterBusinessId { get; set; }

            [NameInMap("RecordAt")]
            [Validation(Required=false)]
            public string RecordAt { get; set; }

            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

            [NameInMap("RtcRecordId")]
            [Validation(Required=false)]
            public string RtcRecordId { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<UploadReportResponseBodyErrors> Errors { get; set; }
        public class UploadReportResponseBodyErrors : TeaModel {
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

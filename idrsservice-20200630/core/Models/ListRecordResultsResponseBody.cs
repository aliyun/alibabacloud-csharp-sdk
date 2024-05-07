// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListRecordResultsResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRecordResultsResponseBodyData Data { get; set; }
        public class ListRecordResultsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListRecordResultsResponseBodyDataItems> Items { get; set; }
            public class ListRecordResultsResponseBodyDataItems : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("DepartmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("DetectProcessName")]
                [Validation(Required=false)]
                public string DetectProcessName { get; set; }

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

                [NameInMap("RoomId")]
                [Validation(Required=false)]
                public string RoomId { get; set; }

                [NameInMap("RtcRecordId")]
                [Validation(Required=false)]
                public string RtcRecordId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<ListRecordResultsResponseBodyErrors> Errors { get; set; }
        public class ListRecordResultsResponseBodyErrors : TeaModel {
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

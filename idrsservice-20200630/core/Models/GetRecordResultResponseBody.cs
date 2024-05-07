// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetRecordResultResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRecordResultResponseBodyData Data { get; set; }
        public class GetRecordResultResponseBodyData : TeaModel {
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

            [NameInMap("RecordRoomList")]
            [Validation(Required=false)]
            public List<GetRecordResultResponseBodyDataRecordRoomList> RecordRoomList { get; set; }
            public class GetRecordResultResponseBodyDataRecordRoomList : TeaModel {
                [NameInMap("OuterBusinessId")]
                [Validation(Required=false)]
                public string OuterBusinessId { get; set; }

                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("RoomMetaUrl")]
                [Validation(Required=false)]
                public string RoomMetaUrl { get; set; }

                [NameInMap("RoomRecordAt")]
                [Validation(Required=false)]
                public string RoomRecordAt { get; set; }

                [NameInMap("RoomResultUrl")]
                [Validation(Required=false)]
                public string RoomResultUrl { get; set; }

                [NameInMap("RoomStatus")]
                [Validation(Required=false)]
                public string RoomStatus { get; set; }

                [NameInMap("RoomVideoUrl")]
                [Validation(Required=false)]
                public string RoomVideoUrl { get; set; }

                [NameInMap("RtcRecordId")]
                [Validation(Required=false)]
                public string RtcRecordId { get; set; }

            }

            [NameInMap("ResultUrl")]
            [Validation(Required=false)]
            public string ResultUrl { get; set; }

            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<GetRecordResultResponseBodyErrors> Errors { get; set; }
        public class GetRecordResultResponseBodyErrors : TeaModel {
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

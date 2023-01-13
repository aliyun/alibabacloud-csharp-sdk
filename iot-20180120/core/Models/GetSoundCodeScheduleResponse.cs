// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetSoundCodeScheduleResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetSoundCodeScheduleResponseData Data { get; set; }
        public class GetSoundCodeScheduleResponseData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=true)]
            public string EndDate { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public string EndTime { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("OpenType")]
            [Validation(Required=true)]
            public string OpenType { get; set; }

            [NameInMap("ScheduleCode")]
            [Validation(Required=true)]
            public string ScheduleCode { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=true)]
            public string StartDate { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

        }

    }

}

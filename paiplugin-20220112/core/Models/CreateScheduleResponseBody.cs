// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateScheduleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateScheduleResponseBodyData Data { get; set; }
        public class CreateScheduleResponseBodyData : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public string ExecuteTime { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RepeatCycle")]
            [Validation(Required=false)]
            public int? RepeatCycle { get; set; }

            [NameInMap("RepeatCycleUnit")]
            [Validation(Required=false)]
            public int? RepeatCycleUnit { get; set; }

            [NameInMap("RepeatTimes")]
            [Validation(Required=false)]
            public int? RepeatTimes { get; set; }

            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            [NameInMap("SignatureId")]
            [Validation(Required=false)]
            public string SignatureId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

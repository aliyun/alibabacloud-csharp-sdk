// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateScheduleRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("ExecuteTime")]
        [Validation(Required=false)]
        public string ExecuteTime { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}

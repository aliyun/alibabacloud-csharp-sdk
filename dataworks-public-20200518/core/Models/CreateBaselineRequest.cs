// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateBaselineRequest : TeaModel {
        [NameInMap("AlertMarginThreshold")]
        [Validation(Required=false)]
        public int? AlertMarginThreshold { get; set; }

        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        [NameInMap("BaselineType")]
        [Validation(Required=false)]
        public string BaselineType { get; set; }

        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        [NameInMap("OvertimeSettings")]
        [Validation(Required=false)]
        public List<CreateBaselineRequestOvertimeSettings> OvertimeSettings { get; set; }
        public class CreateBaselineRequestOvertimeSettings : TeaModel {
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public int? Cycle { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}

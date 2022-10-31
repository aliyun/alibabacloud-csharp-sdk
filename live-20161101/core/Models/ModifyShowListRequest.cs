// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyShowListRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("HighPriorityShowId")]
        [Validation(Required=false)]
        public string HighPriorityShowId { get; set; }

        [NameInMap("HighPriorityShowStartTime")]
        [Validation(Required=false)]
        public string HighPriorityShowStartTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public int? RepeatTimes { get; set; }

        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        [NameInMap("Spot")]
        [Validation(Required=false)]
        public int? Spot { get; set; }

    }

}

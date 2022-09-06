// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveBaseStrategyPeriodRequest : TeaModel {
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        [NameInMap("OnlyWeekdays")]
        [Validation(Required=false)]
        public bool? OnlyWeekdays { get; set; }

        [NameInMap("StrategyLevel")]
        [Validation(Required=false)]
        public int? StrategyLevel { get; set; }

        [NameInMap("WorkingTime")]
        [Validation(Required=false)]
        public List<string> WorkingTime { get; set; }

        [NameInMap("WorkingTimeFramesJson")]
        [Validation(Required=false)]
        public string WorkingTimeFramesJson { get; set; }

    }

}

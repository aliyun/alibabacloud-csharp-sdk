// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EventPattern")]
        [Validation(Required=false)]
        public List<PutEventRuleRequestEventPattern> EventPattern { get; set; }
        public class PutEventRuleRequestEventPattern : TeaModel {
            [NameInMap("CustomFilters")]
            [Validation(Required=false)]
            public string CustomFilters { get; set; }

            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public List<string> EventTypeList { get; set; }

            [NameInMap("LevelList")]
            [Validation(Required=false)]
            public List<string> LevelList { get; set; }

            [NameInMap("NameList")]
            [Validation(Required=false)]
            public List<string> NameList { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("SQLFilter")]
            [Validation(Required=false)]
            public string SQLFilter { get; set; }

            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

        }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}

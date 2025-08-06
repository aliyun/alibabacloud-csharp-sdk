// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListIntelligentStrategyResponseBody : TeaModel {
        [NameInMap("IntelligentStrategyList")]
        [Validation(Required=false)]
        public List<ListIntelligentStrategyResponseBodyIntelligentStrategyList> IntelligentStrategyList { get; set; }
        public class ListIntelligentStrategyResponseBodyIntelligentStrategyList : TeaModel {
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public string Conditions { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("ExecuteParams")]
            [Validation(Required=false)]
            public string ExecuteParams { get; set; }

            [NameInMap("MatchLimit")]
            [Validation(Required=false)]
            public long? MatchLimit { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

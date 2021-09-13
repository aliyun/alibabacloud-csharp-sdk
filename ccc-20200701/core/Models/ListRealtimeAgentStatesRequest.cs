// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRealtimeAgentStatesRequest : TeaModel {
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AgentIdList")]
        [Validation(Required=false)]
        public string AgentIdList { get; set; }

        [NameInMap("StateList")]
        [Validation(Required=false)]
        public string StateList { get; set; }

        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

    }

}

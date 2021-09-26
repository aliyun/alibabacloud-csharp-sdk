// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetAgentListRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AgentIp")]
        [Validation(Required=false)]
        public string AgentIp { get; set; }

        [NameInMap("AgentStatus")]
        [Validation(Required=false)]
        public int? AgentStatus { get; set; }

        [NameInMap("AgentOs")]
        [Validation(Required=false)]
        public string AgentOs { get; set; }

    }

}

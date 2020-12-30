// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifyAgentDeviceRequest : TeaModel {
        [NameInMap("IsLogin")]
        [Validation(Required=false)]
        public int? IsLogin { get; set; }

        [NameInMap("AgentDeviceId")]
        [Validation(Required=false)]
        public long? AgentDeviceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ConnectorProperties : TeaModel {
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        [NameInMap("dryRunRequestBody")]
        [Validation(Required=false)]
        public string DryRunRequestBody { get; set; }

        [NameInMap("modelList")]
        [Validation(Required=false)]
        public string ModelList { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("responseBodyPath")]
        [Validation(Required=false)]
        public string ResponseBodyPath { get; set; }

        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

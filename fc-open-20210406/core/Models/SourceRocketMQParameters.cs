// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class SourceRocketMQParameters : TeaModel {
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("FilterSql")]
        [Validation(Required=false)]
        public string FilterSql { get; set; }

        [NameInMap("FilterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        [NameInMap("GroupID")]
        [Validation(Required=false)]
        public string GroupID { get; set; }

        [NameInMap("InstanceEndpoint")]
        [Validation(Required=false)]
        public string InstanceEndpoint { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceNetwork")]
        [Validation(Required=false)]
        public string InstanceNetwork { get; set; }

        [NameInMap("InstancePassword")]
        [Validation(Required=false)]
        public string InstancePassword { get; set; }

        [NameInMap("InstanceSecurityGroupId")]
        [Validation(Required=false)]
        public string InstanceSecurityGroupId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InstanceUsername")]
        [Validation(Required=false)]
        public string InstanceUsername { get; set; }

        [NameInMap("InstanceVSwitchIds")]
        [Validation(Required=false)]
        public string InstanceVSwitchIds { get; set; }

        [NameInMap("InstanceVpcId")]
        [Validation(Required=false)]
        public string InstanceVpcId { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

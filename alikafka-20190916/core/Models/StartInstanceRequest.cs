// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class StartInstanceRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("DeployModule")]
        [Validation(Required=false)]
        public string DeployModule { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("IsEipInner")]
        [Validation(Required=false)]
        public bool? IsEipInner { get; set; }

        [NameInMap("IsSetUserAndPassword")]
        [Validation(Required=false)]
        public bool? IsSetUserAndPassword { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("CrossZone")]
        [Validation(Required=false)]
        public bool? CrossZone { get; set; }

        [NameInMap("SecurityGroup")]
        [Validation(Required=false)]
        public string SecurityGroup { get; set; }

    }

}

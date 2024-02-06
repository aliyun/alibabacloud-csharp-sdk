// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeploySDGRequest : TeaModel {
        [NameInMap("DeploymentType")]
        [Validation(Required=false)]
        public string DeploymentType { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}

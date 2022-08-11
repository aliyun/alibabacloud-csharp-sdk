// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyPolicyInstanceRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}

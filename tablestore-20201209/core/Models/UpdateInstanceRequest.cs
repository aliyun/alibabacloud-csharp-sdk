// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

    }

}

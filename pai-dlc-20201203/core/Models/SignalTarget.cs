// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SignalTarget : TeaModel {
        [NameInMap("PodNames")]
        [Validation(Required=false)]
        public List<string> PodNames { get; set; }

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<string> Roles { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}

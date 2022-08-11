// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateEdgeMachineRequest : TeaModel {
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}

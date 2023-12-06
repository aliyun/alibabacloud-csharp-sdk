// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ExportPort : TeaModel {
        [NameInMap("cidrIP")]
        [Validation(Required=false)]
        public string CidrIP { get; set; }

        [NameInMap("portRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("unallowed")]
        [Validation(Required=false)]
        public bool? Unallowed { get; set; }

    }

}

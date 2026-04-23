// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class MetaAgentPreCheckParam : TeaModel {
        [NameInMap("DbIds")]
        [Validation(Required=false)]
        public string DbIds { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("Supplement")]
        [Validation(Required=false)]
        public string Supplement { get; set; }

        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public string TableNames { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ABTestExperiment : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("online")]
        [Validation(Required=false)]
        public bool? Online { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        [NameInMap("serialNumber")]
        [Validation(Required=false)]
        public int? SerialNumber { get; set; }

        [NameInMap("traffic")]
        [Validation(Required=false)]
        public int? Traffic { get; set; }

    }

}

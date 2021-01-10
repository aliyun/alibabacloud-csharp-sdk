// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceMountRequest : TeaModel {
        [NameInMap("DomainsRepeatList")]
        [Validation(Required=false)]
        public List<string> DomainsRepeatList { get; set; }

        [NameInMap("LoadbalanceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> LoadbalanceIdsRepeatList { get; set; }

        [NameInMap("Mounted")]
        [Validation(Required=false)]
        public bool? Mounted { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

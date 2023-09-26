// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EttrafficIsp20230830.Models
{
    public class AkListPageRequest : TeaModel {
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}

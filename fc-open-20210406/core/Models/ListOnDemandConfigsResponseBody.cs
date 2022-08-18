// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListOnDemandConfigsResponseBody : TeaModel {
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<OnDemandConfig> Configs { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

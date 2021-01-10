// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class GetAIActionConfigRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("Algo")]
        [Validation(Required=false)]
        public string Algo { get; set; }

        [NameInMap("AlgoAction")]
        [Validation(Required=false)]
        public string AlgoAction { get; set; }

    }

}

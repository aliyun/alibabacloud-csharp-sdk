// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetChangeLogRequest : TeaModel {
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> TargetIds { get; set; }

        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

    }

}

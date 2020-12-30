// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class ApproveJoinCompanyRequest : TeaModel {
        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public string ApplicationIds { get; set; }

    }

}

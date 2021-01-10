// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutIterationsupdateiterationpersonsRequest : TeaModel {
        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("IterationManager")]
        [Validation(Required=false)]
        public string IterationManager { get; set; }

        [NameInMap("PrePubOwner")]
        [Validation(Required=false)]
        public string PrePubOwner { get; set; }

        [NameInMap("TestOwner")]
        [Validation(Required=false)]
        public string TestOwner { get; set; }

    }

}

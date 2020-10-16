// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetPersonDetailRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("PersonID")]
        [Validation(Required=false)]
        public string PersonID { get; set; }

        [NameInMap("AlgorithmType")]
        [Validation(Required=false)]
        public string AlgorithmType { get; set; }

    }

}

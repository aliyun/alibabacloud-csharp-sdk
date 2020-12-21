// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class BindPersonRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=false)]
        public string IsvSubId { get; set; }

        [NameInMap("PersonMatchingRate")]
        [Validation(Required=false)]
        public string PersonMatchingRate { get; set; }

        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public string PersonId { get; set; }

        [NameInMap("ProfileId")]
        [Validation(Required=false)]
        public long ProfileId { get; set; }

    }

}

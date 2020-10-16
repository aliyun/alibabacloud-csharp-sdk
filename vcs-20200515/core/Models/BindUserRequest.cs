// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class BindUserRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=true)]
        public string IsvSubId { get; set; }

        [NameInMap("MatchingRate")]
        [Validation(Required=true)]
        public string MatchingRate { get; set; }

        [NameInMap("PersonId")]
        [Validation(Required=true)]
        public string PersonId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=true)]
        public long UserId { get; set; }

    }

}

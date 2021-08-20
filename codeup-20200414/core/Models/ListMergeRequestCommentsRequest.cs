// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListMergeRequestCommentsRequest : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("FromCommit")]
        [Validation(Required=false)]
        public string FromCommit { get; set; }

        [NameInMap("ToCommit")]
        [Validation(Required=false)]
        public string ToCommit { get; set; }

    }

}

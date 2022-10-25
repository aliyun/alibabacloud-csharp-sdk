// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class CreateBranchRequest : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public string SubUserId { get; set; }

        [NameInMap("branchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("ref")]
        [Validation(Required=false)]
        public string Ref { get; set; }

    }

}

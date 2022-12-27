// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListOrganizationsRequest : TeaModel {
        [NameInMap("accessLevel")]
        [Validation(Required=false)]
        public int? AccessLevel { get; set; }

        [NameInMap("minAccessLevel")]
        [Validation(Required=false)]
        public int? MinAccessLevel { get; set; }

    }

}

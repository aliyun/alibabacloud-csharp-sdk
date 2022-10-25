// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListOrganizationsRequest : TeaModel {
        [NameInMap("AccessLevel")]
        [Validation(Required=false)]
        public int? AccessLevel { get; set; }

        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("MinAccessLevel")]
        [Validation(Required=false)]
        public int? MinAccessLevel { get; set; }

    }

}

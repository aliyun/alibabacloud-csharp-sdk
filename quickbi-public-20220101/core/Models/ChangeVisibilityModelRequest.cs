// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ChangeVisibilityModelRequest : TeaModel {
        [NameInMap("DataPortalId")]
        [Validation(Required=false)]
        public string DataPortalId { get; set; }

        [NameInMap("MenuIds")]
        [Validation(Required=false)]
        public string MenuIds { get; set; }

        [NameInMap("ShowOnlyWithAccess")]
        [Validation(Required=false)]
        public bool? ShowOnlyWithAccess { get; set; }

    }

}

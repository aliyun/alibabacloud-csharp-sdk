// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListFoundationComponentVersionsRequest : TeaModel {
        [NameInMap("onlyEnabled")]
        [Validation(Required=false)]
        public bool? OnlyEnabled { get; set; }

        [NameInMap("parentComponentRelationUID")]
        [Validation(Required=false)]
        public string ParentComponentRelationUID { get; set; }

    }

}

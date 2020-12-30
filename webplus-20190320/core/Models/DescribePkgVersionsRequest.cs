// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribePkgVersionsRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PkgVersionLabel")]
        [Validation(Required=false)]
        public string PkgVersionLabel { get; set; }

        [NameInMap("PkgVersionSearch")]
        [Validation(Required=false)]
        public string PkgVersionSearch { get; set; }

    }

}

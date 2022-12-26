// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetImportantRequest : TeaModel {
        [NameInMap("ImportantCode")]
        [Validation(Required=false)]
        public int? ImportantCode { get; set; }

        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}

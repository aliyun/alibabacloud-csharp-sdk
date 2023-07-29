// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetCleanConfigRequest : TeaModel {
        [NameInMap("AssetCleanConfigs")]
        [Validation(Required=false)]
        public List<ModifyAssetCleanConfigRequestAssetCleanConfigs> AssetCleanConfigs { get; set; }
        public class ModifyAssetCleanConfigRequestAssetCleanConfigs : TeaModel {
            [NameInMap("CleanDays")]
            [Validation(Required=false)]
            public int? CleanDays { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class CheckUpgradeVersionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        [NameInMap("Patches")]
        [Validation(Required=false)]
        public CheckUpgradeVersionResponseBodyPatches Patches { get; set; }
        public class CheckUpgradeVersionResponseBodyPatches : TeaModel {
            [NameInMap("Patch")]
            [Validation(Required=false)]
            public List<CheckUpgradeVersionResponseBodyPatchesPatch> Patch { get; set; }
            public class CheckUpgradeVersionResponseBodyPatchesPatch : TeaModel {
                public string InternalUrl { get; set; }
                public string MD5 { get; set; }
                public string Name { get; set; }
                public string Url { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

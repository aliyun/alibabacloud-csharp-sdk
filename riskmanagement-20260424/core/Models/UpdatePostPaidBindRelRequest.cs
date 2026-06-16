// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class UpdatePostPaidBindRelRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public UpdatePostPaidBindRelRequestSdkRequest SdkRequest { get; set; }
        public class UpdatePostPaidBindRelRequestSdkRequest : TeaModel {
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            [NameInMap("AutoBindVersion")]
            [Validation(Required=false)]
            public int? AutoBindVersion { get; set; }

            [NameInMap("BindAction")]
            [Validation(Required=false)]
            public List<UpdatePostPaidBindRelRequestSdkRequestBindAction> BindAction { get; set; }
            public class UpdatePostPaidBindRelRequestSdkRequestBindAction : TeaModel {
                [NameInMap("BindAll")]
                [Validation(Required=false)]
                public bool? BindAll { get; set; }

                [NameInMap("UuidList")]
                [Validation(Required=false)]
                public List<string> UuidList { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("UpdateIfNecessary")]
            [Validation(Required=false)]
            public bool? UpdateIfNecessary { get; set; }

        }

    }

}

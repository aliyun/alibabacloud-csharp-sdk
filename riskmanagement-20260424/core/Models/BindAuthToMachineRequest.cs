// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class BindAuthToMachineRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public BindAuthToMachineRequestSdkRequest SdkRequest { get; set; }
        public class BindAuthToMachineRequestSdkRequest : TeaModel {
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            [NameInMap("Bind")]
            [Validation(Required=false)]
            public List<string> Bind { get; set; }

            [NameInMap("BindAll")]
            [Validation(Required=false)]
            public bool? BindAll { get; set; }

            [NameInMap("Criteria")]
            [Validation(Required=false)]
            public string Criteria { get; set; }

            [NameInMap("IsPreBind")]
            [Validation(Required=false)]
            public int? IsPreBind { get; set; }

            [NameInMap("LogicalExp")]
            [Validation(Required=false)]
            public string LogicalExp { get; set; }

            [NameInMap("NtmVersion")]
            [Validation(Required=false)]
            public long? NtmVersion { get; set; }

            [NameInMap("PreBindOrderId")]
            [Validation(Required=false)]
            public long? PreBindOrderId { get; set; }

            [NameInMap("UnBind")]
            [Validation(Required=false)]
            public List<string> UnBind { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMsGuardianAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("GuardianApp")]
        [Validation(Required=false)]
        public GetMsGuardianAppsResponseBodyGuardianApp GuardianApp { get; set; }
        public class GetMsGuardianAppsResponseBodyGuardianApp : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }
        };

    }

}

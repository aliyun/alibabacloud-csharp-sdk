// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaPendingDesktopsResponseBody : TeaModel {
        [NameInMap("FotaPendingDesktops")]
        [Validation(Required=false)]
        public List<DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops> FotaPendingDesktops { get; set; }
        public class DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops : TeaModel {
            [NameInMap("CurrentAppVersion")]
            [Validation(Required=false)]
            public string CurrentAppVersion { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

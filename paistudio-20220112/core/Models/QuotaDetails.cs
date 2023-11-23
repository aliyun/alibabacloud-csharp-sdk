// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaDetails : TeaModel {
        [NameInMap("ActualMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount ActualMinQuota { get; set; }

        [NameInMap("DesiredMinQuota")]
        [Validation(Required=false)]
        public ResourceAmount DesiredMinQuota { get; set; }

        [NameInMap("RequestedQuota")]
        [Validation(Required=false)]
        public ResourceAmount RequestedQuota { get; set; }

        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public ResourceAmount UsedQuota { get; set; }

    }

}

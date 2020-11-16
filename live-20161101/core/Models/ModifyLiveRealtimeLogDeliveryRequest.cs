// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveRealtimeLogDeliveryRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=true)]
        public string Project { get; set; }

        [NameInMap("Logstore")]
        [Validation(Required=true)]
        public string Logstore { get; set; }

        [NameInMap("Region")]
        [Validation(Required=true)]
        public string Region { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

    }

}

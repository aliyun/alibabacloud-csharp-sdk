// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class DescribeEventsRequest : TeaModel {
        [NameInMap("CreateEndDate")]
        [Validation(Required=false)]
        public long? CreateEndDate { get; set; }

        [NameInMap("CreateStartDate")]
        [Validation(Required=false)]
        public long? CreateStartDate { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EventAffiliation")]
        [Validation(Required=false)]
        public int? EventAffiliation { get; set; }

        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public int? EventLevel { get; set; }

        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public int? EventStatus { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public int? EventType { get; set; }

        [NameInMap("HandleEndDate")]
        [Validation(Required=false)]
        public long? HandleEndDate { get; set; }

        [NameInMap("HandleStartDate")]
        [Validation(Required=false)]
        public long? HandleStartDate { get; set; }

        [NameInMap("HandleType")]
        [Validation(Required=false)]
        public int? HandleType { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PropertyName")]
        [Validation(Required=false)]
        public string PropertyName { get; set; }

        [NameInMap("PropertyPrivateIp")]
        [Validation(Required=false)]
        public string PropertyPrivateIp { get; set; }

        [NameInMap("PropertyPublicIp")]
        [Validation(Required=false)]
        public string PropertyPublicIp { get; set; }

        [NameInMap("PropertyUuid")]
        [Validation(Required=false)]
        public string PropertyUuid { get; set; }

        [NameInMap("Suspect")]
        [Validation(Required=false)]
        public string Suspect { get; set; }

        [NameInMap("SuspectSig")]
        [Validation(Required=false)]
        public string SuspectSig { get; set; }

    }

}

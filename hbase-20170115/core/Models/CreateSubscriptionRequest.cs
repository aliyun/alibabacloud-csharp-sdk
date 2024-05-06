// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class CreateSubscriptionRequest : TeaModel {
        [NameInMap("DestinationInstanceId")]
        [Validation(Required=false)]
        public string DestinationInstanceId { get; set; }

        [NameInMap("DestinationInstanceRegionId")]
        [Validation(Required=false)]
        public string DestinationInstanceRegionId { get; set; }

        [NameInMap("ExtraContext")]
        [Validation(Required=false)]
        public string ExtraContext { get; set; }

        [NameInMap("Mapping")]
        [Validation(Required=false)]
        public string Mapping { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SlbServer")]
        [Validation(Required=false)]
        public string SlbServer { get; set; }

        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        [NameInMap("SourceInstanceRegionId")]
        [Validation(Required=false)]
        public string SourceInstanceRegionId { get; set; }

        [NameInMap("SubscriptionDescription")]
        [Validation(Required=false)]
        public string SubscriptionDescription { get; set; }

        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ReleaseInstanceRequest : TeaModel {
        /// <summary>
        /// instanceIds
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// ownerId
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// productCode
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// productType
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// region
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// renewStatus
        /// </summary>
        [NameInMap("RenewStatus")]
        [Validation(Required=false)]
        public string RenewStatus { get; set; }

        /// <summary>
        /// subscriptionType
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}

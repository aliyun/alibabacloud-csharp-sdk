// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ManagedDaOrderVO : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("payNum")]
        [Validation(Required=false)]
        public int? PayNum { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("subscriptionPlan")]
        [Validation(Required=false)]
        public string SubscriptionPlan { get; set; }

    }

}

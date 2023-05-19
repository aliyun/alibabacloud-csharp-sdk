// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetAllExpirationDayRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The expiration date. You can set an expiration date only for ECS instances that have not expired. The expiration date that you specify do not take effect on expired ECS instances. After the expiration date is set, the expiration date is used when you renew ECS instances.
        /// 
        /// You can set the expiration date to a day from the 1st to the 28th of each month.
        /// </summary>
        [NameInMap("UnifyExpireDay")]
        [Validation(Required=false)]
        public string UnifyExpireDay { get; set; }

    }

}

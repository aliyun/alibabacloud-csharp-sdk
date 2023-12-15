// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ConfirmNotifyShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account that is used to confirm the notification. You can set this parameter to **0**, which indicates that the notification is confirmed by the system.
        /// </summary>
        [NameInMap("Confirmor")]
        [Validation(Required=false)]
        public long? Confirmor { get; set; }

        /// <summary>
        /// The notification IDs.
        /// </summary>
        [NameInMap("NotifyIdList")]
        [Validation(Required=false)]
        public string NotifyIdListShrink { get; set; }

    }

}

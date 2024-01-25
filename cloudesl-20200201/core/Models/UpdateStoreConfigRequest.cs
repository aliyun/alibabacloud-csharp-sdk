// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class UpdateStoreConfigRequest : TeaModel {
        [NameInMap("EnableNotification")]
        [Validation(Required=false)]
        public bool? EnableNotification { get; set; }

        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParams { get; set; }

        [NameInMap("NotificationSilentTimes")]
        [Validation(Required=false)]
        public string NotificationSilentTimes { get; set; }

        [NameInMap("NotificationWebHook")]
        [Validation(Required=false)]
        public string NotificationWebHook { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("SubscribeContents")]
        [Validation(Required=false)]
        public string SubscribeContents { get; set; }

    }

}

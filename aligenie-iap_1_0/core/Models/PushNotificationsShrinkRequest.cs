// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class PushNotificationsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Input parameter object for message push.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationUnicastRequest")]
        [Validation(Required=false)]
        public string NotificationUnicastRequestShrink { get; set; }

        /// <summary>
        /// <para>Identity information.</para>
        /// </summary>
        [NameInMap("TenantInfo")]
        [Validation(Required=false)]
        public string TenantInfoShrink { get; set; }

    }

}

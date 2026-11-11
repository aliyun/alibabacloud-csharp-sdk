// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class SendNotificationsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

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

        /// <summary>
        /// <para>User Identifier information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}

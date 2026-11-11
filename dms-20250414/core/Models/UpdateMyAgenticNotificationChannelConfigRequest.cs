// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateMyAgenticNotificationChannelConfigRequest : TeaModel {
        /// <summary>
        /// <para>The notification channel type. Currently, only FEISHU (Lark) is supported. Specifying other values results in a parameter error.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The channel configuration in the format of a JSON object string. This parameter is not required if you do not update the binding information. Supports mobile (phone number) or email. You can bind or rebind a Lark account by using one of them at a time. If the existing masked values of mobile or email are passed as ******, they are not modified. openId is a read-only field and cannot be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;email&quot;:&quot;<a href="mailto:user@example.com">user@example.com</a>&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the notification channel. If this parameter is not specified, the original value is retained. When you only modify the switch, the Config parameter is not required, and the existing binding information remains unchanged.</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}

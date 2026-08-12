// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SeverityNotifyConfig : TeaModel {
        /// <summary>
        /// <para>The list of notification recipients. Each recipient specifies a type, an identifier, and the enabled channels.</para>
        /// </summary>
        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<DirectNotifyReceiver> Receivers { get; set; }

        /// <summary>
        /// <para>Specifies whether to send recovery notifications for this severity level. If this parameter is left empty, the value falls back to the top-level sendRecoverNotification parameter.</para>
        /// </summary>
        [NameInMap("sendRecoverNotification")]
        [Validation(Required=false)]
        public bool? SendRecoverNotification { get; set; }

    }

}

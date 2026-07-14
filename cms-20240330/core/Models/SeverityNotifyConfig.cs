// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SeverityNotifyConfig : TeaModel {
        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<DirectNotifyReceiver> Receivers { get; set; }

        [NameInMap("sendRecoverNotification")]
        [Validation(Required=false)]
        public bool? SendRecoverNotification { get; set; }

    }

}

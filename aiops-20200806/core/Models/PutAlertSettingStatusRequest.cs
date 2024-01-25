// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class PutAlertSettingStatusRequest : TeaModel {
        [NameInMap("AlertSettingId")]
        [Validation(Required=false)]
        public long? AlertSettingId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("SettingStatus")]
        [Validation(Required=false)]
        public long? SettingStatus { get; set; }

    }

}

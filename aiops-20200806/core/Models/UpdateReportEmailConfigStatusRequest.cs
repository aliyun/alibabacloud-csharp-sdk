// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateReportEmailConfigStatusRequest : TeaModel {
        [NameInMap("ConfigStatus")]
        [Validation(Required=false)]
        public int? ConfigStatus { get; set; }

        [NameInMap("MailConfigId")]
        [Validation(Required=false)]
        public long? MailConfigId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}

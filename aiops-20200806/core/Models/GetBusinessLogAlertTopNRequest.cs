// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetBusinessLogAlertTopNRequest : TeaModel {
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("TopNum")]
        [Validation(Required=false)]
        public long? TopNum { get; set; }

    }

}

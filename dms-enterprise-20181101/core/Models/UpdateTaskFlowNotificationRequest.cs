// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowNotificationRequest : TeaModel {
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        [NameInMap("DagNotificationFail")]
        [Validation(Required=false)]
        public bool? DagNotificationFail { get; set; }

        [NameInMap("DagNotificationSla")]
        [Validation(Required=false)]
        public bool? DagNotificationSla { get; set; }

        [NameInMap("DagNotificationSuccess")]
        [Validation(Required=false)]
        public bool? DagNotificationSuccess { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

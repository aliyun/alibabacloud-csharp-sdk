// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateRemindRequest : TeaModel {
        [NameInMap("AlertInterval")]
        [Validation(Required=false)]
        public int? AlertInterval { get; set; }

        [NameInMap("AlertMethods")]
        [Validation(Required=false)]
        public string AlertMethods { get; set; }

        [NameInMap("AlertTargets")]
        [Validation(Required=false)]
        public string AlertTargets { get; set; }

        [NameInMap("AlertUnit")]
        [Validation(Required=false)]
        public string AlertUnit { get; set; }

        [NameInMap("BaselineIds")]
        [Validation(Required=false)]
        public string BaselineIds { get; set; }

        [NameInMap("BizProcessIds")]
        [Validation(Required=false)]
        public string BizProcessIds { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("DndEnd")]
        [Validation(Required=false)]
        public string DndEnd { get; set; }

        [NameInMap("MaxAlertTimes")]
        [Validation(Required=false)]
        public int? MaxAlertTimes { get; set; }

        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("RemindName")]
        [Validation(Required=false)]
        public string RemindName { get; set; }

        [NameInMap("RemindType")]
        [Validation(Required=false)]
        public string RemindType { get; set; }

        [NameInMap("RemindUnit")]
        [Validation(Required=false)]
        public string RemindUnit { get; set; }

        [NameInMap("RobotUrls")]
        [Validation(Required=false)]
        public string RobotUrls { get; set; }

        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public string Webhooks { get; set; }

    }

}

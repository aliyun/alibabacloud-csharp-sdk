// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarTaskAndActionsResponseBody : TeaModel {
        [NameInMap("Details")]
        [Validation(Required=false)]
        public DescribeSoarTaskAndActionsResponseBodyDetails Details { get; set; }
        public class DescribeSoarTaskAndActionsResponseBodyDetails : TeaModel {
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<DescribeSoarTaskAndActionsResponseBodyDetailsActions> Actions { get; set; }
            public class DescribeSoarTaskAndActionsResponseBodyDetailsActions : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("ActionUuid")]
                [Validation(Required=false)]
                public string ActionUuid { get; set; }

                [NameInMap("AssetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                [NameInMap("Component")]
                [Validation(Required=false)]
                public string Component { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("RequestUuid")]
                [Validation(Required=false)]
                public string RequestUuid { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                [NameInMap("TriggerUser")]
                [Validation(Required=false)]
                public string TriggerUser { get; set; }

            }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("RawEventReq")]
            [Validation(Required=false)]
            public string RawEventReq { get; set; }

            [NameInMap("RequestUuid")]
            [Validation(Required=false)]
            public string RequestUuid { get; set; }

            [NameInMap("ResultLevel")]
            [Validation(Required=false)]
            public string ResultLevel { get; set; }

            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskFlowMd5")]
            [Validation(Required=false)]
            public string TaskFlowMd5 { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskTenantId")]
            [Validation(Required=false)]
            public string TaskTenantId { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            [NameInMap("TriggerUser")]
            [Validation(Required=false)]
            public string TriggerUser { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

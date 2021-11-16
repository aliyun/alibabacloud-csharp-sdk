// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetRemindResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRemindResponseBodyData Data { get; set; }
        public class GetRemindResponseBodyData : TeaModel {
            [NameInMap("AlertInterval")]
            [Validation(Required=false)]
            public int? AlertInterval { get; set; }
            [NameInMap("AlertMethods")]
            [Validation(Required=false)]
            public List<string> AlertMethods { get; set; }
            [NameInMap("AlertTargets")]
            [Validation(Required=false)]
            public List<string> AlertTargets { get; set; }
            [NameInMap("AlertUnit")]
            [Validation(Required=false)]
            public string AlertUnit { get; set; }
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBaselines> Baselines { get; set; }
            public class GetRemindResponseBodyDataBaselines : TeaModel {
                public long? BaselineId { get; set; }
                public string BaselineName { get; set; }
            }
            [NameInMap("BizProcesses")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataBizProcesses> BizProcesses { get; set; }
            public class GetRemindResponseBodyDataBizProcesses : TeaModel {
                public long? BizId { get; set; }
                public string BizProcessName { get; set; }
            }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }
            [NameInMap("DndEnd")]
            [Validation(Required=false)]
            public string DndEnd { get; set; }
            [NameInMap("DndStart")]
            [Validation(Required=false)]
            public string DndStart { get; set; }
            [NameInMap("Founder")]
            [Validation(Required=false)]
            public string Founder { get; set; }
            [NameInMap("MaxAlertTimes")]
            [Validation(Required=false)]
            public int? MaxAlertTimes { get; set; }
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataNodes> Nodes { get; set; }
            public class GetRemindResponseBodyDataNodes : TeaModel {
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string Owner { get; set; }
                public long? ProjectId { get; set; }
            }
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataProjects> Projects { get; set; }
            public class GetRemindResponseBodyDataProjects : TeaModel {
                public long? ProjectId { get; set; }
            }
            [NameInMap("RemindId")]
            [Validation(Required=false)]
            public long? RemindId { get; set; }
            [NameInMap("RemindName")]
            [Validation(Required=false)]
            public string RemindName { get; set; }
            [NameInMap("RemindType")]
            [Validation(Required=false)]
            public string RemindType { get; set; }
            [NameInMap("RemindUnit")]
            [Validation(Required=false)]
            public string RemindUnit { get; set; }
            [NameInMap("Robots")]
            [Validation(Required=false)]
            public List<GetRemindResponseBodyDataRobots> Robots { get; set; }
            public class GetRemindResponseBodyDataRobots : TeaModel {
                public bool? AtAll { get; set; }
                public string WebUrl { get; set; }
            }
            [NameInMap("Useflag")]
            [Validation(Required=false)]
            public bool? Useflag { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

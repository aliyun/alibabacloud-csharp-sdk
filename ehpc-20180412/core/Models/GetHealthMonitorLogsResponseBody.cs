// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetHealthMonitorLogsResponseBody : TeaModel {
        [NameInMap("LogInfo")]
        [Validation(Required=false)]
        public List<GetHealthMonitorLogsResponseBodyLogInfo> LogInfo { get; set; }
        public class GetHealthMonitorLogsResponseBodyLogInfo : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            [NameInMap("ItemDescription")]
            [Validation(Required=false)]
            public string ItemDescription { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("HealthId")]
            [Validation(Required=false)]
            public string HealthId { get; set; }

            [NameInMap("CheckList")]
            [Validation(Required=false)]
            public List<GetHealthMonitorLogsResponseBodyLogInfoCheckList> CheckList { get; set; }
            public class GetHealthMonitorLogsResponseBodyLogInfoCheckList : TeaModel {
                [NameInMap("CheckInfo")]
                [Validation(Required=false)]
                public string CheckInfo { get; set; }

                [NameInMap("CheckDescription")]
                [Validation(Required=false)]
                public string CheckDescription { get; set; }

                [NameInMap("CheckSolution")]
                [Validation(Required=false)]
                public string CheckSolution { get; set; }

                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

            }

            [NameInMap("SceneDescription")]
            [Validation(Required=false)]
            public string SceneDescription { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

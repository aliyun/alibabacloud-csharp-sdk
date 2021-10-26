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
        public GetHealthMonitorLogsResponseBodyLogInfo LogInfo { get; set; }
        public class GetHealthMonitorLogsResponseBodyLogInfo : TeaModel {
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<GetHealthMonitorLogsResponseBodyLogInfoLogs> Logs { get; set; }
            public class GetHealthMonitorLogsResponseBodyLogInfoLogs : TeaModel {
                public GetHealthMonitorLogsResponseBodyLogInfoLogsCheckList CheckList { get; set; }
                public class GetHealthMonitorLogsResponseBodyLogInfoLogsCheckList : TeaModel {
                    [NameInMap("CheckList")]
                    [Validation(Required=false)]
                    public List<GetHealthMonitorLogsResponseBodyLogInfoLogsCheckListCheckList> CheckList { get; set; }
                    public class GetHealthMonitorLogsResponseBodyLogInfoLogsCheckListCheckList : TeaModel {
                        [NameInMap("CheckDescription")]
                        [Validation(Required=false)]
                        public string CheckDescription { get; set; }

                        [NameInMap("CheckInfo")]
                        [Validation(Required=false)]
                        public string CheckInfo { get; set; }

                        [NameInMap("CheckName")]
                        [Validation(Required=false)]
                        public string CheckName { get; set; }

                        [NameInMap("CheckSolution")]
                        [Validation(Required=false)]
                        public string CheckSolution { get; set; }

                    }

                }
                public string HealthId { get; set; }
                public string HostName { get; set; }
                public string InstanceId { get; set; }
                public string ItemDescription { get; set; }
                public string ItemName { get; set; }
                public string Level { get; set; }
                public string SceneDescription { get; set; }
                public string SceneName { get; set; }
                public int? Time { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class ListMcubeUpgradeTasksResponseBody : TeaModel {
        [NameInMap("ListTaskResult")]
        [Validation(Required=false)]
        public ListMcubeUpgradeTasksResponseBodyListTaskResult ListTaskResult { get; set; }
        public class ListMcubeUpgradeTasksResponseBodyListTaskResult : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public List<ListMcubeUpgradeTasksResponseBodyListTaskResultTaskInfo> TaskInfo { get; set; }
            public class ListMcubeUpgradeTasksResponseBodyListTaskResultTaskInfo : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GreyConfigInfo")]
                [Validation(Required=false)]
                public string GreyConfigInfo { get; set; }

                [NameInMap("GreyEndtime")]
                [Validation(Required=false)]
                public string GreyEndtime { get; set; }

                [NameInMap("GreyNum")]
                [Validation(Required=false)]
                public int? GreyNum { get; set; }

                [NameInMap("HistoryForce")]
                [Validation(Required=false)]
                public int? HistoryForce { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsEnterprise")]
                [Validation(Required=false)]
                public int? IsEnterprise { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("PackageInfoId")]
                [Validation(Required=false)]
                public long? PackageInfoId { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("PublishMode")]
                [Validation(Required=false)]
                public int? PublishMode { get; set; }

                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public int? PublishType { get; set; }

                [NameInMap("PushContent")]
                [Validation(Required=false)]
                public string PushContent { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

                [NameInMap("UpgradeContent")]
                [Validation(Required=false)]
                public string UpgradeContent { get; set; }

                [NameInMap("UpgradeType")]
                [Validation(Required=false)]
                public int? UpgradeType { get; set; }

                [NameInMap("WhitelistIds")]
                [Validation(Required=false)]
                public string WhitelistIds { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}

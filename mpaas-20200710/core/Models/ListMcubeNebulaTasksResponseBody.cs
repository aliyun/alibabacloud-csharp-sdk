// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class ListMcubeNebulaTasksResponseBody : TeaModel {
        [NameInMap("ListMcubeNebulaTaskResult")]
        [Validation(Required=false)]
        public ListMcubeNebulaTasksResponseBodyListMcubeNebulaTaskResult ListMcubeNebulaTaskResult { get; set; }
        public class ListMcubeNebulaTasksResponseBodyListMcubeNebulaTaskResult : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("NebulaTaskInfo")]
            [Validation(Required=false)]
            public List<ListMcubeNebulaTasksResponseBodyListMcubeNebulaTaskResultNebulaTaskInfo> NebulaTaskInfo { get; set; }
            public class ListMcubeNebulaTasksResponseBodyListMcubeNebulaTaskResultNebulaTaskInfo : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("GmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                [NameInMap("GreyConfigInfo")]
                [Validation(Required=false)]
                public string GreyConfigInfo { get; set; }

                [NameInMap("GreyEndtime")]
                [Validation(Required=false)]
                public string GreyEndtime { get; set; }

                [NameInMap("GreyEndtimeData")]
                [Validation(Required=false)]
                public string GreyEndtimeData { get; set; }

                [NameInMap("GreyEndtimeStr")]
                [Validation(Required=false)]
                public string GreyEndtimeStr { get; set; }

                [NameInMap("GreyNum")]
                [Validation(Required=false)]
                public int? GreyNum { get; set; }

                [NameInMap("GreyUrl")]
                [Validation(Required=false)]
                public string GreyUrl { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public long? PackageId { get; set; }

                [NameInMap("Percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

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

                [NameInMap("ReleaseVersion")]
                [Validation(Required=false)]
                public string ReleaseVersion { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SyncResult")]
                [Validation(Required=false)]
                public string SyncResult { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

                [NameInMap("TaskVersion")]
                [Validation(Required=false)]
                public long? TaskVersion { get; set; }

                [NameInMap("UpgradeNoticeNum")]
                [Validation(Required=false)]
                public long? UpgradeNoticeNum { get; set; }

                [NameInMap("UpgradeProgress")]
                [Validation(Required=false)]
                public string UpgradeProgress { get; set; }

                [NameInMap("WhitelistIds")]
                [Validation(Required=false)]
                public string WhitelistIds { get; set; }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

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

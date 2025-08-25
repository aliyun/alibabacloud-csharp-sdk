// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class GetMcubeUpgradeTaskInfoResponseBody : TeaModel {
        [NameInMap("GetTaskResult")]
        [Validation(Required=false)]
        public GetMcubeUpgradeTaskInfoResponseBodyGetTaskResult GetTaskResult { get; set; }
        public class GetMcubeUpgradeTaskInfoResponseBodyGetTaskResult : TeaModel {
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
            public GetMcubeUpgradeTaskInfoResponseBodyGetTaskResultTaskInfo TaskInfo { get; set; }
            public class GetMcubeUpgradeTaskInfoResponseBodyGetTaskResultTaskInfo : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppstoreUrl")]
                [Validation(Required=false)]
                public string AppstoreUrl { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("GreyConfigInfo")]
                [Validation(Required=false)]
                public string GreyConfigInfo { get; set; }

                [NameInMap("GreyEndtimeData")]
                [Validation(Required=false)]
                public string GreyEndtimeData { get; set; }

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

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                [NameInMap("PublishMode")]
                [Validation(Required=false)]
                public int? PublishMode { get; set; }

                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public int? PublishType { get; set; }

                [NameInMap("RuleJsonList")]
                [Validation(Required=false)]
                public List<GetMcubeUpgradeTaskInfoResponseBodyGetTaskResultTaskInfoRuleJsonList> RuleJsonList { get; set; }
                public class GetMcubeUpgradeTaskInfoResponseBodyGetTaskResultTaskInfoRuleJsonList : TeaModel {
                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    [NameInMap("RuleElement")]
                    [Validation(Required=false)]
                    public string RuleElement { get; set; }

                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("SilentType")]
                [Validation(Required=false)]
                public int? SilentType { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

                [NameInMap("UpgradeContent")]
                [Validation(Required=false)]
                public string UpgradeContent { get; set; }

                [NameInMap("UpgradeType")]
                [Validation(Required=false)]
                public int? UpgradeType { get; set; }

                [NameInMap("UpgradeValidTime")]
                [Validation(Required=false)]
                public int? UpgradeValidTime { get; set; }

                [NameInMap("Whitelist")]
                [Validation(Required=false)]
                public List<GetMcubeUpgradeTaskInfoResponseBodyGetTaskResultTaskInfoWhitelist> Whitelist { get; set; }
                public class GetMcubeUpgradeTaskInfoResponseBodyGetTaskResultTaskInfoWhitelist : TeaModel {
                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("IdType")]
                    [Validation(Required=false)]
                    public string IdType { get; set; }

                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("UserType")]
                    [Validation(Required=false)]
                    public string UserType { get; set; }

                    [NameInMap("WhiteListCount")]
                    [Validation(Required=false)]
                    public long? WhiteListCount { get; set; }

                    [NameInMap("WhiteListName")]
                    [Validation(Required=false)]
                    public string WhiteListName { get; set; }

                    [NameInMap("WhitelistType")]
                    [Validation(Required=false)]
                    public string WhitelistType { get; set; }

                }

                [NameInMap("WhitelistIds")]
                [Validation(Required=false)]
                public string WhitelistIds { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

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

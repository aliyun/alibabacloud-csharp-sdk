// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMcubeHotpatchTaskDetailResponseBody : TeaModel {
        [NameInMap("QueryHotpatchTaskDetailResult")]
        [Validation(Required=false)]
        public QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResult QueryHotpatchTaskDetailResult { get; set; }
        public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResult : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("HotpatchTaskDetail")]
            [Validation(Required=false)]
            public QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetail HotpatchTaskDetail { get; set; }
            public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetail : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("BaseInfoId")]
                [Validation(Required=false)]
                public long? BaseInfoId { get; set; }

                [NameInMap("Bundles")]
                [Validation(Required=false)]
                public List<string> Bundles { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

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

                [NameInMap("GreyEndtimeData")]
                [Validation(Required=false)]
                public string GreyEndtimeData { get; set; }

                [NameInMap("GreyNum")]
                [Validation(Required=false)]
                public long? GreyNum { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public long? PackageId { get; set; }

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
                public long? PublishMode { get; set; }

                [NameInMap("PublishPeriod")]
                [Validation(Required=false)]
                public long? PublishPeriod { get; set; }

                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public long? PublishType { get; set; }

                [NameInMap("QuickRollback")]
                [Validation(Required=false)]
                public long? QuickRollback { get; set; }

                [NameInMap("ReleaseVersion")]
                [Validation(Required=false)]
                public string ReleaseVersion { get; set; }

                [NameInMap("RuleJsonList")]
                [Validation(Required=false)]
                public List<QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailRuleJsonList> RuleJsonList { get; set; }
                public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailRuleJsonList : TeaModel {
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

                [NameInMap("SourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public long? TaskStatus { get; set; }

                [NameInMap("TaskVersion")]
                [Validation(Required=false)]
                public long? TaskVersion { get; set; }

                [NameInMap("Whitelist")]
                [Validation(Required=false)]
                public List<QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailWhitelist> Whitelist { get; set; }
                public class QueryMcubeHotpatchTaskDetailResponseBodyQueryHotpatchTaskDetailResultHotpatchTaskDetailWhitelist : TeaModel {
                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("Business")]
                    [Validation(Required=false)]
                    public string Business { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

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
                    public long? Status { get; set; }

                    [NameInMap("WhiteListCount")]
                    [Validation(Required=false)]
                    public long? WhiteListCount { get; set; }

                    [NameInMap("WhiteListName")]
                    [Validation(Required=false)]
                    public string WhiteListName { get; set; }

                }

                [NameInMap("WhitelistIds")]
                [Validation(Required=false)]
                public string WhitelistIds { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

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

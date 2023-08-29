// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMdsUpgradeTaskDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryMdsUpgradeTaskDetailResponseBodyResultContent ResultContent { get; set; }
        public class QueryMdsUpgradeTaskDetailResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryMdsUpgradeTaskDetailResponseBodyResultContentData Data { get; set; }
            public class QueryMdsUpgradeTaskDetailResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public QueryMdsUpgradeTaskDetailResponseBodyResultContentDataContent Content { get; set; }
                public class QueryMdsUpgradeTaskDetailResponseBodyResultContentDataContent : TeaModel {
                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("Appstoreurl")]
                    [Validation(Required=false)]
                    public string Appstoreurl { get; set; }

                    [NameInMap("ChannelContains")]
                    [Validation(Required=false)]
                    public string ChannelContains { get; set; }

                    [NameInMap("ChannelExcludes")]
                    [Validation(Required=false)]
                    public string ChannelExcludes { get; set; }

                    [NameInMap("CityContains")]
                    [Validation(Required=false)]
                    public string CityContains { get; set; }

                    [NameInMap("CityExcludes")]
                    [Validation(Required=false)]
                    public string CityExcludes { get; set; }

                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    [NameInMap("DeviceGreyNum")]
                    [Validation(Required=false)]
                    public long? DeviceGreyNum { get; set; }

                    [NameInMap("DevicePercent")]
                    [Validation(Required=false)]
                    public long? DevicePercent { get; set; }

                    [NameInMap("DownloadUrl")]
                    [Validation(Required=false)]
                    public string DownloadUrl { get; set; }

                    [NameInMap("ExecutionOrder")]
                    [Validation(Required=false)]
                    public long? ExecutionOrder { get; set; }

                    [NameInMap("GmtCreateStr")]
                    [Validation(Required=false)]
                    public string GmtCreateStr { get; set; }

                    [NameInMap("GreyConfigInfo")]
                    [Validation(Required=false)]
                    public string GreyConfigInfo { get; set; }

                    [NameInMap("GreyEndtimeData")]
                    [Validation(Required=false)]
                    public string GreyEndtimeData { get; set; }

                    [NameInMap("GreyNotice")]
                    [Validation(Required=false)]
                    public long? GreyNotice { get; set; }

                    [NameInMap("GreyNum")]
                    [Validation(Required=false)]
                    public long? GreyNum { get; set; }

                    [NameInMap("GreyUv")]
                    [Validation(Required=false)]
                    public long? GreyUv { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InnerVersion")]
                    [Validation(Required=false)]
                    public string InnerVersion { get; set; }

                    [NameInMap("IsEnterprise")]
                    [Validation(Required=false)]
                    public long? IsEnterprise { get; set; }

                    [NameInMap("IsOfficial")]
                    [Validation(Required=false)]
                    public long? IsOfficial { get; set; }

                    [NameInMap("IsPush")]
                    [Validation(Required=false)]
                    public long? IsPush { get; set; }

                    [NameInMap("IsRc")]
                    [Validation(Required=false)]
                    public long? IsRc { get; set; }

                    [NameInMap("IsRelease")]
                    [Validation(Required=false)]
                    public long? IsRelease { get; set; }

                    [NameInMap("Memo")]
                    [Validation(Required=false)]
                    public string Memo { get; set; }

                    [NameInMap("MobileModelContains")]
                    [Validation(Required=false)]
                    public string MobileModelContains { get; set; }

                    [NameInMap("MobileModelExcludes")]
                    [Validation(Required=false)]
                    public string MobileModelExcludes { get; set; }

                    [NameInMap("Modifier")]
                    [Validation(Required=false)]
                    public string Modifier { get; set; }

                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                    [NameInMap("OsVersion")]
                    [Validation(Required=false)]
                    public string OsVersion { get; set; }

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

                    [NameInMap("ProductVersion")]
                    [Validation(Required=false)]
                    public string ProductVersion { get; set; }

                    [NameInMap("PublishMode")]
                    [Validation(Required=false)]
                    public long? PublishMode { get; set; }

                    [NameInMap("PublishType")]
                    [Validation(Required=false)]
                    public long? PublishType { get; set; }

                    [NameInMap("PushContent")]
                    [Validation(Required=false)]
                    public string PushContent { get; set; }

                    [NameInMap("QrcodeUrl")]
                    [Validation(Required=false)]
                    public string QrcodeUrl { get; set; }

                    [NameInMap("ReleaseType")]
                    [Validation(Required=false)]
                    public string ReleaseType { get; set; }

                    [NameInMap("RuleJsonList")]
                    [Validation(Required=false)]
                    public List<QueryMdsUpgradeTaskDetailResponseBodyResultContentDataContentRuleJsonList> RuleJsonList { get; set; }
                    public class QueryMdsUpgradeTaskDetailResponseBodyResultContentDataContentRuleJsonList : TeaModel {
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
                    public long? SilentType { get; set; }

                    [NameInMap("SyncMode")]
                    [Validation(Required=false)]
                    public string SyncMode { get; set; }

                    [NameInMap("SyncResult")]
                    [Validation(Required=false)]
                    public string SyncResult { get; set; }

                    [NameInMap("TaskStatus")]
                    [Validation(Required=false)]
                    public long? TaskStatus { get; set; }

                    [NameInMap("UpgradeContent")]
                    [Validation(Required=false)]
                    public string UpgradeContent { get; set; }

                    [NameInMap("UpgradeType")]
                    [Validation(Required=false)]
                    public long? UpgradeType { get; set; }

                    [NameInMap("UpgradeValidTime")]
                    [Validation(Required=false)]
                    public long? UpgradeValidTime { get; set; }

                    [NameInMap("Whitelist")]
                    [Validation(Required=false)]
                    public List<QueryMdsUpgradeTaskDetailResponseBodyResultContentDataContentWhitelist> Whitelist { get; set; }
                    public class QueryMdsUpgradeTaskDetailResponseBodyResultContentDataContentWhitelist : TeaModel {
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

                }

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

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}

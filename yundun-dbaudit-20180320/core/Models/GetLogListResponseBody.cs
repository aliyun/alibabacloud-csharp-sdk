// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogListResponseBody : TeaModel {
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        [NameInMap("Incomplete")]
        [Validation(Required=false)]
        public string Incomplete { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<GetLogListResponseBodyResults> Results { get; set; }
        public class GetLogListResponseBodyResults : TeaModel {
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public int? ClientPort { get; set; }

            [NameInMap("ExecCostUS")]
            [Validation(Required=false)]
            public int? ExecCostUS { get; set; }

            [NameInMap("AppClientIp")]
            [Validation(Required=false)]
            public string AppClientIp { get; set; }

            [NameInMap("SessionLogoutTime")]
            [Validation(Required=false)]
            public string SessionLogoutTime { get; set; }

            [NameInMap("ClientOsUser")]
            [Validation(Required=false)]
            public string ClientOsUser { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            [NameInMap("AppUsername")]
            [Validation(Required=false)]
            public string AppUsername { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            [NameInMap("RuleKeyId")]
            [Validation(Required=false)]
            public int? RuleKeyId { get; set; }

            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public int? AffectRows { get; set; }

            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            [NameInMap("SessionLoginTime")]
            [Validation(Required=false)]
            public string SessionLoginTime { get; set; }

            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            [NameInMap("ServerMac")]
            [Validation(Required=false)]
            public string ServerMac { get; set; }

            [NameInMap("DbServer")]
            [Validation(Required=false)]
            public string DbServer { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SqlContent")]
            [Validation(Required=false)]
            public string SqlContent { get; set; }

            [NameInMap("ResponseCode")]
            [Validation(Required=false)]
            public string ResponseCode { get; set; }

            [NameInMap("InstName")]
            [Validation(Required=false)]
            public string InstName { get; set; }

            [NameInMap("ClientProgram")]
            [Validation(Required=false)]
            public string ClientProgram { get; set; }

            [NameInMap("CaptureTime")]
            [Validation(Required=false)]
            public string CaptureTime { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("ClientMac")]
            [Validation(Required=false)]
            public string ClientMac { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("FetchCostUS")]
            [Validation(Required=false)]
            public int? FetchCostUS { get; set; }

            [NameInMap("ResponseText")]
            [Validation(Required=false)]
            public string ResponseText { get; set; }

        }

    }

}

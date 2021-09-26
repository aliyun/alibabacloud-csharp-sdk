// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogListRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        [NameInMap("SqlKey")]
        [Validation(Required=false)]
        public string SqlKey { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public string IsSuccess { get; set; }

        [NameInMap("MinAffectRows")]
        [Validation(Required=false)]
        public int? MinAffectRows { get; set; }

        [NameInMap("MaxAffectRows")]
        [Validation(Required=false)]
        public int? MaxAffectRows { get; set; }

        [NameInMap("MinExecCostUS")]
        [Validation(Required=false)]
        public int? MinExecCostUS { get; set; }

        [NameInMap("MaxExecCostUS")]
        [Validation(Required=false)]
        public int? MaxExecCostUS { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("ClientIpList")]
        [Validation(Required=false)]
        public List<string> ClientIpList { get; set; }

        [NameInMap("DbUserList")]
        [Validation(Required=false)]
        public List<string> DbUserList { get; set; }

        [NameInMap("DbHostList")]
        [Validation(Required=false)]
        public List<string> DbHostList { get; set; }

        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        [NameInMap("RuleTypeList")]
        [Validation(Required=false)]
        public List<string> RuleTypeList { get; set; }

        [NameInMap("SqlTypeList")]
        [Validation(Required=false)]
        public List<string> SqlTypeList { get; set; }

        [NameInMap("ClientProgramList")]
        [Validation(Required=false)]
        public List<string> ClientProgramList { get; set; }

    }

}

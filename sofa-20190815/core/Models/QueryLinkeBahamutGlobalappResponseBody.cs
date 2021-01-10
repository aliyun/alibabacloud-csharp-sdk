// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutGlobalappResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryLinkeBahamutGlobalappResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutGlobalappResponseBodyResult : TeaModel {
            [NameInMap("AppGroup")]
            [Validation(Required=false)]
            public string AppGroup { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("ArchDomainExternalId")]
            [Validation(Required=false)]
            public string ArchDomainExternalId { get; set; }

            [NameInMap("ArchDomainName")]
            [Validation(Required=false)]
            public string ArchDomainName { get; set; }

            [NameInMap("AutoBetaSitDeploy")]
            [Validation(Required=false)]
            public bool? AutoBetaSitDeploy { get; set; }

            [NameInMap("BaseJarInfo")]
            [Validation(Required=false)]
            public string BaseJarInfo { get; set; }

            [NameInMap("BetterQuality")]
            [Validation(Required=false)]
            public bool? BetterQuality { get; set; }

            [NameInMap("CommonRiskPointInspection")]
            [Validation(Required=false)]
            public bool? CommonRiskPointInspection { get; set; }

            [NameInMap("CoverageBaseline")]
            [Validation(Required=false)]
            public string CoverageBaseline { get; set; }

            [NameInMap("CoverageFromThirdPlatform")]
            [Validation(Required=false)]
            public bool? CoverageFromThirdPlatform { get; set; }

            [NameInMap("CrucialApp")]
            [Validation(Required=false)]
            public bool? CrucialApp { get; set; }

            [NameInMap("DevLang")]
            [Validation(Required=false)]
            public string DevLang { get; set; }

            [NameInMap("DevServerDeployment")]
            [Validation(Required=false)]
            public bool? DevServerDeployment { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("GitLabGroupName")]
            [Validation(Required=false)]
            public string GitLabGroupName { get; set; }

            [NameInMap("GitLabHttpUrl")]
            [Validation(Required=false)]
            public string GitLabHttpUrl { get; set; }

            [NameInMap("GitLabRepoName")]
            [Validation(Required=false)]
            public string GitLabRepoName { get; set; }

            [NameInMap("GitLabSshUrl")]
            [Validation(Required=false)]
            public string GitLabSshUrl { get; set; }

            [NameInMap("GreyEmergencyRelease")]
            [Validation(Required=false)]
            public bool? GreyEmergencyRelease { get; set; }

            [NameInMap("GreyRelease")]
            [Validation(Required=false)]
            public bool? GreyRelease { get; set; }

            [NameInMap("LegacyConflict")]
            [Validation(Required=false)]
            public string LegacyConflict { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("LockBranch")]
            [Validation(Required=false)]
            public bool? LockBranch { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NetRelease")]
            [Validation(Required=false)]
            public bool? NetRelease { get; set; }

            [NameInMap("OptionList")]
            [Validation(Required=false)]
            public string OptionList { get; set; }

            [NameInMap("ParentArchDomainExternalId")]
            [Validation(Required=false)]
            public string ParentArchDomainExternalId { get; set; }

            [NameInMap("ParentArchDomainName")]
            [Validation(Required=false)]
            public string ParentArchDomainName { get; set; }

            [NameInMap("PriPubOwner")]
            [Validation(Required=false)]
            public string PriPubOwner { get; set; }

            [NameInMap("ReleaseDomainName")]
            [Validation(Required=false)]
            public string ReleaseDomainName { get; set; }

            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            [NameInMap("RiskAssessNeeded")]
            [Validation(Required=false)]
            public bool? RiskAssessNeeded { get; set; }

            [NameInMap("ServerDeployment")]
            [Validation(Required=false)]
            public bool? ServerDeployment { get; set; }

            [NameInMap("SitServerDeployment")]
            [Validation(Required=false)]
            public bool? SitServerDeployment { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TcCenterPassRate")]
            [Validation(Required=false)]
            public bool? TcCenterPassRate { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("TrunkMrNeedDefectOrReq")]
            [Validation(Required=false)]
            public bool? TrunkMrNeedDefectOrReq { get; set; }

            [NameInMap("UseTenantQualityRule")]
            [Validation(Required=false)]
            public bool? UseTenantQualityRule { get; set; }

            [NameInMap("Vcs")]
            [Validation(Required=false)]
            public string Vcs { get; set; }

            [NameInMap("ZoneMode")]
            [Validation(Required=false)]
            public string ZoneMode { get; set; }

            [NameInMap("CustomQualityDisplay")]
            [Validation(Required=false)]
            public List<string> CustomQualityDisplay { get; set; }

            [NameInMap("DevOwners")]
            [Validation(Required=false)]
            public List<string> DevOwners { get; set; }

            [NameInMap("DevOwnerUsers")]
            [Validation(Required=false)]
            public List<string> DevOwnerUsers { get; set; }

            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }

            [NameInMap("MemberNames")]
            [Validation(Required=false)]
            public List<string> MemberNames { get; set; }

            [NameInMap("Modules")]
            [Validation(Required=false)]
            public List<string> Modules { get; set; }

            [NameInMap("Pes")]
            [Validation(Required=false)]
            public List<string> Pes { get; set; }

            [NameInMap("ProductOwners")]
            [Validation(Required=false)]
            public List<string> ProductOwners { get; set; }

            [NameInMap("ProductTestOwners")]
            [Validation(Required=false)]
            public List<string> ProductTestOwners { get; set; }

            [NameInMap("PubOwners")]
            [Validation(Required=false)]
            public List<string> PubOwners { get; set; }

            [NameInMap("QualityRules")]
            [Validation(Required=false)]
            public List<string> QualityRules { get; set; }

            [NameInMap("TestOwners")]
            [Validation(Required=false)]
            public List<string> TestOwners { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public QueryLinkeBahamutGlobalappResponseBodyPaginator Paginator { get; set; }
        public class QueryLinkeBahamutGlobalappResponseBodyPaginator : TeaModel {
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public long? ItemCount { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
        };

    }

}

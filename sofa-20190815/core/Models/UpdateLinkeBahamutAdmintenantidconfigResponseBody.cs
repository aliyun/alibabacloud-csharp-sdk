// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeBahamutAdmintenantidconfigResponseBody : TeaModel {
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
        public UpdateLinkeBahamutAdmintenantidconfigResponseBodyResult Result { get; set; }
        public class UpdateLinkeBahamutAdmintenantidconfigResponseBodyResult : TeaModel {
            [NameInMap("AntflowEnabled")]
            [Validation(Required=false)]
            public bool? AntflowEnabled { get; set; }
            [NameInMap("AppChangeNeedNotice")]
            [Validation(Required=false)]
            public string AppChangeNeedNotice { get; set; }
            [NameInMap("AppInitMeta")]
            [Validation(Required=false)]
            public string AppInitMeta { get; set; }
            [NameInMap("AutoAppReleaseStatus")]
            [Validation(Required=false)]
            public bool? AutoAppReleaseStatus { get; set; }
            [NameInMap("AutoReleaseMachine")]
            [Validation(Required=false)]
            public bool? AutoReleaseMachine { get; set; }
            [NameInMap("AutoUnbindMachine")]
            [Validation(Required=false)]
            public bool? AutoUnbindMachine { get; set; }
            [NameInMap("BaseJarInfo")]
            [Validation(Required=false)]
            public string BaseJarInfo { get; set; }
            [NameInMap("CheckAntWatchRiskControl")]
            [Validation(Required=false)]
            public bool? CheckAntWatchRiskControl { get; set; }
            [NameInMap("CheckRunningPreBuildTask")]
            [Validation(Required=false)]
            public bool? CheckRunningPreBuildTask { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("CreateMrWhenMergeConflicts")]
            [Validation(Required=false)]
            public bool? CreateMrWhenMergeConflicts { get; set; }
            [NameInMap("CreateOrImportAppNeedApproval")]
            [Validation(Required=false)]
            public bool? CreateOrImportAppNeedApproval { get; set; }
            [NameInMap("CrossCloud")]
            [Validation(Required=false)]
            public bool? CrossCloud { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("GetSecretFromLinku")]
            [Validation(Required=false)]
            public bool? GetSecretFromLinku { get; set; }
            [NameInMap("GitLabAccount")]
            [Validation(Required=false)]
            public string GitLabAccount { get; set; }
            [NameInMap("GitLabPrivateToken")]
            [Validation(Required=false)]
            public string GitLabPrivateToken { get; set; }
            [NameInMap("GitLabSite")]
            [Validation(Required=false)]
            public string GitLabSite { get; set; }
            [NameInMap("GitLabUser")]
            [Validation(Required=false)]
            public string GitLabUser { get; set; }
            [NameInMap("HighAvailabilityEnabled")]
            [Validation(Required=false)]
            public bool? HighAvailabilityEnabled { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("JarEnabled")]
            [Validation(Required=false)]
            public bool? JarEnabled { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("LinkcApiHost")]
            [Validation(Required=false)]
            public string LinkcApiHost { get; set; }
            [NameInMap("LinkcFrontHost")]
            [Validation(Required=false)]
            public string LinkcFrontHost { get; set; }
            [NameInMap("LinksEnable")]
            [Validation(Required=false)]
            public bool? LinksEnable { get; set; }
            [NameInMap("LinktFrontHost")]
            [Validation(Required=false)]
            public string LinktFrontHost { get; set; }
            [NameInMap("MergeRequestEnabled")]
            [Validation(Required=false)]
            public bool? MergeRequestEnabled { get; set; }
            [NameInMap("MvnJarInfo")]
            [Validation(Required=false)]
            public string MvnJarInfo { get; set; }
            [NameInMap("MyCodeCenterHost")]
            [Validation(Required=false)]
            public string MyCodeCenterHost { get; set; }
            [NameInMap("OnexMode")]
            [Validation(Required=false)]
            public bool? OnexMode { get; set; }
            [NameInMap("OriginOSSConfig")]
            [Validation(Required=false)]
            public string OriginOSSConfig { get; set; }
            [NameInMap("OssConfig")]
            [Validation(Required=false)]
            public string OssConfig { get; set; }
            [NameInMap("PreConfirmArchDomainMap")]
            [Validation(Required=false)]
            public string PreConfirmArchDomainMap { get; set; }
            [NameInMap("QualityIndices")]
            [Validation(Required=false)]
            public string QualityIndices { get; set; }
            [NameInMap("RealGitLabSite")]
            [Validation(Required=false)]
            public string RealGitLabSite { get; set; }
            [NameInMap("ReleaseControlEnabled")]
            [Validation(Required=false)]
            public bool? ReleaseControlEnabled { get; set; }
            [NameInMap("SettingsFile")]
            [Validation(Required=false)]
            public string SettingsFile { get; set; }
            [NameInMap("SkipPreCheck")]
            [Validation(Required=false)]
            public bool? SkipPreCheck { get; set; }
            [NameInMap("StartAccCallback")]
            [Validation(Required=false)]
            public bool? StartAccCallback { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("Tokens")]
            [Validation(Required=false)]
            public string Tokens { get; set; }
            [NameInMap("UpdateAppMetaWhenSync")]
            [Validation(Required=false)]
            public bool? UpdateAppMetaWhenSync { get; set; }
            [NameInMap("UseAppReleaseView")]
            [Validation(Required=false)]
            public bool? UseAppReleaseView { get; set; }
            [NameInMap("UseBaselineToRelease")]
            [Validation(Required=false)]
            public bool? UseBaselineToRelease { get; set; }
            [NameInMap("UseCustomOss")]
            [Validation(Required=false)]
            public bool? UseCustomOss { get; set; }
            [NameInMap("UseNewCloudAppImportView")]
            [Validation(Required=false)]
            public bool? UseNewCloudAppImportView { get; set; }
            [NameInMap("UseNewPrePubEnvIdList")]
            [Validation(Required=false)]
            public bool? UseNewPrePubEnvIdList { get; set; }
            [NameInMap("UseNewThirdPartyWay")]
            [Validation(Required=false)]
            public bool? UseNewThirdPartyWay { get; set; }
            [NameInMap("UseOldFabricPreCheck")]
            [Validation(Required=false)]
            public bool? UseOldFabricPreCheck { get; set; }
            [NameInMap("UseShareMiddleware")]
            [Validation(Required=false)]
            public bool? UseShareMiddleware { get; set; }
            [NameInMap("WebHookUrl")]
            [Validation(Required=false)]
            public string WebHookUrl { get; set; }
            [NameInMap("DefaultQualityRules")]
            [Validation(Required=false)]
            public List<string> DefaultQualityRules { get; set; }
            [NameInMap("GitlabSitePrefixs")]
            [Validation(Required=false)]
            public List<string> GitlabSitePrefixs { get; set; }
        };

    }

}

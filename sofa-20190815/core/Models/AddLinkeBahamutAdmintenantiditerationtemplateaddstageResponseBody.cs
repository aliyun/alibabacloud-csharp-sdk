// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutAdmintenantiditerationtemplateaddstageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddLinkeBahamutAdmintenantiditerationtemplateaddstageResponseBodyResult Result { get; set; }
        public class AddLinkeBahamutAdmintenantiditerationtemplateaddstageResponseBodyResult : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("DockerImageCheck")]
            [Validation(Required=false)]
            public bool? DockerImageCheck { get; set; }
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }
            [NameInMap("TemplateGroup")]
            [Validation(Required=false)]
            public string TemplateGroup { get; set; }
            [NameInMap("MvnCheck")]
            [Validation(Required=false)]
            public bool? MvnCheck { get; set; }
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }
            [NameInMap("PostGuards")]
            [Validation(Required=false)]
            public List<string> PostGuards { get; set; }
            [NameInMap("CheckQuality")]
            [Validation(Required=false)]
            public bool? CheckQuality { get; set; }
            [NameInMap("Joint")]
            [Validation(Required=false)]
            public bool? Joint { get; set; }
            [NameInMap("ShowRelease")]
            [Validation(Required=false)]
            public bool? ShowRelease { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("PreCheck")]
            [Validation(Required=false)]
            public bool? PreCheck { get; set; }
            [NameInMap("MavenRepo")]
            [Validation(Required=false)]
            public string MavenRepo { get; set; }
            [NameInMap("SkipApprovalTasks")]
            [Validation(Required=false)]
            public bool? SkipApprovalTasks { get; set; }
            [NameInMap("PreSetPipelineTemplateIds")]
            [Validation(Required=false)]
            public List<string> PreSetPipelineTemplateIds { get; set; }
            [NameInMap("PreTasks")]
            [Validation(Required=false)]
            public List<string> PreTasks { get; set; }
            [NameInMap("PreSetId")]
            [Validation(Required=false)]
            public string PreSetId { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("MergeRequestAllowed")]
            [Validation(Required=false)]
            public bool? MergeRequestAllowed { get; set; }
            [NameInMap("FabricStage")]
            [Validation(Required=false)]
            public string FabricStage { get; set; }
            [NameInMap("ConfigItemCheck")]
            [Validation(Required=false)]
            public bool? ConfigItemCheck { get; set; }
            [NameInMap("RevertTasks")]
            [Validation(Required=false)]
            public List<string> RevertTasks { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PostTasks")]
            [Validation(Required=false)]
            public List<string> PostTasks { get; set; }
            [NameInMap("PreGuards")]
            [Validation(Required=false)]
            public List<string> PreGuards { get; set; }
            [NameInMap("SerialCheck")]
            [Validation(Required=false)]
            public bool? SerialCheck { get; set; }
            [NameInMap("MultiEnvConfigs")]
            [Validation(Required=false)]
            public List<string> MultiEnvConfigs { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
            [NameInMap("CheckStc")]
            [Validation(Required=false)]
            public bool? CheckStc { get; set; }
            [NameInMap("GreyRelease")]
            [Validation(Required=false)]
            public bool? GreyRelease { get; set; }
            [NameInMap("SkipCodeChangeCheck")]
            [Validation(Required=false)]
            public bool? SkipCodeChangeCheck { get; set; }
            [NameInMap("MutualCheck")]
            [Validation(Required=false)]
            public bool? MutualCheck { get; set; }
            [NameInMap("AutoComplete")]
            [Validation(Required=false)]
            public bool? AutoComplete { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("Pipelines")]
            [Validation(Required=false)]
            public List<string> Pipelines { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("CloudWorkspaceId")]
            [Validation(Required=false)]
            public string CloudWorkspaceId { get; set; }
        };

    }

}

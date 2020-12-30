// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSyncRuleRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("TargetRegionId")]
        [Validation(Required=false)]
        public string TargetRegionId { get; set; }

        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        [NameInMap("TargetNamespaceName")]
        [Validation(Required=false)]
        public string TargetNamespaceName { get; set; }

        [NameInMap("TargetRepoName")]
        [Validation(Required=false)]
        public string TargetRepoName { get; set; }

        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public string TagFilter { get; set; }

        [NameInMap("SyncScope")]
        [Validation(Required=false)]
        public string SyncScope { get; set; }

        [NameInMap("SyncRuleName")]
        [Validation(Required=false)]
        public string SyncRuleName { get; set; }

        [NameInMap("SyncTrigger")]
        [Validation(Required=false)]
        public string SyncTrigger { get; set; }

    }

}

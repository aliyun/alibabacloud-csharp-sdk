// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspace : TeaModel {
        [NameInMap("commercial")]
        [Validation(Required=false)]
        public bool? Commercial { get; set; }

        [NameInMap("deployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public float? EndTime { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public float? GmtCreate { get; set; }

        [NameInMap("grafanaVersion")]
        [Validation(Required=false)]
        public string GrafanaVersion { get; set; }

        [NameInMap("grafanaWorkspaceDomain")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceDomain { get; set; }

        [NameInMap("grafanaWorkspaceEdition")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceEdition { get; set; }

        [NameInMap("grafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        [NameInMap("grafanaWorkspaceIp")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceIp { get; set; }

        [NameInMap("grafanaWorkspaceName")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceName { get; set; }

        [NameInMap("maxAccount")]
        [Validation(Required=false)]
        public string MaxAccount { get; set; }

        [NameInMap("ntmId")]
        [Validation(Required=false)]
        public string NtmId { get; set; }

        [NameInMap("personalDomain")]
        [Validation(Required=false)]
        public string PersonalDomain { get; set; }

        [NameInMap("personalDomainPrefix")]
        [Validation(Required=false)]
        public string PersonalDomainPrefix { get; set; }

        [NameInMap("privateDomain")]
        [Validation(Required=false)]
        public string PrivateDomain { get; set; }

        [NameInMap("privateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("shareSynced")]
        [Validation(Required=false)]
        public bool? ShareSynced { get; set; }

        [NameInMap("snatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceTags> Tags { get; set; }
        public class GrafanaWorkspaceTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("upgradeVersion")]
        [Validation(Required=false)]
        public List<string> UpgradeVersion { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

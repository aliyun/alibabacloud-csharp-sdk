// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListDeployGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("DeployGroupList")]
        [Validation(Required=false)]
        public ListDeployGroupResponseBodyDeployGroupList DeployGroupList { get; set; }
        public class ListDeployGroupResponseBodyDeployGroupList : TeaModel {
            [NameInMap("DeployGroup")]
            [Validation(Required=false)]
            public List<ListDeployGroupResponseBodyDeployGroupListDeployGroup> DeployGroup { get; set; }
            public class ListDeployGroupResponseBodyDeployGroupListDeployGroup : TeaModel {
                public string AppId { get; set; }
                public string AppVersionId { get; set; }
                public string BaseComponentMetaName { get; set; }
                public string ClusterId { get; set; }
                public string ClusterName { get; set; }
                public string CpuLimit { get; set; }
                public string CpuRequest { get; set; }
                public long? CreateTime { get; set; }
                public string CsClusterId { get; set; }
                public string DeploymentName { get; set; }
                public string Env { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public int? GroupType { get; set; }
                public string Labels { get; set; }
                public long? LastUpdateTime { get; set; }
                public string MemoryLimit { get; set; }
                public string MemoryRequest { get; set; }
                public string NameSpace { get; set; }
                public string PackagePublicUrl { get; set; }
                public string PackageUrl { get; set; }
                public string PackageVersion { get; set; }
                public string PackageVersionId { get; set; }
                public string PostStart { get; set; }
                public string PreStop { get; set; }
                public string Reversion { get; set; }
                public string Selector { get; set; }
                public string Status { get; set; }
                public string Strategy { get; set; }
                public long? UpdateTime { get; set; }
                public string VExtServerGroupId { get; set; }
                public string VServerGroupId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

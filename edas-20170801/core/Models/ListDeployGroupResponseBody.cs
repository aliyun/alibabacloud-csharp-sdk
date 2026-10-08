// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListDeployGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request or a POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
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
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppVersionId")]
                [Validation(Required=false)]
                public string AppVersionId { get; set; }

                [NameInMap("BaseComponentMetaName")]
                [Validation(Required=false)]
                public string BaseComponentMetaName { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("CpuLimit")]
                [Validation(Required=false)]
                public string CpuLimit { get; set; }

                [NameInMap("CpuRequest")]
                [Validation(Required=false)]
                public string CpuRequest { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                [NameInMap("DeploymentName")]
                [Validation(Required=false)]
                public string DeploymentName { get; set; }

                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                [NameInMap("EphemeralStorageLimit")]
                [Validation(Required=false)]
                public string EphemeralStorageLimit { get; set; }

                [NameInMap("EphemeralStorageRequest")]
                [Validation(Required=false)]
                public string EphemeralStorageRequest { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public int? GroupType { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public long? LastUpdateTime { get; set; }

                [NameInMap("MemoryLimit")]
                [Validation(Required=false)]
                public string MemoryLimit { get; set; }

                [NameInMap("MemoryRequest")]
                [Validation(Required=false)]
                public string MemoryRequest { get; set; }

                [NameInMap("NameSpace")]
                [Validation(Required=false)]
                public string NameSpace { get; set; }

                [NameInMap("PackagePublicUrl")]
                [Validation(Required=false)]
                public string PackagePublicUrl { get; set; }

                [NameInMap("PackageUrl")]
                [Validation(Required=false)]
                public string PackageUrl { get; set; }

                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                [NameInMap("PackageVersionId")]
                [Validation(Required=false)]
                public string PackageVersionId { get; set; }

                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                [NameInMap("Reversion")]
                [Validation(Required=false)]
                public string Reversion { get; set; }

                [NameInMap("Selector")]
                [Validation(Required=false)]
                public string Selector { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("VExtServerGroupId")]
                [Validation(Required=false)]
                public string VExtServerGroupId { get; set; }

                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FDE-DS9R-*********************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

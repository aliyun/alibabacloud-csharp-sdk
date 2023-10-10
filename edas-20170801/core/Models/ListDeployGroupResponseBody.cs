// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListDeployGroupResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the instance group in which the application is deployed.
        /// </summary>
        [NameInMap("DeployGroupList")]
        [Validation(Required=false)]
        public ListDeployGroupResponseBodyDeployGroupList DeployGroupList { get; set; }
        public class ListDeployGroupResponseBodyDeployGroupList : TeaModel {
            [NameInMap("DeployGroup")]
            [Validation(Required=false)]
            public List<ListDeployGroupResponseBodyDeployGroupListDeployGroup> DeployGroup { get; set; }
            public class ListDeployGroupResponseBodyDeployGroupListDeployGroup : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The ID of the change process for application deployment in the instance group.
                /// </summary>
                [NameInMap("AppVersionId")]
                [Validation(Required=false)]
                public string AppVersionId { get; set; }

                /// <summary>
                /// The name of the basic component.
                /// </summary>
                [NameInMap("BaseComponentMetaName")]
                [Validation(Required=false)]
                public string BaseComponentMetaName { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the cluster.
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// The maximum number of CPU cores allowed for each application instance when the application is running.
                /// </summary>
                [NameInMap("CpuLimit")]
                [Validation(Required=false)]
                public string CpuLimit { get; set; }

                /// <summary>
                /// The number of CPU cores requested for each application instance when the application is running. Unit: cores. Value 0 indicates that no limit is set on CPU cores.
                /// </summary>
                [NameInMap("CpuRequest")]
                [Validation(Required=false)]
                public string CpuRequest { get; set; }

                /// <summary>
                /// The time when the application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the Container Service for Kubernetes (ACK) cluster.
                /// </summary>
                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                /// <summary>
                /// The name of the deployment.
                /// </summary>
                [NameInMap("DeploymentName")]
                [Validation(Required=false)]
                public string DeploymentName { get; set; }

                /// <summary>
                /// The ID of the ACK cluster.
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// The maximum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.
                /// </summary>
                [NameInMap("EphemeralStorageLimit")]
                [Validation(Required=false)]
                public string EphemeralStorageLimit { get; set; }

                /// <summary>
                /// The minimum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.
                /// </summary>
                [NameInMap("EphemeralStorageRequest")]
                [Validation(Required=false)]
                public string EphemeralStorageRequest { get; set; }

                /// <summary>
                /// The ID of the instance group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the instance group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The type of the instance group. Valid values:
                /// 
                /// *   0: default group.
                /// *   1: Canary release is disabled for traffic management.
                /// *   2: Canary release is enabled for traffic management.
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public int? GroupType { get; set; }

                /// <summary>
                /// The tag.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The time when the application was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public long? LastUpdateTime { get; set; }

                /// <summary>
                /// The maximum size of memory allowed for each application instance when the application is running. Unit: MB. Value 0 indicates that no limit is set on the memory size.
                /// </summary>
                [NameInMap("MemoryLimit")]
                [Validation(Required=false)]
                public string MemoryLimit { get; set; }

                /// <summary>
                /// The size of memory requested for each application instance when the application is running. Unit: MB. Value 0 indicates that no limit is set on the memory size.
                /// </summary>
                [NameInMap("MemoryRequest")]
                [Validation(Required=false)]
                public string MemoryRequest { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("NameSpace")]
                [Validation(Required=false)]
                public string NameSpace { get; set; }

                /// <summary>
                /// The external download URL of the deployment package.
                /// </summary>
                [NameInMap("PackagePublicUrl")]
                [Validation(Required=false)]
                public string PackagePublicUrl { get; set; }

                /// <summary>
                /// The URL of the deployment package.
                /// </summary>
                [NameInMap("PackageUrl")]
                [Validation(Required=false)]
                public string PackageUrl { get; set; }

                /// <summary>
                /// The version of the deployment package.
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// The version of the deployment package that was used to deploy an application in the instance group.
                /// </summary>
                [NameInMap("PackageVersionId")]
                [Validation(Required=false)]
                public string PackageVersionId { get; set; }

                /// <summary>
                /// The post-start script.
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// The pre-stop script.
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// The version of the application. The value progressively increases in the range of 0 to 7.
                /// </summary>
                [NameInMap("Reversion")]
                [Validation(Required=false)]
                public string Reversion { get; set; }

                /// <summary>
                /// The ID of the application deployed in the ACK cluster in Enterprise Distributed Application Service (EDAS).
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public string Selector { get; set; }

                /// <summary>
                /// The state of the application instance group. Valid values:
                /// 
                /// *   0: ready
                /// *   1: in progress
                /// *   2: successful
                /// *   3: failed
                /// *   6: terminated
                /// *   10: failed due to a system exception
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The throttling policy. This parameter is reserved.
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

                /// <summary>
                /// The time when the application was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The ID of the vServer group of the Internet-facing SLB instance associated with the instance group.
                /// </summary>
                [NameInMap("VExtServerGroupId")]
                [Validation(Required=false)]
                public string VExtServerGroupId { get; set; }

                /// <summary>
                /// The ID of the vServer group of the internal-facing Server Load Balancer (SLB) instance associated with the instance group.
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

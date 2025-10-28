// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListDeployGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the instance group in which the application is deployed.</para>
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
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3616cdca-4f92-4413-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The ID of the change process for application deployment in the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>changeorder_a**_*******_**</para>
                /// </summary>
                [NameInMap("AppVersionId")]
                [Validation(Required=false)]
                public string AppVersionId { get; set; }

                /// <summary>
                /// <para>The name of the basic component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s-sc-consumer-****</para>
                /// </summary>
                [NameInMap("BaseComponentMetaName")]
                [Validation(Required=false)]
                public string BaseComponentMetaName { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0d247b93-8d62-4e34-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc-test</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The maximum number of CPU cores allowed for each application instance when the application is running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("CpuLimit")]
                [Validation(Required=false)]
                public string CpuLimit { get; set; }

                /// <summary>
                /// <para>The number of CPU cores requested for each application instance when the application is running. Unit: cores. Value 0 indicates that no limit is set on CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CpuRequest")]
                [Validation(Required=false)]
                public string CpuRequest { get; set; }

                /// <summary>
                /// <para>The time when the application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573627695779</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Container Service for Kubernetes (ACK) cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c66e65950db<b><b>cba92f17434df1</b></b></para>
                /// </summary>
                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                /// <summary>
                /// <para>The name of the deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DeploymentName")]
                [Validation(Required=false)]
                public string DeploymentName { get; set; }

                /// <summary>
                /// <para>The ID of the ACK cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>497806cb-****-6a7</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The maximum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("EphemeralStorageLimit")]
                [Validation(Required=false)]
                public string EphemeralStorageLimit { get; set; }

                /// <summary>
                /// <para>The minimum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EphemeralStorageRequest")]
                [Validation(Required=false)]
                public string EphemeralStorageRequest { get; set; }

                /// <summary>
                /// <para>The ID of the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>577f4c50-16ee-43d8-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>_DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The type of the instance group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: default group.</description></item>
                /// <item><description>1: Canary release is disabled for traffic management.</description></item>
                /// <item><description>2: Canary release is enabled for traffic management.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public int? GroupType { get; set; }

                /// <summary>
                /// <para>The tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The time when the application was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1587888503825</para>
                /// </summary>
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public long? LastUpdateTime { get; set; }

                /// <summary>
                /// <para>The maximum size of memory allowed for each application instance when the application is running. Unit: MB. Value 0 indicates that no limit is set on the memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MemoryLimit")]
                [Validation(Required=false)]
                public string MemoryLimit { get; set; }

                /// <summary>
                /// <para>The size of memory requested for each application instance when the application is running. Unit: MB. Value 0 indicates that no limit is set on the memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("MemoryRequest")]
                [Validation(Required=false)]
                public string MemoryRequest { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ping****est</para>
                /// </summary>
                [NameInMap("NameSpace")]
                [Validation(Required=false)]
                public string NameSpace { get; set; }

                /// <summary>
                /// <para>The external download URL of the deployment package.</para>
                /// </summary>
                [NameInMap("PackagePublicUrl")]
                [Validation(Required=false)]
                public string PackagePublicUrl { get; set; }

                /// <summary>
                /// <para>The URL of the deployment package.</para>
                /// </summary>
                [NameInMap("PackageUrl")]
                [Validation(Required=false)]
                public string PackageUrl { get; set; }

                /// <summary>
                /// <para>The version of the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>E</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <para>The version of the deployment package that was used to deploy an application in the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a7d48fe8-ad8f-<b><b>-89bd-74cc1ee6</b></b></para>
                /// </summary>
                [NameInMap("PackageVersionId")]
                [Validation(Required=false)]
                public string PackageVersionId { get; set; }

                /// <summary>
                /// <para>The post-start script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// <para>The pre-stop script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// <para>The version of the application. The value progressively increases in the range of 0 to 7.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Reversion")]
                [Validation(Required=false)]
                public string Reversion { get; set; }

                /// <summary>
                /// <para>The ID of the application deployed in the ACK cluster in Enterprise Distributed Application Service (EDAS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>53dd85cc-25b4-4d0e-<b><b>-6bf5465</b></b>4</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public string Selector { get; set; }

                /// <summary>
                /// <para>The state of the application instance group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: ready</description></item>
                /// <item><description>1: in progress</description></item>
                /// <item><description>2: successful</description></item>
                /// <item><description>3: failed</description></item>
                /// <item><description>6: terminated</description></item>
                /// <item><description>10: failed due to a system exception</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The throttling policy. This parameter is reserved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RollingUpdate</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

                /// <summary>
                /// <para>The time when the application was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573627695779</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the vServer group of the Internet-facing SLB instance associated with the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-cige6******</para>
                /// </summary>
                [NameInMap("VExtServerGroupId")]
                [Validation(Required=false)]
                public string VExtServerGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the vServer group of the internal-facing Server Load Balancer (SLB) instance associated with the instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-cige6******</para>
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
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

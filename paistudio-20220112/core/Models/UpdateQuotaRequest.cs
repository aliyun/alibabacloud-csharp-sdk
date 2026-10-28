// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UpdateQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the compute cluster bound to the quota (RNQ Ray cluster). This parameter is only available for RNQ quotas and will be rejected for common quotas. It can only be modified when no operations are in progress on the quota. Unpassed sub-fields retain the current effective configurations.</para>
        /// </summary>
        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public UpdateQuotaRequestClusterSpec ClusterSpec { get; set; }
        public class UpdateQuotaRequestClusterSpec : TeaModel {
            /// <summary>
            /// <para>The cluster type. Currently, only RayCluster is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RayCluster</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The list of data sources mounted to the cluster. This parameter uses the overall replacement semantics: if it is not passed, the current state is maintained; if an empty array is passed, the list is cleared. Each element is a JSON object string that contains DataSourceId or Uri (one of them is required and they are mutually exclusive) and an optional MountPath.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            /// <summary>
            /// <para>The container image used by the Ray cluster. If this parameter is explicitly passed, the system switches to this image. If it is left empty and the data sources remain unchanged, and GetQuota returns UpgradeAvailable=true, this update is considered an upgrade to the platform default image. To keep the current image, explicitly pass the current value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsw-registry-vpc.ap-southeast-1.cr.aliyuncs.com/pai-common/ray-runtime</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

        }

        /// <summary>
        /// <para>The description of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test quota</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to execute the current ClusterSpec change as a rolling upgrade (draining and migrating nodes one by one to the new cluster) instead of the default stop-and-rebuild method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableGracefulUpgrade")]
        [Validation(Required=false)]
        public bool? EnableGracefulUpgrade { get; set; }

        /// <summary>
        /// <para>The tuning parameters for the migration process. This parameter is only allowed when EnableGracefulUpgrade is set to true.</para>
        /// </summary>
        [NameInMap("GracefulUpgradeConfig")]
        [Validation(Required=false)]
        public UpdateQuotaRequestGracefulUpgradeConfig GracefulUpgradeConfig { get; set; }
        public class UpdateQuotaRequestGracefulUpgradeConfig : TeaModel {
            /// <summary>
            /// <para>The timeout limit for Ray draining of a single node. After the timeout, the node is still directly scaled down, which does not cause the upgrade to fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("DrainTimeoutSeconds")]
            [Validation(Required=false)]
            public long? DrainTimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The migration window width, which is the maximum number of workers in the old cluster that are simultaneously in an unavailable state (draining or drained and pending removal), that is, the number of nodes migrated in parallel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25%</para>
            /// </summary>
            [NameInMap("MaxUnavailable")]
            [Validation(Required=false)]
            public string MaxUnavailable { get; set; }

            /// <summary>
            /// <para>The number of workers in the old cluster that are kept in a schedulable state while waiting for the remaining Ray tasks in the old cluster to complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TaskDrainReserveWorkers")]
            [Validation(Required=false)]
            public long? TaskDrainReserveWorkers { get; set; }

        }

        /// <summary>
        /// <para>The list of user-defined labels.
        /// This is a full update.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>Specifies whether to pass the default GPU driver configuration to child quotas.</para>
        /// </summary>
        [NameInMap("PropagateDefaultGPUDriver")]
        [Validation(Required=false)]
        public bool? PropagateDefaultGPUDriver { get; set; }

        /// <summary>
        /// <para>The queuing strategy for tasks on the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PaiStrategyIntelligent</para>
        /// </summary>
        [NameInMap("QueueStrategy")]
        [Validation(Required=false)]
        public string QueueStrategy { get; set; }

        /// <summary>
        /// <para>The resource quota configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("QuotaConfig")]
        [Validation(Required=false)]
        public QuotaConfig QuotaConfig { get; set; }

        /// <summary>
        /// <para>The name of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

    }

}

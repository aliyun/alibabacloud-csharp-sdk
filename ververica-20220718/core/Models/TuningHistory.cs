// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TuningHistory : TeaModel {
        /// <summary>
        /// <para>The action type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SCALE_UP_PARALLELISM: scales up parallelism.</description></item>
        /// <item><description>SCALE_DOWN_PARALLELISM: scales down parallelism.</description></item>
        /// <item><description>SCALE_UP_MEMORY: scales up memory.</description></item>
        /// <item><description>RESTART: restarts the job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_UP_PARALLELISM</para>
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The additional annotations.</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// <para>The full path name of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespaces/ns-xxx/deployments/6aa0d4d1-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("deploymentName")]
        [Validation(Required=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// <para>Indicates whether this is a hot update. A value of true indicates that the change takes effect without restarting the job. A value of false indicates that the job must be restarted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isHotUpdate")]
        [Validation(Required=false)]
        public bool? IsHotUpdate { get; set; }

        /// <summary>
        /// <para>The ID of the associated job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b462c053-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The resource configuration after tuning. This value may be null if the tuning failed.</para>
        /// </summary>
        [NameInMap("newResourceSetting")]
        [Validation(Required=false)]
        public TuningHistoryNewResourceSetting NewResourceSetting { get; set; }
        public class TuningHistoryNewResourceSetting : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores per TaskManager.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public double? Cpu { get; set; }

            /// <summary>
            /// <para>The memory per TaskManager, in a format such as 4 Gi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2 Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The parallelism.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

        }

        /// <summary>
        /// <para>The resource configuration before tuning.</para>
        /// </summary>
        [NameInMap("oldResourceSetting")]
        [Validation(Required=false)]
        public TuningHistoryOldResourceSetting OldResourceSetting { get; set; }
        public class TuningHistoryOldResourceSetting : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores per TaskManager.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public double? Cpu { get; set; }

            /// <summary>
            /// <para>The memory per TaskManager, in a format such as 4 Gi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2 Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The parallelism.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

        }

        /// <summary>
        /// <para>The trigger timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718270936000</para>
        /// </summary>
        [NameInMap("triggerTime")]
        [Validation(Required=false)]
        public long? TriggerTime { get; set; }

        /// <summary>
        /// <para>The UUID of the tuning record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06d81ae2-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("tuningId")]
        [Validation(Required=false)]
        public string TuningId { get; set; }

        /// <summary>
        /// <para>The tuning message. This is an internationalized, human-readable string that is not recommended for programmatic parsing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scale up parallelism from 2 to 4</para>
        /// </summary>
        [NameInMap("tuningMessage")]
        [Validation(Required=false)]
        public string TuningMessage { get; set; }

        /// <summary>
        /// <para>The tuning state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUCCESS: The tuning succeeded.</description></item>
        /// <item><description>FAILED: The tuning failed.</description></item>
        /// <item><description>EXECUTING: The tuning is in progress.</description></item>
        /// <item><description>TERMINATED: The tuning was terminated.</description></item>
        /// <item><description>FAILED_WITH_ROLLBACK_SUCCESS: The tuning failed but the rollback succeeded.</description></item>
        /// <item><description>FAILED_WITH_ROLLBACK_FAILED: The tuning failed and the rollback also failed.</description></item>
        /// <item><description>FAILED_WITH_RESOURCE_LACK: The tuning failed due to insufficient resources.</description></item>
        /// <item><description>FAILED_WITH_SAME_RESOURCE_SETTING: The tuning failed because the resource configuration did not change.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("tuningState")]
        [Validation(Required=false)]
        public string TuningState { get; set; }

    }

}

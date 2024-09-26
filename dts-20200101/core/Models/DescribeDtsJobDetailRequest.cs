// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobDetailRequest : TeaModel {
        /// <summary>
        /// <para>DescribeDtsJobDetail</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsta7w132u12h****</para>
        /// </summary>
        [NameInMap("DtsInstanceID")]
        [Validation(Required=false)]
        public string DtsInstanceID { get; set; }

        /// <summary>
        /// <para>The state of the data migration or data synchronization task.</para>
        /// <para>Valid values for a data migration task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The migration is not started.</description></item>
        /// <item><description><b>Migrating</b>: The migration is in progress.</description></item>
        /// <item><description><b>Failed</b>: The migration failed.</description></item>
        /// <item><description><b>Finished</b>: The migration is complete.</description></item>
        /// </list>
        /// <para>Valid values for a data synchronization task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is in precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>Initializing</b>: The task is performing initial synchronization.</description></item>
        /// <item><description><b>InitializeFailed</b>: Initial synchronization failed.</description></item>
        /// <item><description><b>Synchronizing</b>: The task is in progress.</description></item>
        /// <item><description><b>Failed</b>: The task failed to synchronize data.</description></item>
        /// <item><description><b>Suspending</b>: The task is paused.</description></item>
        /// <item><description><b>Modifying</b>: The objects in the task are being modified.</description></item>
        /// <item><description><b>Finished</b>: The task is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ta7w132u12h****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>默认为false，返回最近的一个同步子任务</para>
        /// </summary>
        [NameInMap("SyncSubJobHistory")]
        [Validation(Required=false)]
        public bool? SyncSubJobHistory { get; set; }

        /// <summary>
        /// <para>Queries the details of a data migration, data synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}

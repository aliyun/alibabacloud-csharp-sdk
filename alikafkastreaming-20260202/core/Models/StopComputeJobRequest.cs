// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class StopComputeJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the computing instance, excluding the region name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_streaming-cn-pe333xxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the computing job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_enrichment</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The job stop strategy. Default value: <c>CANCEL</c> if omitted.</para>
        /// <list type="bullet">
        /// <item><description><c>CANCEL</c>: Stops the job directly and skips the current savepoint.</description></item>
        /// <item><description><c>STOP_WITH_SAVEPOINT</c>: Creates a savepoint and then stops the job.</description></item>
        /// <item><description><c>STOP_WITH_DRAIN</c>: Stops the job in drain mode and creates a savepoint, triggering the output of event time windows.</description></item>
        /// </list>
        /// <para>Strategies with savepoints apply only to running production jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STOP_WITH_SAVEPOINT</para>
        /// </summary>
        [NameInMap("StopStrategy")]
        [Validation(Required=false)]
        public string StopStrategy { get; set; }

    }

}

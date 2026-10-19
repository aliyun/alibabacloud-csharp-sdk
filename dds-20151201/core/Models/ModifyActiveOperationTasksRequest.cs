// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the O&amp;M tasks. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the DescribeActiveOperationTasks operation to retrieve the O&amp;M task IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111,22222</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately enter the execution scheduling phase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No. This is the default value.</description></item>
        /// <item><description>1: Yes.<remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is set to 0, SwitchTime takes effect. If this parameter is set to 1, SwitchTime does not take effect, the task start time is set to the current time, and the switchover time is automatically calculated based on the new start time.</description></item>
        /// <item><description>Immediately entering the execution scheduling phase does not mean an immediate switchover. Instead, the task immediately enters the preparing state, and the switchover is performed after the preparation is complete. You can call the DescribeActiveOperationTasks operation and check the value of the PrepareInterval response parameter to obtain the preparation time.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ImmediateStart")]
        [Validation(Required=false)]
        public int? ImmediateStart { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The scheduled switchover time to be set. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The time cannot be later than the latest operation time. You can call the DescribeActiveOperationTasks operation and check the value of the Deadline response parameter to obtain the latest operation time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-17T18:50:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

    }

}

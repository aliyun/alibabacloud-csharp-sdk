// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The O&amp;M task IDs. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call DescribeActiveOperationTasks to obtain O&amp;M task IDs.</para>
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
        /// <para>Specifies whether to immediately start the execution scheduling.</para>
        /// <list type="bullet">
        /// <item><description>0: No. This is the default value.</description></item>
        /// <item><description>1: Yes.<remarks>
        /// <list type="bullet">
        /// <item><description>If the value is 0, the SwitchTime parameter takes effect. If the value is 1, the SwitchTime parameter does not take effect. The task start time is set to the current time, and the switchover time is automatically calculated based on the new start time.</description></item>
        /// <item><description>Immediately starting the execution scheduling does not mean an immediate switchover. Instead, the task immediately enters the Preparing state. After the preparation is complete, the switchover is performed. You can call DescribeActiveOperationTasks and check the value of the PrepareInterval response parameter to obtain the preparation time.</description></item>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The scheduled switchover time to set. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// <remarks>
        /// <para>The time cannot be later than the latest operation time. You can call DescribeActiveOperationTasks and check the value of the Deadline response parameter to obtain the latest operation time.</para>
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

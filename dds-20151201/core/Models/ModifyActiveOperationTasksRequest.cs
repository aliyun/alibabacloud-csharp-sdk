// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the O\&amp;M tasks. Separate multiple task IDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the DescribeActiveOperationTask operation to query the IDs of O\&amp;M tasks.</para>
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
        /// <para>Specifies whether to immediately start scheduling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): Scheduling is not started immediately.</description></item>
        /// <item><description>1: Scheduling is started immediately.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to 0, the SwitchTime parameter takes effect. If you set this parameter to 1, the SwitchTime parameter does not take effect. In this case, the start time of the task is the current time, and the system determines the switching time based on the start time.</description></item>
        /// <item><description>Immediate scheduling specifies that the task enters the preparing state instead of being executed immediately. After the preparation is complete, the switchover is performed. You can call the DescribeActiveOperationTasks operation to query the preparation time that is returned for the PrepareInterval parameter.</description></item>
        /// </list>
        /// </remarks>
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

        /// <summary>
        /// <para>The scheduled switching time that you want to specify. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The time that is specified by the SwitchTime parameter cannot be later than the time that is specified by the Deadline parameter. You can call the DescribeActiveOperationTasks operation to query the latest switching time that is returned for the Deadline parameter.</para>
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

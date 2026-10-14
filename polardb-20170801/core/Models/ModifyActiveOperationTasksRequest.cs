// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to immediately start execution scheduling.</para>
        /// <list type="bullet">
        /// <item><description>0: No (default).</description></item>
        /// <item><description>1: Yes.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the value is 0, the SwitchTime parameter is required.</description></item>
        /// <item><description>If the value is 1, the SwitchTime parameter does not take effect. The event start time is set to the current time, and the switchover time is automatically calculated based on the new start time. The event immediately enters execution scheduling (not an immediate switchover) and begins pre-switchover preparations. The switchover is performed after the preparations are complete. You can call the DescribeActiveOperationTasks operation and obtain the preparation time from the PrepareInterval response parameter.</description></item>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the region information of all clusters under the target account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The planned switchover time to set. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The time cannot be later than the deadline.</description></item>
        /// <item><description>You can call the DescribeActiveOperationTasks operation and obtain the deadline from the Deadline response parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-25T06:00:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The list of task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111,22222</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public string TaskIds { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The O&amp;M event IDs. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111721,1111718</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately start execution scheduling.</para>
        /// <list type="bullet">
        /// <item><description>0: No. (Default)</description></item>
        /// <item><description>1: Yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value is 0, SwitchTime takes effect. If the value is 1, SwitchTime does not take effect. The event start time is set to the current time, and the switchover time is automatically calculated based on the new start time.
        /// The event immediately enters execution scheduling (not an immediate switchover). Pre-switchover preparations begin, and the switchover is performed after the preparations are complete. Call DescribeActiveOperationTasks and check the value of the PrepareInterval response parameter to obtain the preparation time.</para>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The planned switchover time to set. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// <remarks>
        /// <para> The time cannot be later than the deadline. Call DescribeActiveOperationTasks and check the value of the Deadline response parameter to obtain the deadline.</para>
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

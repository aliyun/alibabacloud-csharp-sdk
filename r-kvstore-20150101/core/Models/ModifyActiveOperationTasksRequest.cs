// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the O\&amp;M events. Separate multiple event IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111721,1111718</para>
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
        /// <para> If you set this parameter to 0, the SwitchTime parameter takes effect. If you set this parameter to 1, the SwitchTime parameter does not take effect. In this case, the start time of the event is set to the current time, and the system determines the switching time based on the start time. Scheduling is started immediately, which is a prerequisite for the switchover. Then, the switchover is performed. You can call the DescribeActiveOperationTasks operation to query the preparation time that is returned for the PrepareInterval parameter.</para>
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
        /// <para>The scheduled switching time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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

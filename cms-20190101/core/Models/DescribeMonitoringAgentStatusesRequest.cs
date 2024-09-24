// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentStatusesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the availability monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>126****</para>
        /// </summary>
        [NameInMap("HostAvailabilityTaskId")]
        [Validation(Required=false)]
        public string HostAvailabilityTaskId { get; set; }

        /// <summary>
        /// <para>The instance IDs. Separate multiple instance IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-hp3dunahluwajv6f****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

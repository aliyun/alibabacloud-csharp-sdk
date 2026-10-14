// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class EventRedeployInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The system event ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-d71ff150945b9c02eb6ebc0016328468</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The O\&amp;M task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>immediate: Immediate execution.</para>
        /// </description></item>
        /// <item><description><para>scheduled: Scheduled execution.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immediate</para>
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        /// <summary>
        /// <para>The scheduled execution time, specified as a timestamp in milliseconds. This parameter is required if \&quot;OpsType\&quot; is set to \&quot;scheduled\&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742452232000</para>
        /// </summary>
        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public long? PlanTime { get; set; }

        [NameInMap("PlanUtcTime")]
        [Validation(Required=false)]
        public string PlanUtcTime { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-55qi8m11rr53c4i964md8a00l</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}

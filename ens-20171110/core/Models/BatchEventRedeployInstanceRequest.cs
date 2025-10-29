// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BatchEventRedeployInstanceRequest : TeaModel {
        /// <summary>
        /// <para>List of events.</para>
        /// </summary>
        [NameInMap("EventInfos")]
        [Validation(Required=false)]
        public List<BatchEventRedeployInstanceRequestEventInfos> EventInfos { get; set; }
        public class BatchEventRedeployInstanceRequestEventInfos : TeaModel {
            /// <summary>
            /// <para>System event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-d71ff150945b9c02eb6ebc0016328468</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>Operation type, value range:</para>
            /// <list type="bullet">
            /// <item><description>immediate: Execute immediately.</description></item>
            /// <item><description>scheduled: Scheduled execution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1742452232000</para>
            /// </summary>
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }

            /// <summary>
            /// <para>Scheduled execution time, in timestamp, unit is milliseconds. This field is required when OpsType=scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>immediate</para>
            /// </summary>
            [NameInMap("PlanTime")]
            [Validation(Required=false)]
            public long? PlanTime { get; set; }

            /// <summary>
            /// <para>Resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-55qi8m11rr53c4i964md8a00l</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BatchEventRebootInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("EventInfos")]
        [Validation(Required=false)]
        public List<BatchEventRebootInstanceRequestEventInfos> EventInfos { get; set; }
        public class BatchEventRebootInstanceRequestEventInfos : TeaModel {
            /// <summary>
            /// <para>The system event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-4452cec5a8f8eb9b2879a054207687d6</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The O&amp;M task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>immediate: immediate execution.</para>
            /// </description></item>
            /// <item><description><para>scheduled: scheduled execution.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>immediate</para>
            /// </summary>
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }

            /// <summary>
            /// <para>The scheduled execution time. The value is a timestamp in milliseconds. This parameter is required when OpsType is set to scheduled.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>n-54hi3ffi63zrjt4wzx9mepeyh</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

    }

}

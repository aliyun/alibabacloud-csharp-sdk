// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BatchEventRebootInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The details of events.</para>
        /// </summary>
        [NameInMap("EventInfos")]
        [Validation(Required=false)]
        public List<BatchEventRebootInstanceRequestEventInfos> EventInfos { get; set; }
        public class BatchEventRebootInstanceRequestEventInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the system event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-4452cec5a8f8eb9b2879a054207687d6</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The type of the O\&amp;M task.</para>
            /// <list type="bullet">
            /// <item><description>immediate</description></item>
            /// <item><description>scheduled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>immediate</para>
            /// </summary>
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }

            /// <summary>
            /// <para>The execution time of the reservation. The timestamp is measured in milliseconds. If the OpsType parameter is set to scheduled, this parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742452232000</para>
            /// </summary>
            [NameInMap("PlanTime")]
            [Validation(Required=false)]
            public long? PlanTime { get; set; }

            /// <summary>
            /// <para>A client ID.</para>
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

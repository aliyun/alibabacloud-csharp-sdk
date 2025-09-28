// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BatchEventRebootInstanceRequest : TeaModel {
        [NameInMap("EventInfos")]
        [Validation(Required=false)]
        public List<BatchEventRebootInstanceRequestEventInfos> EventInfos { get; set; }
        public class BatchEventRebootInstanceRequestEventInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>e-4452cec5a8f8eb9b2879a054207687d6</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>immediate</para>
            /// </summary>
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1742452232000</para>
            /// </summary>
            [NameInMap("PlanTime")]
            [Validation(Required=false)]
            public long? PlanTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n-54hi3ffi63zrjt4wzx9mepeyh</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

    }

}

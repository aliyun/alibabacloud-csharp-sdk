// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BatchEventMigrateInstanceRequest : TeaModel {
        [NameInMap("EventInfos")]
        [Validation(Required=false)]
        public List<BatchEventMigrateInstanceRequestEventInfos> EventInfos { get; set; }
        public class BatchEventMigrateInstanceRequestEventInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abandon</para>
            /// </summary>
            [NameInMap("DataPolicy")]
            [Validation(Required=false)]
            public string DataPolicy { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-d71ff150945b9c02eb6ebc0016328468</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>immediate</para>
            /// </summary>
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1742452232000</para>
            /// </summary>
            [NameInMap("PlanTime")]
            [Validation(Required=false)]
            public long? PlanTime { get; set; }

            /// <summary>
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

}

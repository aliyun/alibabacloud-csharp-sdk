// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiagnosticMetricSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the diagnostic metric set, which is the unique identifier of the set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dms-o7ymuutup5l*****</para>
        /// </summary>
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

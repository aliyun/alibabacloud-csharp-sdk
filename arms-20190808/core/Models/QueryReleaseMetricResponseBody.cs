// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryReleaseMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned metric data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;data&quot;:{&quot;SystemCpuUser&quot;:{&quot;all&quot;:[{&quot;date&quot;:1632798718000,&quot;val&quot;:4.3277,&quot;dim&quot;:&quot;SystemCpuUser&quot;},{&quot;date&quot;:1632798733000,&quot;val&quot;:8.1091,&quot;dim&quot;:&quot;SystemCpuUser&quot;}]},&quot;SystemMemUtil&quot;:{&quot;all&quot;:[{&quot;date&quot;:1632798718000,&quot;val&quot;:73.4227,&quot;dim&quot;:&quot;SystemMemUtil&quot;},{&quot;date&quot;:1632798733000,&quot;val&quot;:93.0977,&quot;dim&quot;:&quot;SystemMemUtil&quot;}]}},&quot;success&quot;:true}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46355DD8-FC56-40C5-BFC6-269DE4F9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

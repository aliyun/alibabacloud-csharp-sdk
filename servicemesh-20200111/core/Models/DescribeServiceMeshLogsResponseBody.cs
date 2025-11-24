// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<DescribeServiceMeshLogsResponseBodyLogs> Logs { get; set; }
        public class DescribeServiceMeshLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// <para>The point in time when the logs were generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-19T15:21:53+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The content of the logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[RequestID: 31d3a0f0-07ed-4f6e-9004-1804498c****, UID-110982038403****] c096d641835af4658827a4c66c234**** | Start to add cluster c186a6d9641a24098b5499d4d8313****</para>
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// <para>The ASM instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca04bc38979214bf2882be79d39b4****</para>
            /// </summary>
            [NameInMap("ServiceMeshId")]
            [Validation(Required=false)]
            public string ServiceMeshId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

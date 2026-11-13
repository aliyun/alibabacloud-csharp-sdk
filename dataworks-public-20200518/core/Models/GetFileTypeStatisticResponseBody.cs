// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFileTypeStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The node types and counts.</para>
        /// </summary>
        [NameInMap("ProgramTypeAndCounts")]
        [Validation(Required=false)]
        public List<GetFileTypeStatisticResponseBodyProgramTypeAndCounts> ProgramTypeAndCounts { get; set; }
        public class GetFileTypeStatisticResponseBodyProgramTypeAndCounts : TeaModel {
            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The node type. Common types are as follows: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (virtual node), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object check), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant node), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment node), and 1221 (PyODPS 3).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDFSDFSDF-SDFSDF-SDFDSF-SDFSDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

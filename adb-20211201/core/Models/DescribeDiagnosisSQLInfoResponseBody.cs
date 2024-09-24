// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisSQLInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried execution information, including the SQL statement, statistics, execution plan, and operator information.</para>
        /// </summary>
        [NameInMap("DiagnosisSQLInfo")]
        [Validation(Required=false)]
        public string DiagnosisSQLInfo { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried execution information by stage.</para>
        /// </summary>
        [NameInMap("StageInfos")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisSQLInfoResponseBodyStageInfos> StageInfos { get; set; }
        public class DescribeDiagnosisSQLInfoResponseBodyStageInfos : TeaModel {
            /// <summary>
            /// <para>The total amount of input data in the stage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("InputDataSize")]
            [Validation(Required=false)]
            public long? InputDataSize { get; set; }

            /// <summary>
            /// <para>The total number of input rows in the stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("InputRows")]
            [Validation(Required=false)]
            public long? InputRows { get; set; }

            /// <summary>
            /// <para>The total amount of time consumed by all operators in the stage. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("OperatorCost")]
            [Validation(Required=false)]
            public long? OperatorCost { get; set; }

            /// <summary>
            /// <para>The total amount of output data in the stage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("OutputDataSize")]
            [Validation(Required=false)]
            public long? OutputDataSize { get; set; }

            /// <summary>
            /// <para>The total number of output rows in the stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("OutputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// <para>The total peak memory of the stage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2341</para>
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// <para>The execution progress of the stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public double? Progress { get; set; }

            /// <summary>
            /// <para>The stage ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stage[26]</para>
            /// </summary>
            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// <para>The state of the stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}

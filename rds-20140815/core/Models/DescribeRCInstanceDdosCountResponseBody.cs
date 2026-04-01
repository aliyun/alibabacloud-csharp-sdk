// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceDdosCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances that are under DDoS attacks.</para>
        /// </summary>
        [NameInMap("DdosCount")]
        [Validation(Required=false)]
        public DescribeRCInstanceDdosCountResponseBodyDdosCount DdosCount { get; set; }
        public class DescribeRCInstanceDdosCountResponseBodyDdosCount : TeaModel {
            /// <summary>
            /// <para>The number of instances for which blackhole filtering is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BlackholeCount")]
            [Validation(Required=false)]
            public string BlackholeCount { get; set; }

            /// <summary>
            /// <para>The number of instances for which traffic scrubbing is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public string DefenseCount { get; set; }

            /// <summary>
            /// <para>The total number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("InstacenCount")]
            [Validation(Required=false)]
            public string InstacenCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F77F3176-AAEA-5836-B2B4-A854E3ED****_Zv**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

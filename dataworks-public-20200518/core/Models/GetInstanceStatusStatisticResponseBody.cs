// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The numbers of instances in different states.</para>
        /// </summary>
        [NameInMap("StatusCount")]
        [Validation(Required=false)]
        public GetInstanceStatusStatisticResponseBodyStatusCount StatusCount { get; set; }
        public class GetInstanceStatusStatisticResponseBodyStatusCount : TeaModel {
            /// <summary>
            /// <para>The number of instances that failed to run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public int? FailureCount { get; set; }

            /// <summary>
            /// <para>The number of instances that are not run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotRunCount")]
            [Validation(Required=false)]
            public int? NotRunCount { get; set; }

            /// <summary>
            /// <para>The number of instances that are running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            /// <summary>
            /// <para>The number of instances that are successfully run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The total number of instances returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The number of instances that are waiting for resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WaitResCount")]
            [Validation(Required=false)]
            public int? WaitResCount { get; set; }

            /// <summary>
            /// <para>The number of instances that are waiting to run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WaitTimeCount")]
            [Validation(Required=false)]
            public int? WaitTimeCount { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeIdentifyTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the identification task.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeIdentifyTaskStatusResponseBodyContent Content { get; set; }
        public class DescribeIdentifyTaskStatusResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The running status of the task.</para>
            /// <list type="bullet">
            /// <item><description><para>0: Not started</para>
            /// </description></item>
            /// <item><description><para>1: Running</para>
            /// </description></item>
            /// <item><description><para>2: Paused</para>
            /// </description></item>
            /// <item><description><para>3: Stopped</para>
            /// </description></item>
            /// <item><description><para>200: Completed</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71064826-726F-4ADA-B879-05D8055476FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

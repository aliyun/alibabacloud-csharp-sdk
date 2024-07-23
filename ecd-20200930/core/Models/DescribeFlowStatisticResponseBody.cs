// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFlowStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of available cloud computers in the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DesktopCount")]
        [Validation(Required=false)]
        public int? DesktopCount { get; set; }

        /// <summary>
        /// <para>The traffic statistics.</para>
        /// </summary>
        [NameInMap("DesktopFlowStatistic")]
        [Validation(Required=false)]
        public List<DescribeFlowStatisticResponseBodyDesktopFlowStatistic> DesktopFlowStatistic { get; set; }
        public class DescribeFlowStatisticResponseBodyDesktopFlowStatistic : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-8bslxqq0csytn****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desktop-1</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The traffic amount. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("FlowIn")]
            [Validation(Required=false)]
            public string FlowIn { get; set; }

            /// <summary>
            /// <para>The traffic ranking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FlowRank")]
            [Validation(Required=false)]
            public int? FlowRank { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

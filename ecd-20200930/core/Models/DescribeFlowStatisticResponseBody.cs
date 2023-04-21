// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFlowStatisticResponseBody : TeaModel {
        /// <summary>
        /// The number of available cloud desktops in the workspace.
        /// </summary>
        [NameInMap("DesktopCount")]
        [Validation(Required=false)]
        public int? DesktopCount { get; set; }

        /// <summary>
        /// Details of the traffic that is consumed by cloud desktops.
        /// </summary>
        [NameInMap("DesktopFlowStatistic")]
        [Validation(Required=false)]
        public List<DescribeFlowStatisticResponseBodyDesktopFlowStatistic> DesktopFlowStatistic { get; set; }
        public class DescribeFlowStatisticResponseBodyDesktopFlowStatistic : TeaModel {
            /// <summary>
            /// The ID of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The amount of the traffic. Unit: KB.
            /// </summary>
            [NameInMap("FlowIn")]
            [Validation(Required=false)]
            public string FlowIn { get; set; }

            /// <summary>
            /// The traffic ranking.
            /// </summary>
            [NameInMap("FlowRank")]
            [Validation(Required=false)]
            public int? FlowRank { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

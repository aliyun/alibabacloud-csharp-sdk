// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUserFlowStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9552AD68-18EA-4074-B27D-40040FBA9683</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SagStatistics")]
        [Validation(Required=false)]
        public DescribeUserFlowStatisticsResponseBodySagStatistics SagStatistics { get; set; }
        public class DescribeUserFlowStatisticsResponseBodySagStatistics : TeaModel {
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<DescribeUserFlowStatisticsResponseBodySagStatisticsStatistics> Statistics { get; set; }
            public class DescribeUserFlowStatisticsResponseBodySagStatisticsStatistics : TeaModel {
                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                [NameInMap("TotalLeaveBytes")]
                [Validation(Required=false)]
                public string TotalLeaveBytes { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}

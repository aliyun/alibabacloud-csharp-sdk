// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUserFlowStatisticsResponseBody : TeaModel {
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
                public string TotalBytes { get; set; }
                public string UserName { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagOnlineClientStatisticsResponseBody : TeaModel {
        [NameInMap("SagStatistics")]
        [Validation(Required=false)]
        public DescribeSagOnlineClientStatisticsResponseBodySagStatistics SagStatistics { get; set; }
        public class DescribeSagOnlineClientStatisticsResponseBodySagStatistics : TeaModel {
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<DescribeSagOnlineClientStatisticsResponseBodySagStatisticsStatistics> Statistics { get; set; }
            public class DescribeSagOnlineClientStatisticsResponseBodySagStatisticsStatistics : TeaModel {
                public string SmartAGId { get; set; }
                public string OnlineCount { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

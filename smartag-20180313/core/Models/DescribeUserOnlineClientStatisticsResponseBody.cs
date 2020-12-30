// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUserOnlineClientStatisticsResponseBody : TeaModel {
        [NameInMap("UserStatistics")]
        [Validation(Required=false)]
        public DescribeUserOnlineClientStatisticsResponseBodyUserStatistics UserStatistics { get; set; }
        public class DescribeUserOnlineClientStatisticsResponseBodyUserStatistics : TeaModel {
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<DescribeUserOnlineClientStatisticsResponseBodyUserStatisticsStatistics> Statistics { get; set; }
            public class DescribeUserOnlineClientStatisticsResponseBodyUserStatisticsStatistics : TeaModel {
                public string OnlineCount { get; set; }
                public string UserName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

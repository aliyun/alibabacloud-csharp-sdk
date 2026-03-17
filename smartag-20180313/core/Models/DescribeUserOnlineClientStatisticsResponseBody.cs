// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUserOnlineClientStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14846A6A-2192-4F6A-B272-B8BD68EBC89B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserStatistics")]
        [Validation(Required=false)]
        public DescribeUserOnlineClientStatisticsResponseBodyUserStatistics UserStatistics { get; set; }
        public class DescribeUserOnlineClientStatisticsResponseBodyUserStatistics : TeaModel {
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<DescribeUserOnlineClientStatisticsResponseBodyUserStatisticsStatistics> Statistics { get; set; }
            public class DescribeUserOnlineClientStatisticsResponseBodyUserStatisticsStatistics : TeaModel {
                [NameInMap("OnlineCount")]
                [Validation(Required=false)]
                public string OnlineCount { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagOnlineClientStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9EC839B6-0EA5-4F19-A4B7-A9E465D057AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SagStatistics")]
        [Validation(Required=false)]
        public DescribeSagOnlineClientStatisticsResponseBodySagStatistics SagStatistics { get; set; }
        public class DescribeSagOnlineClientStatisticsResponseBodySagStatistics : TeaModel {
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<DescribeSagOnlineClientStatisticsResponseBodySagStatisticsStatistics> Statistics { get; set; }
            public class DescribeSagOnlineClientStatisticsResponseBodySagStatisticsStatistics : TeaModel {
                [NameInMap("OnlineCount")]
                [Validation(Required=false)]
                public string OnlineCount { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

            }

        }

    }

}

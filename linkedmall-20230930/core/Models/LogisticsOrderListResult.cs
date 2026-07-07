// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsOrderListResult : TeaModel {
        /// <summary>
        /// <para>Collection of logistics orders</para>
        /// </summary>
        [NameInMap("logisticsOrderList")]
        [Validation(Required=false)]
        public List<LogisticsOrderResult> LogisticsOrderList { get; set; }

        /// <summary>
        /// <para>Request ID for the API call</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

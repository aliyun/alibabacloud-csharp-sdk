// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySpeechBroadcastHourRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~) of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Valid values: 1 to 2000.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of **PageToken**.
        /// 
        /// For example, if you want to query the results on Page n, you must set PageToken to the token that you obtained when you queried the results on Page n - 1.
        /// </summary>
        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// The end time of the hour in which you want to query data. Example: 2020090919, which specifies 19:00 on September 9, 2020.
        /// </summary>
        [NameInMap("QueryDateTimeHour")]
        [Validation(Required=false)]
        public string QueryDateTimeHour { get; set; }

        /// <summary>
        /// The code of the speech sharing task.
        /// 
        /// You can obtain the **code** on the **Shared Corpus Management** page of **Speech Sending Voice Broadcasting Service**.
        /// </summary>
        [NameInMap("ShareTaskCode")]
        [Validation(Required=false)]
        public string ShareTaskCode { get; set; }

    }

}

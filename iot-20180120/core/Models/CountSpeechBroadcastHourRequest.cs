// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CountSpeechBroadcastHourRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see the [Overview](~~356505~~) topic of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The end time of the hour in which you want to query the number of broadcasted speeches. Example: 2020090919, which indicates 19:00 on September 9, 2020.
        /// </summary>
        [NameInMap("QueryDateTimeHour")]
        [Validation(Required=false)]
        public string QueryDateTimeHour { get; set; }

        /// <summary>
        /// The code that is used to share the speeches.
        /// 
        /// You can obtain the **code** on the **Shared Corpus Management** page of **Speech Sending Voice Broadcasting Service**.
        /// </summary>
        [NameInMap("ShareTaskCode")]
        [Validation(Required=false)]
        public string ShareTaskCode { get; set; }

    }

}

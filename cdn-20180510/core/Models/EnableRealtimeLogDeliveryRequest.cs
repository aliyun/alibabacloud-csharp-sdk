// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class EnableRealtimeLogDeliveryRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name for which you want to enable real-time log delivery. You can specify multiple domain names and separate them with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}

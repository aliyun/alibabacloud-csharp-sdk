// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class OpenCdnServiceRequest : TeaModel {
        /// <summary>
        /// The metering method of Alibaba Cloud CDN. A value of **PayByTraffic** indicates that the metering method is pay-by-data-transfer.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

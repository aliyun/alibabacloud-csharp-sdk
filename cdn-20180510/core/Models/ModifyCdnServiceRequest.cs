// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ModifyCdnServiceRequest : TeaModel {
        /// <summary>
        /// <para>The new metering method for Alibaba Cloud CDN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
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

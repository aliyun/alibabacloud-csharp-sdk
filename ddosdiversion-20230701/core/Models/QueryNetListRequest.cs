// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class QueryNetListRequest : TeaModel {
        /// <summary>
        /// The primary CIDR block of the anti-DDoS diversion instance for which an extended CIDR block is configured. If no extended CIDR blocks are configured for the anti-DDoS diversion instance, leave this parameter empty.
        /// </summary>
        [NameInMap("MainNet")]
        [Validation(Required=false)]
        public string MainNet { get; set; }

        /// <summary>
        /// The scheduling mode. Valid values:
        /// 
        /// - manual: manual scheduling
        /// - netflow-auto: automatic scheduling
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The CIDR block of the anti-DDoS diversion instance.
        /// 
        /// 
        /// > If no extended CIDR blocks are configured for the anti-DDoS diversion instance, this parameter specifies the CIDR block of the instance. If an extended CIDR block is configured for the anti-DDoS diversion instance, this parameter specifies the extended CIDR block that is configured for the instance. If this parameter is specified, the MainNet parameter is required.
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public string Net { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 100.
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public long? Num { get; set; }

        /// <summary>
        /// The page number. Default value: 1
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The ID of the anti-DDoS diversion instance.
        /// </summary>
        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

    }

}

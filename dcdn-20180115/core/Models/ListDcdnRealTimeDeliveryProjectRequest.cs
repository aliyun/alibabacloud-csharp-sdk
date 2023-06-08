// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ListDcdnRealTimeDeliveryProjectRequest : TeaModel {
        /// <summary>
        /// The type of the collected logs. Default value: cdn_log_access_l1. Valid values:
        /// 
        /// *   **cdn_log_access_l1**: access logs of Dynamic Content Delivery Network (DCDN) points of presence (POPs)
        /// *   **cdn_log_origin**: back-to-origin logs
        /// *   **cdn_log_er**: EdgeRoutine logs
        /// *   By default, this parameter is left empty, and all logs are returned.
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The domain name. You can specify only one domain name in each request. If this parameter is not specified, all domain names are queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The number of the page to return. Valid values: **1** to **100000**. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. The default value is 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

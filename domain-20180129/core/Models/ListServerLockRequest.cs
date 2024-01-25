// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ListServerLockRequest : TeaModel {
        /// <summary>
        /// The start of the time range to query.
        /// </summary>
        [NameInMap("BeginStartDate")]
        [Validation(Required=false)]
        public long? BeginStartDate { get; set; }

        /// <summary>
        /// The domain name for which you want to query the enabled registry lock.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the expiration time.
        /// </summary>
        [NameInMap("EndExpireDate")]
        [Validation(Required=false)]
        public long? EndExpireDate { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// </summary>
        [NameInMap("EndStartDate")]
        [Validation(Required=false)]
        public long? EndStartDate { get; set; }

        /// <summary>
        /// The language of the error message to return if the request fails. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// 
        /// Default value: en.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the product to which the domain name with the registry lock enabled belongs.
        /// </summary>
        [NameInMap("LockProductId")]
        [Validation(Required=false)]
        public string LockProductId { get; set; }

        /// <summary>
        /// The field that you use to sort the query results.
        /// 
        /// Valid values:
        /// 
        /// *   EXPIRE_DATE
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The order of the information based on which you want to sort the domain names, such as the registration date and expiration date. Valid values: ASC and DESC. The value ASC specifies the ascending order. The value DESC specifies the descending order. If this parameter is not configured, the default value DESC is used.
        /// </summary>
        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of the registry lock. Valid values:
        /// 
        /// *   1: The registry lock is not enabled.
        /// *   2: The registry lock is enabled.
        /// *   3: The registry lock is disabled.
        /// </summary>
        [NameInMap("ServerLockStatus")]
        [Validation(Required=false)]
        public int? ServerLockStatus { get; set; }

        /// <summary>
        /// The start of the expiration time.
        /// </summary>
        [NameInMap("StartExpireDate")]
        [Validation(Required=false)]
        public long? StartExpireDate { get; set; }

        /// <summary>
        /// The IP address of the client. For example, you can set the value to **127.0.0.1**.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}

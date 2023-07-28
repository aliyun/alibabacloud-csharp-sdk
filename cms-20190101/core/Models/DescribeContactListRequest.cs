// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListRequest : TeaModel {
        /// <summary>
        /// The status of the TradeManager ID.
        /// 
        /// Valid value: OK. The value OK indicates that the TradeManager ID is valid and can receive alert notifications.
        /// 
        /// >  This parameter can be returned only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("ChanelType")]
        [Validation(Required=false)]
        public string ChanelType { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ChanelValue")]
        [Validation(Required=false)]
        public string ChanelValue { get; set; }

        /// <summary>
        /// The value specified for the alert notification method.
        /// 
        /// >  This parameter is required only if you set the `ChanelType` parameter to `Mail`.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeContactList**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

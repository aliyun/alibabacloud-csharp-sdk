// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListRequest : TeaModel {
        /// <summary>
        /// The alert notification method. Valid values:
        /// 
        /// *   Mail: emails
        /// *   DingWebHook: DingTalk chatbots
        /// </summary>
        [NameInMap("ChanelType")]
        [Validation(Required=false)]
        public string ChanelType { get; set; }

        /// <summary>
        /// The value specified for the alert notification method.
        /// 
        /// >  This parameter is required only if you set the `ChanelType` parameter to `Mail`.
        /// </summary>
        [NameInMap("ChanelValue")]
        [Validation(Required=false)]
        public string ChanelValue { get; set; }

        /// <summary>
        /// The name of the alert contact.
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProjectMetaRequest : TeaModel {
        /// <summary>
        /// The tags. Tags are used to filter services.
        /// 
        /// You can filter services only by the tag whose `name` is `product`. Example: {"name":"product","value":"ECS"}.
        /// 
        /// > We recommend that you do not use the special tags in the CloudMonitor console.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 10000.
        /// 
        /// Default value: 30.
        /// 
        /// > The value of this parameter is not limited. You can view a large number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

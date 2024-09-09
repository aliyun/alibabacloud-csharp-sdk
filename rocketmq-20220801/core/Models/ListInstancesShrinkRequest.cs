// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// The filter condition that is used to query instances. If you do not configure this parameter, all instances are queried.
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Valid values: 1 to 100000000.
        /// 
        /// If you set this parameter to a value smaller than 1, the system uses 1 as the value. If you set this parameter to a value greater than 100000000, the system uses 100000000 as the value.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Value values: 10 to 200.
        /// 
        /// If you set this parameter to a value smaller than 10, the system uses 10 as the value. If you set this parameter to a value greater than 200, the system uses 200 as the value.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The primary edition of the instance.
        /// 
        /// Valid values:
        /// 
        /// *   standard: Standard Edition
        /// *   ultimate: Enterprise Platinum Edition
        /// *   professional: Professional Edition
        /// </summary>
        [NameInMap("seriesCodes")]
        [Validation(Required=false)]
        public string SeriesCodesShrink { get; set; }

        /// <summary>
        /// The tags that are used to filter instances.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}

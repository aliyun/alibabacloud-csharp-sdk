// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListAppGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. Exact match is used.
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the application.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The method based on which applications are sorted. Valid values:
        /// 
        /// *   0: sorts applications in descending order by creation time.
        /// *   1: sorts applications in descending order by modification time.
        /// 
        /// Default value: 0.
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public int? SortBy { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// The type of the application. Valid values:
        /// 
        /// *   standard: a High-performance Search Edition application.
        /// *   enhanced: an Industry Algorithm Edition application.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

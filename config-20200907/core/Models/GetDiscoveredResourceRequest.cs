// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetDiscoveredResourceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the compliance results of the resource. Valid values:
        /// 
        /// *   0 (default): does not query the compliance results of the resource.
        /// *   1: queries the compliance results of the resource.
        /// </summary>
        [NameInMap("ComplianceOption")]
        [Validation(Required=false)]
        public int? ComplianceOption { get; set; }

        /// <summary>
        /// The ID of the region in which the resource resides.
        /// 
        /// For more information about how to query the region ID of a resource, see [ListDiscoveredResources](https://help.aliyun.com/document_detail/411702.html).
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The resource ID.
        /// 
        /// For more information about how to obtain the ID of a resource, see [ListDiscoveredResources](https://help.aliyun.com/document_detail/411702.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// For more information about how to obtain the type of a resource, see [ListDiscoveredResources](https://help.aliyun.com/document_detail/411702.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

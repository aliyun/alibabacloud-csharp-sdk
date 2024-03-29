// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetDiscoveredResourceRequest : TeaModel {
        /// <summary>
        /// The ID of the region in which the resource resides.
        /// 
        /// For more information about how to query the region ID of a resource, see [ListDiscoveredResources](~~411702~~).
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The resource IDs.
        /// 
        /// For more information about how to query the ID of a resource, see [ListDiscoveredResources](~~411702~~).
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// For more information about how to obtain the type of a resource, see [ListDiscoveredResources](~~411702~~).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

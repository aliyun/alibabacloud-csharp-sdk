// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateDiscoveredResourceRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of the account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The ID of the region in which the resource resides.
        /// 
        /// For more information about how to query the ID of a region in which the resource resides, see [ListAggregateDiscoveredResources](~~411691~~).
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the resources in the account group belong.
        /// > You can use either the `ResourceAccountId` or `ResourceOwnerId` parameter. We recommend that you use the ResourceAccountId parameter.
        /// </summary>
        [NameInMap("ResourceAccountId")]
        [Validation(Required=false)]
        public long? ResourceAccountId { get; set; }

        /// <summary>
        /// The resource ID.
        /// 
        /// For more information about how to query the ID of a resource, see [ListAggregateDiscoveredResources](~~411691~~).
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// For more information about how to obtain the type of a resource, see [ListAggregateDiscoveredResources](~~411691~~).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

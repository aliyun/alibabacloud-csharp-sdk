// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The region ID of the tags.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource IDs. You can add tags to up to 50 resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   `ACS::Config::Rule`
        /// *   `ACS::Config::AggregateConfigRule`
        /// *   `ACS::Config::Aggregator`
        /// *   `ACS::Config::CompliancePack`
        /// *   `ACS::Config::AggregateCompliancePack`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag value of the resource.
        /// 
        /// You can specify up to 20 tag values.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the resource.
            /// 
            /// You can add up to 20 tag keys to a resource.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the resource.
            /// 
            /// You can add up to 20 tag values to a resource.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

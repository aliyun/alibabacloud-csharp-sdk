// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("BizExtKey")]
        [Validation(Required=false)]
        public string BizExtKey { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The category of the resource groups. Valid values:
        /// 
        /// *   default: shared resource group
        /// *   single: exclusive resource group
        /// *   Default value: default
        /// </summary>
        [NameInMap("ResourceGroupType")]
        [Validation(Required=false)]
        public int? ResourceGroupType { get; set; }

        /// <summary>
        /// The tag key.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The tag value.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListResourceGroupsRequestTags> Tags { get; set; }
        public class ListResourceGroupsRequestTags : TeaModel {
            /// <summary>
            /// The HTTP status code returned.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        /// <summary>
        /// The category of the resource groups. Valid values:
        /// 
        /// *   default: shared resource group
        /// *   single: exclusive resource group
        /// *   Default value: default
        /// </summary>
        [NameInMap("BizExtKey")]
        [Validation(Required=false)]
        public string BizExtKey { get; set; }

        /// <summary>
        /// The keyword that is used for fuzzy queries by resource group name and identifier.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The type of the resource groups that you want to query. Valid values:
        /// 
        /// *   0: DataWorks
        /// *   1: scheduling
        /// *   2: MaxCompute
        /// *   3: Machine Learning Platform for AI (PAI)
        /// *   4: Data Integration
        /// *   7: exclusive resource group for scheduling (An ID is generated for the purchased resource when you purchase an exclusive resource group for scheduling.)
        /// *   9: DataService Studio
        /// *   Default value: 1
        /// 
        /// If the value indicates a compute engine, the resource groups to query are the ones that were created when you purchased the compute engine.
        /// </summary>
        [NameInMap("ResourceGroupType")]
        [Validation(Required=false)]
        public int? ResourceGroupType { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListResourceGroupsRequestTags> Tags { get; set; }
        public class ListResourceGroupsRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

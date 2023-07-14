// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddPrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// The queried global aggregation instances. The value is a JSON string.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// The name of the aggregation instance.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddPrometheusGlobalViewRequestTag> Tag { get; set; }
        public class AddPrometheusGlobalViewRequestTag : TeaModel {
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

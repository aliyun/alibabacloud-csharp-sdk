// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListOpsItemsShrinkRequest : TeaModel {
        /// <summary>
        /// The filter rules for the component.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListOpsItemsShrinkRequestFilter> Filter { get; set; }
        public class ListOpsItemsShrinkRequestFilter : TeaModel {
            /// <summary>
            /// The parameter name of the filter.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The comparison operator that is used to filter property values.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The parameter values of the filter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 10 to 100. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The information about resource tags.
        /// </summary>
        [NameInMap("ResourceTags")]
        [Validation(Required=false)]
        public string ResourceTagsShrink { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}

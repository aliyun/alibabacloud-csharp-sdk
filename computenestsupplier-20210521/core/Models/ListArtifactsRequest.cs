// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactsRequest : TeaModel {
        /// <summary>
        /// The filter.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListArtifactsRequestFilter> Filter { get; set; }
        public class ListArtifactsRequestFilter : TeaModel {
            /// <summary>
            /// The parameter name of the filter. You can specify one or more filters. Valid values:
            /// 
            /// *   *Name*: The name of the deployment package. Fuzzy match is used.
            /// *   ArtifactId: The ID of the deployment package.
            /// *   ArtifactType: The type of the deployment package.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The parameter values of the filter.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListArtifactsRequestTag> Tag { get; set; }
        public class ListArtifactsRequestTag : TeaModel {
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

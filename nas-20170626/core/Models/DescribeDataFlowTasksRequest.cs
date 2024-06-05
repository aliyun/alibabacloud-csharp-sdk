// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowTasksRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowTasksRequestFilters> Filters { get; set; }
        public class DescribeDataFlowTasksRequestFilters : TeaModel {
            /// <summary>
            /// *
            /// *
            /// *
            /// *
            /// *
            /// *
            /// *
            /// *
            /// *
            /// *
            /// *
            /// *
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// *   ````
            /// *   ````
            /// *
            /// *
            /// *
            /// *
            /// *   ``
            /// *   ``
            /// *   ``
            /// *   ``
            /// *   ``
            /// *   ``
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

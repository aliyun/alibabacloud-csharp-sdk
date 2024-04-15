// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListLayersRequest : TeaModel {
        /// <summary>
        /// The number of layers that are returned
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Specifies whether the layer is official. Valid values: true and false.
        /// </summary>
        [NameInMap("official")]
        [Validation(Required=false)]
        public string Official { get; set; }

        /// <summary>
        /// The name prefix of the layer.
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Specifies whether the layer is public. Valid values: true and false.
        /// </summary>
        [NameInMap("public")]
        [Validation(Required=false)]
        public string Public { get; set; }

    }

}

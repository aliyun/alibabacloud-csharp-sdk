// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCdsFileShareLinksRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The users that create the file sharing links.
        /// </summary>
        [NameInMap("Creators")]
        [Validation(Required=false)]
        public List<string> Creators { get; set; }

        /// <summary>
        /// The maximum number of resources to return. Valid values: 1 to 100. Default value: 100. The number of returned resources must be less than or equal to the specified number.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Specifies the marker after which the returned list begins. If this parameter is not specified, all results are returned. Default value: null.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the file sharing link.
        /// </summary>
        [NameInMap("ShareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The sharing name for fuzzy search.
        /// </summary>
        [NameInMap("ShareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// The file sharing status. Valid values: ● disabled: canceled ● enabled: valid
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainResourceRequest : TeaModel {
        /// <summary>
        /// The domain name of the website that you want to query.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// An array that consists of the IDs of instances to query.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The match mode. Valid values:
        /// 
        /// *   **fuzzy**: fuzzy match. This is the default value.
        /// *   **exact**: exact match.
        /// </summary>
        [NameInMap("QueryDomainPattern")]
        [Validation(Required=false)]
        public string QueryDomainPattern { get; set; }

    }

}

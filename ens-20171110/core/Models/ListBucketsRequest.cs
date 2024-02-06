// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListBucketsRequest : TeaModel {
        /// <summary>
        /// The number of the page. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The maximum number of returned buckets. If this parameter is not specified, the default value is 10. The value cannot be greater than 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// Specifies the prefix that returned bucket names must contain. If this parameter is not specified, prefix information will not be used as a filter.
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}

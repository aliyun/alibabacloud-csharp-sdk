// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListVendorsResponseBody : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<ListVendorsResponseBodyVendors> Vendors { get; set; }
        public class ListVendorsResponseBodyVendors : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

            [NameInMap("VendorType")]
            [Validation(Required=false)]
            public string VendorType { get; set; }

        }

    }

}

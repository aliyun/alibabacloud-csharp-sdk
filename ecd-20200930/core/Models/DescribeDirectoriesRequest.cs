// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDirectoriesRequest : TeaModel {
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public List<string> DirectoryId { get; set; }

        [NameInMap("DirectoryStatus")]
        [Validation(Required=false)]
        public string DirectoryStatus { get; set; }

        [NameInMap("DirectoryType")]
        [Validation(Required=false)]
        public string DirectoryType { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

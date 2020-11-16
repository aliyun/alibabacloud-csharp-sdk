// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeDirectoriesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=true)]
        public string ClientId { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public List<string> DirectoryId { get; set; }

    }

}

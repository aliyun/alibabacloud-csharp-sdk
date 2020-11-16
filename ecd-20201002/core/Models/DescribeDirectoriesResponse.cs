// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeDirectoriesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Directories")]
        [Validation(Required=true)]
        public List<DescribeDirectoriesResponseDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseDirectories : TeaModel {
            [NameInMap("DirectoryId")]
            [Validation(Required=true)]
            public string DirectoryId { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=true)]
            public string DirectoryType { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeDirectoriesResponseBody : TeaModel {
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<DescribeDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseBodyDirectories : TeaModel {
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            [NameInMap("SsoServiceUrl")]
            [Validation(Required=false)]
            public string SsoServiceUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

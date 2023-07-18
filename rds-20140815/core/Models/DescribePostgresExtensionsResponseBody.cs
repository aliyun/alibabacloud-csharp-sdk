// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePostgresExtensionsResponseBody : TeaModel {
        [NameInMap("InstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribePostgresExtensionsResponseBodyInstalledExtensions> InstalledExtensions { get; set; }
        public class DescribePostgresExtensionsResponseBodyInstalledExtensions : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

        }

        [NameInMap("Overview")]
        [Validation(Required=false)]
        public Dictionary<string, object> Overview { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UninstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribePostgresExtensionsResponseBodyUninstalledExtensions> UninstalledExtensions { get; set; }
        public class DescribePostgresExtensionsResponseBodyUninstalledExtensions : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

        }

    }

}

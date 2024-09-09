// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePostgresExtensionsResponseBody : TeaModel {
        /// <summary>
        /// The list of extensions that are installed on the specified database.
        /// </summary>
        [NameInMap("InstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribePostgresExtensionsResponseBodyInstalledExtensions> InstalledExtensions { get; set; }
        public class DescribePostgresExtensionsResponseBodyInstalledExtensions : TeaModel {
            /// <summary>
            /// The category of the extension.
            /// 
            /// *   **external_access**
            /// *   **index_support**
            /// *   **information_stat**
            /// *   **geography_space**
            /// *   **vector_engine**
            /// *   **timing_engine**
            /// *   **data_type**
            /// *   **encrypt_secure**
            /// *   **text_process**
            /// *   **operation_maintenance**
            /// *   **self_develop**
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The purpose of the extension.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The default version of the extension.
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// The current version of the extension.
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// The name of the extension.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The user of the extension.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The priority of the extension.
            /// 
            /// *   **0**: The extension is displayed by default.
            /// *   **1**: The extension is preferentially displayed.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The extensions on which the current extension depends when it is installed.
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// Alibaba Cloud account ID.
            /// 
            /// > Only exclusive plug-ins (plug-ins written by users) will return this parameter. Each Alibaba Cloud account only displays its own exclusive plug-ins.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// The overview of the extension.
        /// </summary>
        [NameInMap("Overview")]
        [Validation(Required=false)]
        public Dictionary<string, object> Overview { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of extensions that are not installed on the specified database.
        /// </summary>
        [NameInMap("UninstalledExtensions")]
        [Validation(Required=false)]
        public List<DescribePostgresExtensionsResponseBodyUninstalledExtensions> UninstalledExtensions { get; set; }
        public class DescribePostgresExtensionsResponseBodyUninstalledExtensions : TeaModel {
            /// <summary>
            /// The category of the extension.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The purpose of the extension.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The default version of the extension.
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// The current version of the extension.
            /// </summary>
            [NameInMap("InstalledVersion")]
            [Validation(Required=false)]
            public string InstalledVersion { get; set; }

            /// <summary>
            /// The name of the extension.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The user of the extension.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The priority of the extension.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// The extensions on which the current extension depends when it is installed.
            /// </summary>
            [NameInMap("Requires")]
            [Validation(Required=false)]
            public string Requires { get; set; }

            /// <summary>
            /// Alibaba Cloud account ID.
            /// 
            /// > Only exclusive plug-ins (plug-ins written by users) will return this parameter. Each Alibaba Cloud account only displays its own exclusive plug-ins.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}

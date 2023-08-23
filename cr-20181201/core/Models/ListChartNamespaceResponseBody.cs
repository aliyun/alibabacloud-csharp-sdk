// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChartNamespaceResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The namespaces.
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<ListChartNamespaceResponseBodyNamespaces> Namespaces { get; set; }
        public class ListChartNamespaceResponseBodyNamespaces : TeaModel {
            /// <summary>
            /// Indicates whether a repository was automatically created when a chart is pushed to the namespace.
            /// </summary>
            [NameInMap("AutoCreateRepo")]
            [Validation(Required=false)]
            public bool? AutoCreateRepo { get; set; }

            /// <summary>
            /// The default repository type. Valid values:
            /// 
            /// *   `PUBLIC`: a public repository
            /// *   `PRIVATE`: a private repository
            /// </summary>
            [NameInMap("DefaultRepoType")]
            [Validation(Required=false)]
            public string DefaultRepoType { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// The status of the namespace. Valid values:
            /// 
            /// *   `NORMAL`: The namespace is normal.
            /// *   `DELETING`: The namespace is being deleted.
            /// </summary>
            [NameInMap("NamespaceStatus")]
            [Validation(Required=false)]
            public string NamespaceStatus { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

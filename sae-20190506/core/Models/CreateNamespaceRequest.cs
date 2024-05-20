// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateNamespaceRequest : TeaModel {
        [NameInMap("EnableMicroRegistration")]
        [Validation(Required=false)]
        public bool? EnableMicroRegistration { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("NamespaceDescription")]
        [Validation(Required=false)]
        public string NamespaceDescription { get; set; }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// cn-beijing:test
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}

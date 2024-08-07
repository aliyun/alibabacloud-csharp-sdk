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
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// The message returned for the operation.
        /// </summary>
        [NameInMap("NamespaceDescription")]
        [Validation(Required=false)]
        public string NamespaceDescription { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}

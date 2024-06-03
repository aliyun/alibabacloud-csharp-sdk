// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserIdRequest : TeaModel {
        /// <summary>
        /// The ID of the resource directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The identifier information about the user that is synchronized from an external identity provider (IdP).
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public GetUserIdRequestExternalId ExternalId { get; set; }
        public class GetUserIdRequestExternalId : TeaModel {
            /// <summary>
            /// The identifier of the user that is synchronized from an external IdP.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The method for external identity synchronization. Only System for Cross-domain Identity Management (SCIM) synchronization is supported.
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

        }

    }

}

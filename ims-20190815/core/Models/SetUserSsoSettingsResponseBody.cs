// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetUserSsoSettingsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of user-based SSO.
        /// </summary>
        [NameInMap("UserSsoSettings")]
        [Validation(Required=false)]
        public SetUserSsoSettingsResponseBodyUserSsoSettings UserSsoSettings { get; set; }
        public class SetUserSsoSettingsResponseBodyUserSsoSettings : TeaModel {
            /// <summary>
            /// The auxiliary domain name.
            /// </summary>
            [NameInMap("AuxiliaryDomain")]
            [Validation(Required=false)]
            public string AuxiliaryDomain { get; set; }

            /// <summary>
            /// The metadata file, which is Base64-encoded.
            /// </summary>
            [NameInMap("MetadataDocument")]
            [Validation(Required=false)]
            public string MetadataDocument { get; set; }

            /// <summary>
            /// Indicates whether user-based SSO is enabled.
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

        }

    }

}

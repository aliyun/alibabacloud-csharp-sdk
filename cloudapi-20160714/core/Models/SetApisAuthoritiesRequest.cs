// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetApisAuthoritiesRequest : TeaModel {
        /// <summary>
        /// Queries weather based on the region name
        /// </summary>
        [NameInMap("ApiIds")]
        [Validation(Required=false)]
        public string ApiIds { get; set; }

        /// <summary>
        /// The API ID for the specified operation. Separate multiple API IDs with commas (,). A maximum of 100 API IDs can be entered.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// *   This operation is intended for API providers and callers.
        /// *   API providers can authorize any apps to call their APIs.
        /// *   API callers can authorize their own apps to call the APIs that they have purchased.
        /// </summary>
        [NameInMap("AuthValidTime")]
        [Validation(Required=false)]
        public string AuthValidTime { get; set; }

        /// <summary>
        /// The time (UTC) when the authorization expires. If this parameter is empty, the authorization does not expire.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the runtime environment. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **TEST**
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The description of the authorization.
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}

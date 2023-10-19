// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveSignatureApisRequest : TeaModel {
        /// <summary>
        /// The IDs of the APIs from which you want to unbind the signature key.
        /// 
        /// *   If this parameter is not specified, the signature key is unbound from all the APIs in the specified environment of the API group.
        /// *   The IDs of the APIs that you want to manage. Separate multiple API IDs with commas (,). A maximum of 100 API IDs can be entered.
        /// </summary>
        [NameInMap("ApiIds")]
        [Validation(Required=false)]
        public string ApiIds { get; set; }

        /// <summary>
        /// The ID of the API group to which the API that you want to manage belongs.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the signature key.
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// The name of the runtime environment. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **TEST**
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}

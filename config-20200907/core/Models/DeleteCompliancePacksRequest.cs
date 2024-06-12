// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteCompliancePacksRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The `token` can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the compliance package. Separate multiple compliance package IDs with commas (,).
        /// 
        /// For more information about how to obtain the ID of a compliance package, see [ListCompliancePacks](https://help.aliyun.com/document_detail/263332.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompliancePackIds")]
        [Validation(Required=false)]
        public string CompliancePackIds { get; set; }

        /// <summary>
        /// Specifies whether to delete the rules in the compliance package. Valid values:
        /// 
        /// *   true: The rules are deleted.
        /// *   false (default): The rules are not deleted.
        /// </summary>
        [NameInMap("DeleteRule")]
        [Validation(Required=false)]
        public bool? DeleteRule { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyIpControlRequest : TeaModel {
        /// <summary>
        /// *   This operation is intended for API providers.
        /// *   This operation allows you to modify only the name and description of an ACL. You cannot modify the type of the ACL.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The description. The description can be up to 200 characters in length.
        /// </summary>
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("IpControlName")]
        [Validation(Required=false)]
        public string IpControlName { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

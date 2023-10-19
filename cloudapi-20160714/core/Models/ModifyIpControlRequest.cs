// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyIpControlRequest : TeaModel {
        /// <summary>
        /// The description. The description can be up to 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the ACL. The ID is unique.
        /// </summary>
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        /// <summary>
        /// The name of the ACL. The name must be 4 to 50 characters in length, and can contain letters, digits, and underscores (\_). The name cannot start with an underscore (\_).
        /// </summary>
        [NameInMap("IpControlName")]
        [Validation(Required=false)]
        public string IpControlName { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

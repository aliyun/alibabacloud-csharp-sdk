// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class AuthorizeApplicationToGroupsRequest : TeaModel {
        /// <summary>
        /// The application ID.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The group IDs. You can specify up to 100 group IDs at a time.
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

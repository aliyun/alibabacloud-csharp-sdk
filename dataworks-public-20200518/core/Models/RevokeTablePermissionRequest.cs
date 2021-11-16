// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RevokeTablePermissionRequest : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        [NameInMap("RevokeUserId")]
        [Validation(Required=false)]
        public string RevokeUserId { get; set; }

        [NameInMap("RevokeUserName")]
        [Validation(Required=false)]
        public string RevokeUserName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}

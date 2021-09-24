// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RevokeTablePermissionRequest : TeaModel {
        [NameInMap("WorkspaceId")]
        [Validation(Required=true)]
        public long? WorkspaceId { get; set; }

        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=true)]
        public string MaxComputeProjectName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=true)]
        public string TableName { get; set; }

        [NameInMap("Actions")]
        [Validation(Required=true)]
        public string Actions { get; set; }

        [NameInMap("RevokeUserName")]
        [Validation(Required=false)]
        public string RevokeUserName { get; set; }

        [NameInMap("RevokeUserId")]
        [Validation(Required=false)]
        public string RevokeUserId { get; set; }

    }

}

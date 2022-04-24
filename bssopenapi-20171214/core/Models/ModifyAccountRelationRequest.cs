// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ModifyAccountRelationRequest : TeaModel {
        [NameInMap("ChildNick")]
        [Validation(Required=false)]
        public string ChildNick { get; set; }

        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public long? ParentUserId { get; set; }

        [NameInMap("PermissionCodes")]
        [Validation(Required=false)]
        public List<string> PermissionCodes { get; set; }

        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        [NameInMap("RelationOperation")]
        [Validation(Required=false)]
        public string RelationOperation { get; set; }

        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleCodes")]
        [Validation(Required=false)]
        public List<string> RoleCodes { get; set; }

    }

}

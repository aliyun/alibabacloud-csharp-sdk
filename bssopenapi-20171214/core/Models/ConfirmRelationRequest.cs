// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ConfirmRelationRequest : TeaModel {
        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        [NameInMap("ConfirmCode")]
        [Validation(Required=false)]
        public string ConfirmCode { get; set; }

        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public long? ParentUserId { get; set; }

        [NameInMap("PermissionCodes")]
        [Validation(Required=false)]
        public List<string> PermissionCodes { get; set; }

        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

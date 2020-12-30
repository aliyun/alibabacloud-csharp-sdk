// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RevokeUserPermissionRequest : TeaModel {
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("DsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("PermTypes")]
        [Validation(Required=false)]
        public string PermTypes { get; set; }

        [NameInMap("UserAccessId")]
        [Validation(Required=false)]
        public string UserAccessId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseRoleUpdateBizRoleRequest : TeaModel {
        [NameInMap("BizPermissionCodeListJson")]
        [Validation(Required=false)]
        public string BizPermissionCodeListJson { get; set; }

        [NameInMap("BizRoleCode")]
        [Validation(Required=false)]
        public string BizRoleCode { get; set; }

        [NameInMap("BizRoleDesc")]
        [Validation(Required=false)]
        public string BizRoleDesc { get; set; }

        [NameInMap("BizRoleName")]
        [Validation(Required=false)]
        public string BizRoleName { get; set; }

        [NameInMap("EncryptTicket")]
        [Validation(Required=false)]
        public string EncryptTicket { get; set; }

        [NameInMap("OrientedEcId")]
        [Validation(Required=false)]
        public string OrientedEcId { get; set; }

        [NameInMap("OrientedLeId")]
        [Validation(Required=false)]
        public string OrientedLeId { get; set; }

        [NameInMap("OrientedNbId")]
        [Validation(Required=false)]
        public string OrientedNbId { get; set; }

    }

}

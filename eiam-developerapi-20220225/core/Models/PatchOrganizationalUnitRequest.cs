// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class PatchOrganizationalUnitRequest : TeaModel {
        /// <summary>
        /// 机构描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [NameInMap("organizationalUnitName")]
        [Validation(Required=false)]
        public string OrganizationalUnitName { get; set; }

    }

}

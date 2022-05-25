// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateOrganizationalUnitRequest : TeaModel {
        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 机构外部ID
        /// </summary>
        [NameInMap("organizationalUnitExternalId")]
        [Validation(Required=false)]
        public string OrganizationalUnitExternalId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [NameInMap("organizationalUnitName")]
        [Validation(Required=false)]
        public string OrganizationalUnitName { get; set; }

        /// <summary>
        /// 父机构ID
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

    }

}

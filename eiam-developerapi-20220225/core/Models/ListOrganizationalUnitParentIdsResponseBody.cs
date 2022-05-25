// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListOrganizationalUnitParentIdsResponseBody : TeaModel {
        /// <summary>
        /// 父机构ID列表，顺序层级从上到下
        /// </summary>
        [NameInMap("parentIds")]
        [Validation(Required=false)]
        public List<string> ParentIds { get; set; }

    }

}

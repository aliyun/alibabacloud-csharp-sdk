// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListOrganizationalUnitParentIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the parent organizational units. The IDs of the organizational unit are ordered based on their levels from high to low. Only the IDs of the organizational units within the authorization scope are displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ou_xxx001]</para>
        /// </summary>
        [NameInMap("parentIds")]
        [Validation(Required=false)]
        public List<string> ParentIds { get; set; }

    }

}

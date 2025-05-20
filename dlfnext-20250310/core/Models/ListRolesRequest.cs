// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListRolesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>role_name</para>
        /// </summary>
        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}

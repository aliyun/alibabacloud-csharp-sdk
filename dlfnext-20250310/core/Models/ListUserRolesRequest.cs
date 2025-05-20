// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListUserRolesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("pageToken")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:user/user_name</para>
        /// </summary>
        [NameInMap("userPrincipal")]
        [Validation(Required=false)]
        public string UserPrincipal { get; set; }

    }

}

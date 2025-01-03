// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>vxc2341gfssad12</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66c0c9fffeb86b450c199fcd</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>keyset</para>
        /// </summary>
        [NameInMap("pagination")]
        [Validation(Required=false)]
        public string Pagination { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("perPage")]
        [Validation(Required=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}

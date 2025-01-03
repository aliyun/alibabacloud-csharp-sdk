// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListChangeRequestsShrinkRequest : TeaModel {
        [NameInMap("appNameList")]
        [Validation(Required=false)]
        public string AppNameListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>change1</para>
        /// </summary>
        [NameInMap("displayNameKeyword")]
        [Validation(Required=false)]
        public string DisplayNameKeyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4dc150725770510122396e2476</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66c0c9fffeb86b450c199fcd</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("ownerIdList")]
        [Validation(Required=false)]
        public string OwnerIdListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

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
        /// <para>desc</para>
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("stateList")]
        [Validation(Required=false)]
        public string StateListShrink { get; set; }

    }

}

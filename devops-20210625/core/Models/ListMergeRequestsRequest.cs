// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("authorIds")]
        [Validation(Required=false)]
        public string AuthorIds { get; set; }

        [NameInMap("createdAfter")]
        [Validation(Required=false)]
        public string CreatedAfter { get; set; }

        [NameInMap("createdBefore")]
        [Validation(Required=false)]
        public string CreatedBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>new</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>889910, 889911</para>
        /// </summary>
        [NameInMap("groupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        [NameInMap("labelIds")]
        [Validation(Required=false)]
        public string LabelIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>updated_at</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60de7a6852743a5162b5f957</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2308912, 2308913</para>
        /// </summary>
        [NameInMap("projectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("reviewerIds")]
        [Validation(Required=false)]
        public string ReviewerIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-search</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>opened</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}

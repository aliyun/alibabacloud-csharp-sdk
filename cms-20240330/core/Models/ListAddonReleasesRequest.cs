// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonReleasesRequest : TeaModel {
        /// <summary>
        /// <para>The add-on name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-gpu</para>
        /// </summary>
        [NameInMap("addonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The next token for pagination.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The parent add-on release ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("parentAddonReleaseId")]
        [Validation(Required=false)]
        public string ParentAddonReleaseId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentExplorer20260317.Models
{
    public class SearchSkillsRequest : TeaModel {
        /// <summary>
        /// <para>The skill category code. Separate multiple codes with commas. For a second-level category, use the format: first-level category.second-level category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute.serverless,network</para>
        /// </summary>
        [NameInMap("categoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Set this to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAZjtYxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("searchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The number of entries to skip for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class WebSearchRequest : TeaModel {
        /// <summary>
        /// <para>The agent name.</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Default value: 10. Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The search query statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Spring Boot</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("UrlScopeDomains")]
        [Validation(Required=false)]
        public string UrlScopeDomains { get; set; }

        /// <summary>
        /// <para>The URL scope mode.</para>
        /// </summary>
        [NameInMap("UrlScopeMode")]
        [Validation(Required=false)]
        public string UrlScopeMode { get; set; }

    }

}

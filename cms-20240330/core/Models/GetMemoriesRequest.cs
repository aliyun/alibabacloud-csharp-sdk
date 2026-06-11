// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetMemoriesRequest : TeaModel {
        /// <summary>
        /// <para>The application\&quot;s agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952730652285943809</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The Application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150130323</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;<b>strategy_type</b>&quot;:&quot;Fact&quot;}</para>
        /// </summary>
        [NameInMap("filters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filters { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The Run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jr-80ded1d6953c64ea</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user_001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

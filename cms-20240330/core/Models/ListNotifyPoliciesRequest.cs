// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListNotifyPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The policy name used for fuzzy filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-alert</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first page. For subsequent pages, set this parameter to the nextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJjdXJzb3IiOjEwfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values: createTime, updateTime, and name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>createTime</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort results in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: descending order.</description></item>
        /// <item><description>false: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("orderDesc")]
        [Validation(Required=false)]
        public string OrderDesc { get; set; }

        /// <summary>
        /// <para>The workspace ID. This parameter is used to isolate notify policy resources across different business spaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-xxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

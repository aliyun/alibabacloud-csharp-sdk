// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListNotifyPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to return for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The fuzzy filter for the policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-alert</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave empty for the first page. For subsequent pages, pass the nextToken returned from the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJjdXJzb3IiOjEwfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The field to sort by. Valid values include createTime, updateTime, and name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>createTime</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort in descending order. Set to true for descending order, or false for ascending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("orderDesc")]
        [Validation(Required=false)]
        public string OrderDesc { get; set; }

        /// <summary>
        /// <para>The workspace ID, used to isolate notification policy resources for different business workspaces.</para>
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

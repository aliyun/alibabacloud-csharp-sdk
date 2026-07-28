// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListRegistryNamespacesRequest : TeaModel {
        /// <summary>
        /// <para>The search keyword. Fuzzy search by workspace name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: 100.
        /// Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hg7nXVngyM6tQtvCagmtY=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The workspace type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>system: public workspace</para>
        /// </description></item>
        /// <item><description><para>self: custom workspace</para>
        /// </description></item>
        /// <item><description><para>shared: shared workspace</para>
        /// </description></item>
        /// <item><description><para>community: community workspace</para>
        /// </description></item>
        /// </list>
        /// <para>By default, all workspaces are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>self</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

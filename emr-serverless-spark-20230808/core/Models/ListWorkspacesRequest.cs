// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListWorkspacesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to return in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the workspace. Fuzzy search by workspace name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_workspace</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The token that indicates the position from which to start reading.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2thxggoqhmhq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The state of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Starting: The workspace is starting.</description></item>
        /// <item><description>Running: The workspace is running.</description></item>
        /// <item><description>Stopping: The workspace is stopping.</description></item>
        /// <item><description>Stopped: The workspace is stopped.</description></item>
        /// <item><description>Error: The workspace failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The list of tags used to filter workspaces.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<ListWorkspacesRequestTag> Tag { get; set; }
        public class ListWorkspacesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-finance.edas.config.server</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iPhone remaining disk space percentage</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

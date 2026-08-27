// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class ListWorkersRequest : TeaModel {
        /// <summary>
        /// <para>The Agent runtime type filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwenpaw</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The credential name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred-demo</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        /// <summary>
        /// <para>The team group filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public ListWorkersRequestGroup Group { get; set; }
        public class ListWorkersRequestGroup : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst-demo</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The MCP server name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp-demo</para>
        /// </summary>
        [NameInMap("Mcp")]
        [Validation(Required=false)]
        public string Mcp { get; set; }

        /// <summary>
        /// <para>The model name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model provider filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dashscope</para>
        /// </summary>
        [NameInMap("ModelProvider")]
        [Validation(Required=false)]
        public string ModelProvider { get; set; }

        /// <summary>
        /// <para>The fuzzy match filter for the Worker name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker</para>
        /// </summary>
        [NameInMap("NameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The pagination token used to query the next page of data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The template filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public ListWorkersRequestTemplate Template { get; set; }
        public class ListWorkersRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标签</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The Worker version number filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListExplorerRegistryModuleVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Explorer community module versions.</para>
        /// </summary>
        [NameInMap("explorerRegistryModuleVersions")]
        [Validation(Required=false)]
        public List<ListExplorerRegistryModuleVersionsResponseBodyExplorerRegistryModuleVersions> ExplorerRegistryModuleVersions { get; set; }
        public class ListExplorerRegistryModuleVersionsResponseBodyExplorerRegistryModuleVersions : TeaModel {
            /// <summary>
            /// <para>The module details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("moduleDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> ModuleDetail { get; set; }

            /// <summary>
            /// <para>The module file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("moduleFile")]
            [Validation(Required=false)]
            public Dictionary<string, object> ModuleFile { get; set; }

            /// <summary>
            /// <para>The module name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-slb-ecs-polardb</para>
            /// </summary>
            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespace-test</para>
            /// </summary>
            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <para>The resource properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_namespace/RegistryModule-test4</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 0 to 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page of results.</para>
        /// <para>If the total number of entries exceeds the maxResults limit, the data is truncated. You can use nextToken to query the next page of data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oIM6ssGyh00noi5zoDR1hJ4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2D40488-3F74-568B-87EC-1C04D098DF8B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

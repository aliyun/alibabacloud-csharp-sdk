// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListExplorerRegistryModuleVersionsResponseBody : TeaModel {
        [NameInMap("explorerRegistryModuleVersions")]
        [Validation(Required=false)]
        public List<ListExplorerRegistryModuleVersionsResponseBodyExplorerRegistryModuleVersions> ExplorerRegistryModuleVersions { get; set; }
        public class ListExplorerRegistryModuleVersionsResponseBodyExplorerRegistryModuleVersions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("moduleDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> ModuleDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("moduleFile")]
            [Validation(Required=false)]
            public Dictionary<string, object> ModuleFile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eip-slb-ecs-polardb</para>
            /// </summary>
            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>namespace-test</para>
            /// </summary>
            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_namespace/RegistryModule-test4</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.5.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oIM6ssGyh00noi5zoDR1hJ4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F2D40488-3F74-568B-87EC-1C04D098DF8B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

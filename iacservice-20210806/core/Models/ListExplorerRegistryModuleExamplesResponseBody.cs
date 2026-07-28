// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListExplorerRegistryModuleExamplesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Explorer community module examples.</para>
        /// </summary>
        [NameInMap("explorerRegistryModuleExamples")]
        [Validation(Required=false)]
        public List<ListExplorerRegistryModuleExamplesResponseBodyExplorerRegistryModuleExamples> ExplorerRegistryModuleExamples { get; set; }
        public class ListExplorerRegistryModuleExamplesResponseBodyExplorerRegistryModuleExamples : TeaModel {
            /// <summary>
            /// <para>The example name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201-use-case-create-actiontrail-trail</para>
            /// </summary>
            [NameInMap("exampleName")]
            [Validation(Required=false)]
            public string ExampleName { get; set; }

            /// <summary>
            /// <para>The example path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("examplePath")]
            [Validation(Required=false)]
            public string ExamplePath { get; set; }

            /// <summary>
            /// <para>The example schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("exampleSchema")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExampleSchema { get; set; }

            /// <summary>
            /// <para>The module name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iactestname1</para>
            /// </summary>
            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The module version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.11.0</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba</para>
            /// </summary>
            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>VSjwD+sJ8OZJ8fNjV89AZs7o2AdSD25ZQLeWZ8REjXA=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA8F6459-EED6-556B-8130-D150A3866E56</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

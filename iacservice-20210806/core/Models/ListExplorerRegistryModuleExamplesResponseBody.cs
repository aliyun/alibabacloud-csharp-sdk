// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListExplorerRegistryModuleExamplesResponseBody : TeaModel {
        [NameInMap("explorerRegistryModuleExamples")]
        [Validation(Required=false)]
        public List<ListExplorerRegistryModuleExamplesResponseBodyExplorerRegistryModuleExamples> ExplorerRegistryModuleExamples { get; set; }
        public class ListExplorerRegistryModuleExamplesResponseBodyExplorerRegistryModuleExamples : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>201-use-case-create-actiontrail-trail</para>
            /// </summary>
            [NameInMap("exampleName")]
            [Validation(Required=false)]
            public string ExampleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("examplePath")]
            [Validation(Required=false)]
            public string ExamplePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("exampleSchema")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExampleSchema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iactestname1</para>
            /// </summary>
            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.11.0</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba</para>
            /// </summary>
            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>VSjwD+sJ8OZJ8fNjV89AZs7o2AdSD25ZQLeWZ8REjXA=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BA8F6459-EED6-556B-8130-D150A3866E56</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListExplorerRegistryModuleExamplesRequest : TeaModel {
        /// <summary>
        /// <para>The example name of the module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>complete</para>
        /// </summary>
        [NameInMap("exampleName")]
        [Validation(Required=false)]
        public string ExampleName { get; set; }

        /// <summary>
        /// <para>The search keyword. Supports fuzzy match based on the module name or module example name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

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
        /// <para>The name of the module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("moduleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// <para>The version of the module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.11.0</para>
        /// </summary>
        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the module belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("namespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page of results.</para>
        /// <para>If the total number of entries exceeds the maxResults limit, the data is truncated. You can use nextToken to query the next page of data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IbuvZbAXFOiB4nKg8iOH447bhHWDavGTOMijI2Jep7c=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

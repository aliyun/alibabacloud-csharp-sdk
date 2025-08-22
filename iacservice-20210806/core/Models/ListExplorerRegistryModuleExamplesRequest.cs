// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListExplorerRegistryModuleExamplesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>complete</para>
        /// </summary>
        [NameInMap("exampleName")]
        [Validation(Required=false)]
        public string ExampleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sls</para>
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
        /// <para>IbuvZbAXFOiB4nKg8iOH447bhHWDavGTOMijI2Jep7c=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

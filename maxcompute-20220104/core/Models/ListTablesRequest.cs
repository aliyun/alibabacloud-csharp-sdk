// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// Specifies the marker after which the returned list begins.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public int? MaxItem { get; set; }

        /// <summary>
        /// The names of the returned resources. The names must start with the value specified by the prefix parameter. If the prefix parameter is set to a, the names of the returned resources must start with a.
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("schemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The type of the table.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

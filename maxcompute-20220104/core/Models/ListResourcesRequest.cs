// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListResourcesRequest : TeaModel {
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
        /// The name of the resource.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("schemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

    }

}

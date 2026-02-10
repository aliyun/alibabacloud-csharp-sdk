// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingSubNodesCountRequest : TeaModel {
        /// <summary>
        /// <para>The key-value pairs that consist of node IDs and node types. A key-value pair is an array.</para>
        /// </summary>
        [NameInMap("VertexIdAndTypeList")]
        [Validation(Required=false)]
        public List<List<string>> VertexIdAndTypeList { get; set; }

    }

}

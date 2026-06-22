// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentTracingSubNodesCountRequest : TeaModel {
        /// <summary>
        /// <para>List of key-value pairs composed of node IDs and types, where key-value pairs exist in the form of arrays</para>
        /// </summary>
        [NameInMap("VertexIdAndTypeList")]
        [Validation(Required=false)]
        public List<List<string>> VertexIdAndTypeList { get; set; }

    }

}

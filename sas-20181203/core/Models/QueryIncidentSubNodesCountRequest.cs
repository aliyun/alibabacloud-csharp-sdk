// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentSubNodesCountRequest : TeaModel {
        /// <summary>
        /// <para>The request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;body&quot;: {&quot;VertexIdAndTypeList&quot;: [[&quot;b17f3a9a1a6abd6a6786208492e71912&quot;, &quot;process&quot;], [&quot;58fa3749cd7ce20f7e75424070012ed9&quot;, &quot;file&quot;]]}}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServiceNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of the queried namespaces.</para>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

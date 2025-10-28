// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sNamespacesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster in Enterprise Distributed Application Service (EDAS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b2b4ab4-efbc-4a81-9c45-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}

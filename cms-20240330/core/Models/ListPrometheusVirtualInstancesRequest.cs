// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPrometheusVirtualInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Optional cloud product</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-csi-fuse</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}

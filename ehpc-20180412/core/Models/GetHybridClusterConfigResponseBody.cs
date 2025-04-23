// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetHybridClusterConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations returned.</para>
        /// <list type="bullet">
        /// <item><description>If the parameter Node is null, you can obtain the configurations of the hybrid cloud cluster.</description></item>
        /// <item><description>If the parameter Node is a specified on-premises compute node, you can obtain the configurations of the on-premises compute node.</description></item>
        /// </list>
        /// <para>This parameter is returned in the ini format. You can use this parameter to configure on-premises cluster nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClNjaGcyI6W119Cg****</para>
        /// </summary>
        [NameInMap("ClusterConfig")]
        [Validation(Required=false)]
        public string ClusterConfig { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetIntegrationVersionForCSRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c502646fd0d1249baaf792b3a1b589e1b</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs.ack.cluster</para>
        /// </summary>
        [NameInMap("clusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

    }

}

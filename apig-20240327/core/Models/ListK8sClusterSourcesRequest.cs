// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListK8sClusterSourcesRequest : TeaModel {
        /// <summary>
        /// <para>The VPC ID used to query clusters within the specified VPC. If this parameter is not specified, the VPC of the gateway is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

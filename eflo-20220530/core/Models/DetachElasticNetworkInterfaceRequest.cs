// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class DetachElasticNetworkInterfaceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ENI.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>leni-1234****</para>
        /// </summary>
        [NameInMap("ElasticNetworkInterfaceId")]
        [Validation(Required=false)]
        public string ElasticNetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zxu2zp3****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The region ID of the disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

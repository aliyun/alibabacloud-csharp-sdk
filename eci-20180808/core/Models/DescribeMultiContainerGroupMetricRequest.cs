// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeMultiContainerGroupMetricRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. The value is a JSON array. You can specify up to 20 instance IDs at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;eci-2zegym1qhbmdfr1s****&quot;,&quot;eci-2ze39w5svzj5ic34****&quot;]</para>
        /// </summary>
        [NameInMap("ContainerGroupIds")]
        [Validation(Required=false)]
        public string ContainerGroupIds { get; set; }

        /// <summary>
        /// <para>The type of the monitoring data. Set the value to summary. This value indicates that records are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>summary</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the elastic container instances belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzw2jz2z****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

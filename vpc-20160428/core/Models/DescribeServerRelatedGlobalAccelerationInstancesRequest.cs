// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeServerRelatedGlobalAccelerationInstancesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region where the Alibaba Cloud Global Accelerator (GA) instance resides. </para>
        /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the backend service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-12s3sdf****</para>
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// <para>The type of the backend service instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>EcsInstance</b> (default): ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>SlbInstance</b>: load balancing instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EcsInstance</para>
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

    }

}

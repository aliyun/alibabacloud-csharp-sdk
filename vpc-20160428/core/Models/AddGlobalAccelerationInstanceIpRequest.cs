// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AddGlobalAccelerationInstanceIpRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the shared-bandwidth GA instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-Ldefrgbttnyyf****</para>
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        /// <summary>
        /// <para>The EIP ID. You can call the <a href="https://help.aliyun.com/document_detail/36018.html">DescribeEipAddresses</a> operation to query EIP IDs.</para>
        /// <remarks>
        /// <para> Make sure that the billing method of the EIP is pay-as-you-go, and the EIP and the shared-bandwidth GA instance belong to the same region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-rw434rwfdeaf****</para>
        /// </summary>
        [NameInMap("IpInstanceId")]
        [Validation(Required=false)]
        public string IpInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region of the shared-bandwidth GA instance.</para>
        /// <para>You can call the <b>DescribeRegions</b> operation to query the most recent region list.</para>
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

    }

}

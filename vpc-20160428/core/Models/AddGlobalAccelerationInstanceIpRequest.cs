// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AddGlobalAccelerationInstanceIpRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Internet Shared Bandwidth instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-Ldefrgbttnyyf****</para>
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the EIP instance. You can call <a href="https://help.aliyun.com/document_detail/36018.html">DescribeEipAddresses</a> to query the EIP instance ID. </para>
        /// <remarks>
        /// <para>Make sure that the billing method of the EIP is pay-as-you-go and the EIP resides in the same region as the Internet Shared Bandwidth instance.</para>
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
        /// <para>The region where the Internet Shared Bandwidth instance resides. </para>
        /// <para>You can call <b>DescribeRegions</b> to query the region ID.</para>
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

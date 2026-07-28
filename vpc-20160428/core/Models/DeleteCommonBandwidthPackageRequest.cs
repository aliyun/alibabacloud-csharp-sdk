// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteCommonBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Internet Shared Bandwidth instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbwp-2ze2ic1xd2qeqk145pn4u</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly delete the Internet Shared Bandwidth instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): The Internet Shared Bandwidth instance is deleted only if it does not contain elastic IP addresses (EIPs).</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: All EIPs are removed from the Internet Shared Bandwidth instance, and then the instance is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public string Force { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region where the Internet Shared Bandwidth instance resides. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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

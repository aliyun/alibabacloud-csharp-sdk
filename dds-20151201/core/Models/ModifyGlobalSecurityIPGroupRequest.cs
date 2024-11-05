// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyGlobalSecurityIPGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses in the whitelist template.</para>
        /// <remarks>
        /// <para>Separate multiple IP addresses with commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP address whitelists.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.16.214.10,111.60.117.181</para>
        /// </summary>
        [NameInMap("GIpList")]
        [Validation(Required=false)]
        public string GIpList { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dps</para>
        /// </summary>
        [NameInMap("GlobalIgName")]
        [Validation(Required=false)]
        public string GlobalIgName { get; set; }

        /// <summary>
        /// <para>The ID of the IP whitelist template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-fwjk62egbsrp4sftxmmr</para>
        /// </summary>
        [NameInMap("GlobalSecurityGroupId")]
        [Validation(Required=false)]
        public string GlobalSecurityGroupId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

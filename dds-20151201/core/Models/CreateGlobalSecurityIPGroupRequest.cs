// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateGlobalSecurityIPGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses in the whitelist template.</para>
        /// <remarks>
        /// <para>Separate multiple IP addresses with commas (,). You can create up to 1,000 IP addresses or CIDR blocks for all IP address whitelists.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.18.86.18,183.92.40.129</para>
        /// </summary>
        [NameInMap("GIpList")]
        [Validation(Required=false)]
        public string GIpList { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>It must start with a letter and end with a letter or digit.</description></item>
        /// <item><description>It must be 2 to 120 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aizy</para>
        /// </summary>
        [NameInMap("GlobalIgName")]
        [Validation(Required=false)]
        public string GlobalIgName { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

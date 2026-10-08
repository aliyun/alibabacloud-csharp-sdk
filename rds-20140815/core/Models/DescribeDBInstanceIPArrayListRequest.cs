// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceIPArrayListRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The network type of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Classic</b>: classic network in the enhanced whitelist mode.</description></item>
        /// <item><description><b>VPC</b>: virtual private cloud (VPC) in the enhanced whitelist mode.</description></item>
        /// <item><description><b>MIX</b>: general whitelist mode.</description></item>
        /// </list>
        /// <para>By default, the IP whitelist of all network types is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("WhitelistNetworkType")]
        [Validation(Required=false)]
        public string WhitelistNetworkType { get; set; }

    }

}

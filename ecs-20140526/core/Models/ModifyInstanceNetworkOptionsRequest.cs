// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceNetworkOptionsRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth weight. Different specifications support different values. You can call the DescribeInstanceTypes operation to query the values supported by the current instance type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Vpc-L1.</description></item>
        /// <item><description>Vpc-L2.</description></item>
        /// <item><description>Ebs-L1.</description></item>
        /// <item><description>Ebs-L2.</description></item>
        /// <item><description>Default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Vpc-L1</para>
        /// </summary>
        [NameInMap("BandwidthWeighting")]
        [Validation(Required=false)]
        public string BandwidthWeighting { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which you want to modify network configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceNetworkOptionsRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth weight.</para>
        /// <para>The supported values vary with instance types. You can query the bandwidth weights supported by the current instance type by using the <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Vpc-L1: Vpc-L1.</description></item>
        /// <item><description>Vpc-L2: Vpc-L2.</description></item>
        /// <item><description>Ebs-L1: Ebs-L1.</description></item>
        /// <item><description>Ebs-L2: Ebs-L2.</description></item>
        /// <item><description>Default: the Default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Vpc-L1</para>
        /// </summary>
        [NameInMap("BandwidthWeighting")]
        [Validation(Required=false)]
        public string BandwidthWeighting { get; set; }

        /// <summary>
        /// <para>The ID of the instance whose network bandwidth weight is to be modified.</para>
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

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
        /// <para>The supported values vary by instance type. You can call <a href="https://help.aliyun.com/document_detail/2679699.html">DescribeInstanceTypes</a> to query the bandwidth weight values supported by the current instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Vpc-L1</para>
        /// </summary>
        [NameInMap("BandwidthWeighting")]
        [Validation(Required=false)]
        public string BandwidthWeighting { get; set; }

        /// <summary>
        /// <para>The instance ID of the instance for which you want to modify the network bandwidth weight.</para>
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

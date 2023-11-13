// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyElasticBandWidthRequest : TeaModel {
        /// <summary>
        /// The new burstable protection bandwidth that you want to use. Unit: Gbit/s.
        /// 
        /// > You can call the [DescribeElasticBandwidthSpec](~~91502~~) operation to query the available burstable protection bandwidth of the instance.
        /// </summary>
        [NameInMap("ElasticBandwidth")]
        [Validation(Required=false)]
        public int? ElasticBandwidth { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  The instance must be in a normal state. You can call the [DescribeInstanceIds](~~157459~~) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionLOARequest : TeaModel {
        /// <summary>
        /// description: The ID of the region where the leased line is deployed. ; 
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// description: Optional. The token used for client authentication. ; 
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// description: The instance ID of the physical connection interface. ; 
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

    }

}

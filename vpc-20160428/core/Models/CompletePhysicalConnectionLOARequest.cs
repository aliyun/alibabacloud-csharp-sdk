// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CompletePhysicalConnectionLOARequest : TeaModel {
        /// <summary>
        /// description: Optional. The token used for client authentication.; 
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// description: The ID of the region where the leased line is deployed.; 
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// description: The instance ID of the physical connection interface.; 
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// description: The number of the leased line.; 
        /// </summary>
        [NameInMap("LineCode")]
        [Validation(Required=true)]
        public string LineCode { get; set; }

        /// <summary>
        /// description: The label numbers of cables at the installation site.; 
        /// </summary>
        [NameInMap("LineLabel")]
        [Validation(Required=true)]
        public string LineLabel { get; set; }

    }

}

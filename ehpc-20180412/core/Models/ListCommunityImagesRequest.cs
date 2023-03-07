// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCommunityImagesRequest : TeaModel {
        /// <summary>
        /// The tag of the base operating system (BOS).
        /// </summary>
        [NameInMap("BaseOsTag")]
        [Validation(Required=false)]
        public string BaseOsTag { get; set; }

        /// <summary>
        /// The ID of the cluster. If the cluster supports multiple operating systems, all community images in the region where the cluster resides are queried.
        /// 
        /// If you do not specify the cluster ID, the community images that are supported by all clusters are queried.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The type of the Elastic Compute Service (ECS) instance. If you do not specify the instance type, the community images that are supported by all instance types are queried.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}

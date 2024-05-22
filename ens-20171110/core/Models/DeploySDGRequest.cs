// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeploySDGRequest : TeaModel {
        /// <summary>
        /// The SDG deployment type. Valid values:
        /// 
        /// *   common (default): read/write deployment. Data updates are written to disks.
        /// *   overlay: read/write splitting deployment. Content in SDGs is read-only. Data updates are written to the local storage of the instance.
        /// </summary>
        [NameInMap("DeploymentType")]
        [Validation(Required=false)]
        public string DeploymentType { get; set; }

        /// <summary>
        /// The IDs of instances on which you want to deploy SDGs. You can deploy SDGs on a maximum of 100 instances at a time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The SDG ID. This parameter is used to create a disk, which is attached to an instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}

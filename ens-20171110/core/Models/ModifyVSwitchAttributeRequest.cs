// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyVSwitchAttributeRequest : TeaModel {
        /// <summary>
        /// The description of the vSwitch.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The name of the vSwitch.
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter but cannot start with http:// or https://.
        /// *   The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

    }

}

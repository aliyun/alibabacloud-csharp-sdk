// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceUpdateRequest : TeaModel {
        /// <summary>
        /// The ID of the instance whose name or description you want to update.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new name of the instance. The name must meet the following rules:
        /// 
        /// *   The name of the instance must be unique in the region where the instance is deployed.
        /// *   The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
        /// *   If you do not configure this parameter, the instance name remains unchanged.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The updated description of the instance. If you do not configure this parameter, the instance description remains unchanged.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

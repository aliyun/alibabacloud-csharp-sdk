// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceCreateRequest : TeaModel {
        /// <summary>
        /// The name of the instance. Valid values:
        /// 
        /// *   The name of the instance must be unique in the region where the instance is deployed.
        /// *   The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

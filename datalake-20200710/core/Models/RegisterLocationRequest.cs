// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class RegisterLocationRequest : TeaModel {
        [NameInMap("InventoryCollectEnabled")]
        [Validation(Required=false)]
        public bool? InventoryCollectEnabled { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("OssLogCollectEnabled")]
        [Validation(Required=false)]
        public bool? OssLogCollectEnabled { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}

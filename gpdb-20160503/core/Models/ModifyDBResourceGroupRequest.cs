// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBResourceGroupRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceGroupItems")]
        [Validation(Required=false)]
        public List<ModifyDBResourceGroupRequestResourceGroupItems> ResourceGroupItems { get; set; }
        public class ModifyDBResourceGroupRequestResourceGroupItems : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceGroupConfig")]
            [Validation(Required=false)]
            public string ResourceGroupConfig { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

        }

    }

}

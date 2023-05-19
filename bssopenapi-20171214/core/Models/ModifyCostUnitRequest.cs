// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ModifyCostUnitRequest : TeaModel {
        /// <summary>
        /// The cost centers to be modified.
        /// </summary>
        [NameInMap("UnitEntityList")]
        [Validation(Required=false)]
        public List<ModifyCostUnitRequestUnitEntityList> UnitEntityList { get; set; }
        public class ModifyCostUnitRequestUnitEntityList : TeaModel {
            /// <summary>
            /// The new name of the cost center.
            /// </summary>
            [NameInMap("NewUnitName")]
            [Validation(Required=false)]
            public string NewUnitName { get; set; }

            /// <summary>
            /// The user ID of the cost center owner.
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            /// <summary>
            /// The ID of the cost center.
            /// </summary>
            [NameInMap("UnitId")]
            [Validation(Required=false)]
            public long? UnitId { get; set; }

        }

    }

}

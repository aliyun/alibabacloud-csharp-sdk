// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateCostUnitRequest : TeaModel {
        /// <summary>
        /// The list of cost centers.
        /// </summary>
        [NameInMap("UnitEntityList")]
        [Validation(Required=false)]
        public List<CreateCostUnitRequestUnitEntityList> UnitEntityList { get; set; }
        public class CreateCostUnitRequestUnitEntityList : TeaModel {
            /// <summary>
            /// The user ID of the owner of the cost center.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            /// <summary>
            /// The ID of the parent cost center. A value of -1 indicates the root cost center.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParentUnitId")]
            [Validation(Required=false)]
            public long? ParentUnitId { get; set; }

            /// <summary>
            /// The name of the cost center.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("UnitName")]
            [Validation(Required=false)]
            public string UnitName { get; set; }

        }

    }

}

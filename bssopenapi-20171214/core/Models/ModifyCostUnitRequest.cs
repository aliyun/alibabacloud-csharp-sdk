// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ModifyCostUnitRequest : TeaModel {
        /// <summary>
        /// <para>The cost centers to be modified.</para>
        /// </summary>
        [NameInMap("UnitEntityList")]
        [Validation(Required=false)]
        public List<ModifyCostUnitRequestUnitEntityList> UnitEntityList { get; set; }
        public class ModifyCostUnitRequestUnitEntityList : TeaModel {
            /// <summary>
            /// <para>The new name of the cost center.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>newTest</para>
            /// </summary>
            [NameInMap("NewUnitName")]
            [Validation(Required=false)]
            public string NewUnitName { get; set; }

            /// <summary>
            /// <para>The user ID of the cost center owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1321312312</para>
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            /// <summary>
            /// <para>The ID of the cost center.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2524352</para>
            /// </summary>
            [NameInMap("UnitId")]
            [Validation(Required=false)]
            public long? UnitId { get; set; }

        }

    }

}

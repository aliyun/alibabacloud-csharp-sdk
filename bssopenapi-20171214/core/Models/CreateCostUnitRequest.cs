// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateCostUnitRequest : TeaModel {
        /// <summary>
        /// <para>The list of financial units.</para>
        /// </summary>
        [NameInMap("UnitEntityList")]
        [Validation(Required=false)]
        public List<CreateCostUnitRequestUnitEntityList> UnitEntityList { get; set; }
        public class CreateCostUnitRequestUnitEntityList : TeaModel {
            /// <summary>
            /// <para>The ID of the owner of the new financial unit.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>982375623</para>
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            /// <summary>
            /// <para>The ID of the parent financial unit. A value of -1 indicates the root financial unit.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentUnitId")]
            [Validation(Required=false)]
            public long? ParentUnitId { get; set; }

            /// <summary>
            /// <para>The name of the financial unit.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UnitName")]
            [Validation(Required=false)]
            public string UnitName { get; set; }

        }

    }

}

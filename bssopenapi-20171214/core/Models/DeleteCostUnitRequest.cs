// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DeleteCostUnitRequest : TeaModel {
        /// <summary>
        /// <para>The user ID of the cost center owner.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2135342</para>
        /// </summary>
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public long? OwnerUid { get; set; }

        /// <summary>
        /// <para>The ID of the cost center. A value of -1 indicates the root cost center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>376348</para>
        /// </summary>
        [NameInMap("UnitId")]
        [Validation(Required=false)]
        public long? UnitId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ModifyCostCenterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of cost center entities.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CostCenterEntityList")]
        [Validation(Required=false)]
        public string CostCenterEntityListShrink { get; set; }

        /// <summary>
        /// <para>The level-1 marketplace ID. If this parameter is left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}

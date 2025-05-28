// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateCostCenterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CostCenterEntityList")]
        [Validation(Required=false)]
        public string CostCenterEntityListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}

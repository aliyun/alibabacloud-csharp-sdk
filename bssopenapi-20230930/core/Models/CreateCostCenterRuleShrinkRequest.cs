// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateCostCenterRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Financial unit ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>485938</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>Rule expression</para>
        /// </summary>
        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public string FilterExpressionShrink { get; set; }

        /// <summary>
        /// <para>First-level marketplace ID. If left empty, the ID of the marketplace to which the current user belongs is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}

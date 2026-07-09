// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DeleteCostCenterRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Financial unit ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>637127</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>Rule expression.
        /// <b>This field does not need to be entered during the delete operation.</b></para>
        /// </summary>
        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public string FilterExpressionShrink { get; set; }

        /// <summary>
        /// <para>Level-1 marketplace ID. If empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}

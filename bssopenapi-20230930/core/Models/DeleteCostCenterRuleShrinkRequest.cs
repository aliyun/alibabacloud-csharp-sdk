// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DeleteCostCenterRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>637127</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>The rule expression.
        /// <b>This field does not need to be specified for delete operations.</b></para>
        /// </summary>
        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public string FilterExpressionShrink { get; set; }

        /// <summary>
        /// <para>The primary marketplace ID. If left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}

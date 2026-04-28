// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBudgetPoliciesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cg-p3gk2oh55c**</para>
        /// </summary>
        [NameInMap("BudgetDimensionRefId")]
        [Validation(Required=false)]
        public string BudgetDimensionRefId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ConsumerGroup</para>
        /// </summary>
        [NameInMap("BudgetDimensionType")]
        [Validation(Required=false)]
        public string BudgetDimensionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>023aacc1effc4b56bb154bfbec6baxxx</para>
        /// </summary>
        [NameInMap("BudgetPolicyId")]
        [Validation(Required=false)]
        public string BudgetPolicyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class RunEvaluationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member account. This parameter is applicable only to the multi-account check pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176618589410****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        [NameInMap("EvaluationDomain")]
        [Validation(Required=false)]
        public string EvaluationDomain { get; set; }

        /// <summary>
        /// <para>The list of check item IDs to check.</para>
        /// </summary>
        [NameInMap("MetricIds")]
        [Validation(Required=false)]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scope of the governance maturity check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Account (default): runs a single-account governance maturity check that checks only the current account.</description></item>
        /// <item><description>ResourceDirectory: runs a multi-account governance maturity check that checks all member accounts in the resource directory. Before you perform this operation, upgrade to the multi-account governance maturity check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceDirectory</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateBudgetPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The budget policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05a5a8603df444a8a605af712ffexxx</para>
        /// </summary>
        [NameInMap("BudgetPolicyId")]
        [Validation(Required=false)]
        public string BudgetPolicyId { get; set; }

        /// <summary>
        /// <para>The gateway cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class DeptBalanceSummaryDTO : TeaModel {
        /// <summary>
        /// <para>The monthly balance pool overview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("monthly")]
        [Validation(Required=false)]
        public BalancePoolSummaryDTO Monthly { get; set; }

        /// <summary>
        /// <para>The permanent balance pool overview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("permanent")]
        [Validation(Required=false)]
        public BalancePoolSummaryDTO Permanent { get; set; }

    }

}

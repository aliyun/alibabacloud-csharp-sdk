// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawSkillAssessmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The assessment result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;zhReportContent&quot;:&quot;# Skill Security Assessment Report\n\n&gt; <b>Risk level:</b> ...}</para>
        /// </summary>
        [NameInMap("AssessmentResult")]
        [Validation(Required=false)]
        public string AssessmentResult { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD3FA5F3-FAF3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

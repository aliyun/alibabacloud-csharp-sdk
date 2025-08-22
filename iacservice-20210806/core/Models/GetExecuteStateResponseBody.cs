// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetExecuteStateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Your account does not have enough balance to order postpaid product.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;tf-plan.run.log&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("logFile")]
        [Validation(Required=false)]
        public Dictionary<string, object> LogFile { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4672AE3-C313-5B7A-BB24-45345570D398</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;: 4, &quot;terraform_version&quot;: &quot;1.5.7&quot;, &quot;serial&quot;: 3, &quot;lineage&quot;: &quot;cb71b0b2-1ec2-6483-d409-8cae23186ec6&quot;,  &quot;outputs&quot;: {}, &quot;resources&quot;: [], &quot;check_results&quot;: null}</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

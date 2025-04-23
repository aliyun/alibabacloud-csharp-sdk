// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned job information.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyMessage Message { get; set; }
        public class DescribeJobResponseBodyMessage : TeaModel {
            /// <summary>
            /// <para>The details of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;2.scheduler&quot;: {&quot;egroup&quot;: &quot;users&quot;,&quot;Stageout_status&quot;: 1,&quot;Keep_Files&quot;: &quot;n&quot;,&quot;server&quot;: &quot;scheduler&quot;,&quot;queue&quot;: &quot;workq&quot;}}</para>
            /// </summary>
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public string JobInfo { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9697AD8D-56FA-4C8E-B46C-00AC9***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

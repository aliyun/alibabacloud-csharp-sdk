// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySmarttagJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Success</b>: The job was successful.</para>
        /// </description></item>
        /// <item><description><para><b>Fail</b>: The job failed.</para>
        /// </description></item>
        /// <item><description><para><b>Processing</b>: The job is in progress.</para>
        /// </description></item>
        /// <item><description><para><b>Submitted</b>: The job is queued for processing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public QuerySmarttagJobResponseBodyResults Results { get; set; }
        public class QuerySmarttagJobResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QuerySmarttagJobResponseBodyResultsResult> Result { get; set; }
            public class QuerySmarttagJobResponseBodyResultsResult : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Usages")]
        [Validation(Required=false)]
        public QuerySmarttagJobResponseBodyUsages Usages { get; set; }
        public class QuerySmarttagJobResponseBodyUsages : TeaModel {
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public List<QuerySmarttagJobResponseBodyUsagesUsage> Usage { get; set; }
            public class QuerySmarttagJobResponseBodyUsagesUsage : TeaModel {
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public long? Quota { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The custom data passed through the MNS callback. For details on the message format, see the callback message format definitions below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;123432412831&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

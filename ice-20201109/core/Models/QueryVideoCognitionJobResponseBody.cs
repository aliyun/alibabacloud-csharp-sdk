// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryVideoCognitionJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The input file.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public QueryVideoCognitionJobResponseBodyInput Input { get; set; }
        public class QueryVideoCognitionJobResponseBodyInput : TeaModel {
            /// <summary>
            /// <para>The URL of the input file.</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input file. Valid value: OSS.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Success</b>: The job succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>Fail</b>: The job failed.</para>
        /// </description></item>
        /// <item><description><para><b>Processing</b>: The job is in progress.</para>
        /// </description></item>
        /// <item><description><para><b>Submitted</b>: The job has been submitted and is awaiting processing.</para>
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
        /// <para>The request parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

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
        public QueryVideoCognitionJobResponseBodyResults Results { get; set; }
        public class QueryVideoCognitionJobResponseBodyResults : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<QueryVideoCognitionJobResponseBodyResultsResult> Result { get; set; }
            public class QueryVideoCognitionJobResponseBodyResultsResult : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The template ID.</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;123432412831&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

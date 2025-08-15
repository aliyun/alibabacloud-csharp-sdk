// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryVideoCognitionJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;title&quot;:&quot;example-title-****&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ASR</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;123432412831&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

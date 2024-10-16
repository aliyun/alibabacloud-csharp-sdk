// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySmarttagJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7B117AF5-2A16-412C-B127-FA6175ED1AD0</para>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;title&quot;:&quot;example-title-****&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Meta</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example UserData ****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

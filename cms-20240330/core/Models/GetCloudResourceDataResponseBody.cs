// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetCloudResourceDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<List<string>> Data { get; set; }

        /// <summary>
        /// <para>The list of column headers.</para>
        /// </summary>
        [NameInMap("header")]
        [Validation(Required=false)]
        public List<string> Header { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("responseStatus")]
        [Validation(Required=false)]
        public GetCloudResourceDataResponseBodyResponseStatus ResponseStatus { get; set; }
        public class GetCloudResourceDataResponseBodyResponseStatus : TeaModel {
            [NameInMap("executionStates")]
            [Validation(Required=false)]
            public string ExecutionStates { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("retryPolicy")]
            [Validation(Required=false)]
            public string RetryPolicy { get; set; }

            [NameInMap("statusItem")]
            [Validation(Required=false)]
            public List<GetCloudResourceDataResponseBodyResponseStatusStatusItem> StatusItem { get; set; }
            public class GetCloudResourceDataResponseBodyResponseStatusStatusItem : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

        }

    }

}

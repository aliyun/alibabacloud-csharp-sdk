// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListFeedbacksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFeedbacksResponseBodyData> Data { get; set; }
        public class ListFeedbacksResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>job-25920271311543****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20251216-8B9B7B02-16FE-54BE-942A-F59DE0656032</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PostCallAnalyzer:solution</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("UserRating")]
            [Validation(Required=false)]
            public int? UserRating { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxxx</para>
            /// </summary>
            [NameInMap("UserResponse")]
            [Validation(Required=false)]
            public string UserResponse { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26E54929-CA86-1035-9B42-0C8F291BB027</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

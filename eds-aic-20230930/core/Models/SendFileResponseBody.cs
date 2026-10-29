// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SendFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SendFileResponseBodyData> Data { get; set; }
        public class SendFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-34pqe4r0kd9kn****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-4ks224ujixw****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request. If you encounter any issues, provide this request ID to the technical support team for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the batch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-ehs0yoedj0xe9****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetHttpEventConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHttpEventConfigResponseBodyData Data { get; set; }
        public class GetHttpEventConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://123213.com">http://123213.com</a></para>
            /// </summary>
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;eventConfig&quot;: { &quot;taskCompleteEvent&quot;:true}</para>
            /// </summary>
            [NameInMap("EventConfig")]
            [Validation(Required=false)]
            public GetHttpEventConfigResponseBodyDataEventConfig EventConfig { get; set; }
            public class GetHttpEventConfigResponseBodyDataEventConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ComplaintHandledEvent")]
                [Validation(Required=false)]
                public bool? ComplaintHandledEvent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FileReviewedEvent")]
                [Validation(Required=false)]
                public bool? FileReviewedEvent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SyncTaskCompleteEvent")]
                [Validation(Required=false)]
                public bool? SyncTaskCompleteEvent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TaskCompleteEvent")]
                [Validation(Required=false)]
                public bool? TaskCompleteEvent { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("HttpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SwitchFlag")]
            [Validation(Required=false)]
            public bool? SwitchFlag { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9987D326-83D9-4A42-B9A5-0B27F9B40539</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

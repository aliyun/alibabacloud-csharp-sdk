// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class QueryMsgStatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMsgStatResponseBodyData Data { get; set; }
        public class QueryMsgStatResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Accept")]
            [Validation(Required=false)]
            public long? Accept { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Arrive")]
            [Validation(Required=false)]
            public long? Arrive { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ClosePush")]
            [Validation(Required=false)]
            public long? ClosePush { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Dismiss")]
            [Validation(Required=false)]
            public long? Dismiss { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ufe29y2167046828041801</para>
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Open")]
            [Validation(Required=false)]
            public long? Open { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sent")]
            [Validation(Required=false)]
            public long? Sent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86C4236B-D6C2-1E31-8370-2FAEC5CFE012</para>
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

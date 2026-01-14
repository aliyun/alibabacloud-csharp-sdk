// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetMailTaskListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0c52************8e1952a3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMailTaskListResponseBodyResult Result { get; set; }
        public class GetMailTaskListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetMailTaskListResponseBodyResultData> Data { get; set; }
            public class GetMailTaskListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BizOwnerName")]
                [Validation(Required=false)]
                public string BizOwnerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>asag****2423</para>
                /// </summary>
                [NameInMap("BizOwnerUserId")]
                [Validation(Required=false)]
                public string BizOwnerUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2342526</para>
                /// </summary>
                [NameInMap("MailId")]
                [Validation(Required=false)]
                public string MailId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Paused")]
                [Validation(Required=false)]
                public bool? Paused { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SubscribeName")]
                [Validation(Required=false)]
                public string SubscribeName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public int? Next { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Pre")]
            [Validation(Required=false)]
            public int? Pre { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

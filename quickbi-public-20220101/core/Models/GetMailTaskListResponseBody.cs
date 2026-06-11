// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetMailTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c52************8e1952a3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The paging information for the tracking tasks.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMailTaskListResponseBodyResult Result { get; set; }
        public class GetMailTaskListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>An array of tracking task models.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetMailTaskListResponseBodyResultData> Data { get; set; }
            public class GetMailTaskListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The nickname of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BizOwnerName")]
                [Validation(Required=false)]
                public string BizOwnerName { get; set; }

                /// <summary>
                /// <para>The user ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asag****2423</para>
                /// </summary>
                [NameInMap("BizOwnerUserId")]
                [Validation(Required=false)]
                public string BizOwnerUserId { get; set; }

                /// <summary>
                /// <para>The mail ID of the tracking task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2342526</para>
                /// </summary>
                [NameInMap("MailId")]
                [Validation(Required=false)]
                public string MailId { get; set; }

                /// <summary>
                /// <para>Indicates whether the task is paused.</para>
                /// <list type="bullet">
                /// <item><description><para>true: The task is paused.</para>
                /// </description></item>
                /// <item><description><para>false: The task is not paused.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Paused")]
                [Validation(Required=false)]
                public bool? Paused { get; set; }

                /// <summary>
                /// <para>The name of the tracking task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SubscribeName")]
                [Validation(Required=false)]
                public string SubscribeName { get; set; }

            }

            /// <summary>
            /// <para>The next page number. A value of null or 0 indicates that there is no next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Next")]
            [Validation(Required=false)]
            public int? Next { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page that was set for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The previous page number. A value of null or 0 indicates that there is no previous page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Pre")]
            [Validation(Required=false)]
            public int? Pre { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

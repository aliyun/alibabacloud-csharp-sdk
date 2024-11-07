// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class QuerySyncStatusByAliUidResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySyncStatusByAliUidResponseBodyData Data { get; set; }
        public class QuerySyncStatusByAliUidResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>131239236086****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cdrs948144195608****</para>
            /// </summary>
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-06-30 07:50:42</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-02 14:27:39</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18500</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-02 14:31:39</para>
            /// </summary>
            [NameInMap("LatestBeginTime")]
            [Validation(Required=false)]
            public string LatestBeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-02 16:13:12</para>
            /// </summary>
            [NameInMap("LatestEndTime")]
            [Validation(Required=false)]
            public string LatestEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-02 18:24:01</para>
            /// </summary>
            [NameInMap("LatestSuccessTime")]
            [Validation(Required=false)]
            public string LatestSuccessTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAuditHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The review records.</para>
        /// </summary>
        [NameInMap("Histories")]
        [Validation(Required=false)]
        public List<GetAuditHistoryResponseBodyHistories> Histories { get; set; }
        public class GetAuditHistoryResponseBodyHistories : TeaModel {
            /// <summary>
            /// <para>The reviewer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auditor</para>
            /// </summary>
            [NameInMap("Auditor")]
            [Validation(Required=false)]
            public string Auditor { get; set; }

            /// <summary>
            /// <para>The review comments, which are provided by the reviewer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Contains nudity</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the review record was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The reason why the video failed the review. If the video failed the review, specify the reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pornographic video</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The manual review result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The video can be played.</description></item>
            /// <item><description><b>Blocked</b>: The video is blocked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Blocked</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-43*****D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The manual review result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The video can be played.</description></item>
        /// <item><description><b>Blocked</b>: The video is blocked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of review records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditAudioResultDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of review results.</para>
        /// </summary>
        [NameInMap("MediaAuditAudioResultDetail")]
        [Validation(Required=false)]
        public GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail MediaAuditAudioResultDetail { get; set; }
        public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail : TeaModel {
            /// <summary>
            /// <para>The list of results.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList> List { get; set; }
            public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList : TeaModel {
                /// <summary>
                /// <para>The end time of the audio that failed the review. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The review results. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>spam</b></description></item>
                /// <item><description><b>ad</b></description></item>
                /// <item><description><b>abuse</b></description></item>
                /// <item><description><b>flood</b></description></item>
                /// <item><description><b>contraband</b></description></item>
                /// <item><description><b>meaningless</b></description></item>
                /// <item><description><b>normal</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>abuse</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The start time of the audio that failed the review. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The text that corresponds to the audio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beauty</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }

            /// <summary>
            /// <para>The total number of pages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB7D7232-1AB2-40FE-B8D3-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

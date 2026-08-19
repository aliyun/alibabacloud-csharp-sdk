// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditAudioResultDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The review results.</para>
        /// </summary>
        [NameInMap("MediaAuditAudioResultDetail")]
        [Validation(Required=false)]
        public GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail MediaAuditAudioResultDetail { get; set; }
        public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail : TeaModel {
            /// <summary>
            /// <para>The result list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList> List { get; set; }
            public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList : TeaModel {
                /// <summary>
                /// <para>The end time of the problematic audio segment. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The category of the audio review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// <item><description><b>spam</b>: Contains spam.</description></item>
                /// <item><description><b>ad</b>: Advertisement.</description></item>
                /// <item><description><b>politics</b>: Political content.</description></item>
                /// <item><description><b>terrorism</b>: Terrorist content.</description></item>
                /// <item><description><b>abuse</b>: Abusive content.</description></item>
                /// <item><description><b>porn</b>: Pornographic content.</description></item>
                /// <item><description><b>flood</b>: Junk content.</description></item>
                /// <item><description><b>contraband</b>: Prohibited content.</description></item>
                /// <item><description><b>meaningless</b>: Meaningless content.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>abuse</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The start time of the problematic audio segment. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The text content corresponding to the audio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tiananmen</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB7D7232-1AB2-40FE-B8D3-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListByMailFromAndTagNameResponseBody : TeaModel {
        [NameInMap("OffsetCreateTime")]
        [Validation(Required=false)]
        public string OffsetCreateTime { get; set; }

        [NameInMap("OffsetCreateTimeDesc")]
        [Validation(Required=false)]
        public string OffsetCreateTimeDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("TrackList")]
        [Validation(Required=false)]
        public GetTrackListByMailFromAndTagNameResponseBodyTrackList TrackList { get; set; }
        public class GetTrackListByMailFromAndTagNameResponseBodyTrackList : TeaModel {
            [NameInMap("Stat")]
            [Validation(Required=false)]
            public List<GetTrackListByMailFromAndTagNameResponseBodyTrackListStat> Stat { get; set; }
            public class GetTrackListByMailFromAndTagNameResponseBodyTrackListStat : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-11T10:11Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptClickCount")]
                [Validation(Required=false)]
                public string RcptClickCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptClickRate")]
                [Validation(Required=false)]
                public string RcptClickRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptOpenCount")]
                [Validation(Required=false)]
                public string RcptOpenCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptOpenRate")]
                [Validation(Required=false)]
                public string RcptOpenRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueClickCount")]
                [Validation(Required=false)]
                public string RcptUniqueClickCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueClickRate")]
                [Validation(Required=false)]
                public string RcptUniqueClickRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueOpenCount")]
                [Validation(Required=false)]
                public string RcptUniqueOpenCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueOpenRate")]
                [Validation(Required=false)]
                public string RcptUniqueOpenRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalNumber")]
                [Validation(Required=false)]
                public string TotalNumber { get; set; }

            }

        }

    }

}

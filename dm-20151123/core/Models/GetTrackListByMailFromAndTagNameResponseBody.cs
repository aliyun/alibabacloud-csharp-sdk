// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListByMailFromAndTagNameResponseBody : TeaModel {
        /// <summary>
        /// <para>Used for pagination. Not set for the first query; for subsequent queries, set to the value of OffsetCreateTime from the previous response. (This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("OffsetCreateTime")]
        [Validation(Required=false)]
        public string OffsetCreateTime { get; set; }

        /// <summary>
        /// <para>(This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("OffsetCreateTimeDesc")]
        [Validation(Required=false)]
        public string OffsetCreateTimeDesc { get; set; }

        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>(This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public string TotalPages { get; set; }

        /// <summary>
        /// <para>Tracking data records</para>
        /// </summary>
        [NameInMap("TrackList")]
        [Validation(Required=false)]
        public GetTrackListByMailFromAndTagNameResponseBodyTrackList TrackList { get; set; }
        public class GetTrackListByMailFromAndTagNameResponseBodyTrackList : TeaModel {
            [NameInMap("Stat")]
            [Validation(Required=false)]
            public List<GetTrackListByMailFromAndTagNameResponseBodyTrackListStat> Stat { get; set; }
            public class GetTrackListByMailFromAndTagNameResponseBodyTrackListStat : TeaModel {
                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-11T10:11Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Click count</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptClickCount")]
                [Validation(Required=false)]
                public string RcptClickCount { get; set; }

                /// <summary>
                /// <para>Click rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptClickRate")]
                [Validation(Required=false)]
                public string RcptClickRate { get; set; }

                /// <summary>
                /// <para>Number of opens</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptOpenCount")]
                [Validation(Required=false)]
                public string RcptOpenCount { get; set; }

                /// <summary>
                /// <para>Open rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptOpenRate")]
                [Validation(Required=false)]
                public string RcptOpenRate { get; set; }

                /// <summary>
                /// <para>Unique click count</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueClickCount")]
                [Validation(Required=false)]
                public string RcptUniqueClickCount { get; set; }

                /// <summary>
                /// <para>Unique click rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueClickRate")]
                [Validation(Required=false)]
                public string RcptUniqueClickRate { get; set; }

                /// <summary>
                /// <para>Unique open count</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueOpenCount")]
                [Validation(Required=false)]
                public string RcptUniqueOpenCount { get; set; }

                /// <summary>
                /// <para>Unique open rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RcptUniqueOpenRate")]
                [Validation(Required=false)]
                public string RcptUniqueOpenRate { get; set; }

                /// <summary>
                /// <para>Total number</para>
                /// 
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

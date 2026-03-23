// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListResponseBody : TeaModel {
        /// <summary>
        /// <para>Used for pagination. Do not set this parameter for the first request. For subsequent requests, set this parameter to the OffsetCreateTime value from the previous response. (This field is deprecated.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("OffsetCreateTime")]
        [Validation(Required=false)]
        public string OffsetCreateTime { get; set; }

        /// <summary>
        /// <para>(This field is deprecated.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("OffsetCreateTimeDesc")]
        [Validation(Required=false)]
        public string OffsetCreateTimeDesc { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matching records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTrackListResponseBodyData Data { get; set; }
        public class GetTrackListResponseBodyData : TeaModel {
            [NameInMap("stat")]
            [Validation(Required=false)]
            public List<GetTrackListResponseBodyDataStat> Stat { get; set; }
            public class GetTrackListResponseBodyDataStat : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("RcptClickCount")]
                [Validation(Required=false)]
                public string RcptClickCount { get; set; }

                [NameInMap("RcptClickRate")]
                [Validation(Required=false)]
                public string RcptClickRate { get; set; }

                [NameInMap("RcptOpenCount")]
                [Validation(Required=false)]
                public string RcptOpenCount { get; set; }

                [NameInMap("RcptOpenRate")]
                [Validation(Required=false)]
                public string RcptOpenRate { get; set; }

                [NameInMap("RcptUniqueClickCount")]
                [Validation(Required=false)]
                public string RcptUniqueClickCount { get; set; }

                [NameInMap("RcptUniqueClickRate")]
                [Validation(Required=false)]
                public string RcptUniqueClickRate { get; set; }

                [NameInMap("RcptUniqueOpenCount")]
                [Validation(Required=false)]
                public string RcptUniqueOpenCount { get; set; }

                [NameInMap("RcptUniqueOpenRate")]
                [Validation(Required=false)]
                public string RcptUniqueOpenRate { get; set; }

                [NameInMap("TotalNumber")]
                [Validation(Required=false)]
                public string TotalNumber { get; set; }

            }

        }

    }

}

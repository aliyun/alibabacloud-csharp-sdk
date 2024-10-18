// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryLiveWatchDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>84600</para>
        /// </summary>
        [NameInMap("avgWatchTime")]
        [Validation(Required=false)]
        public long? AvgWatchTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("liveUv")]
        [Validation(Required=false)]
        public int? LiveUv { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("msgCount")]
        [Validation(Required=false)]
        public int? MsgCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("playbackUv")]
        [Validation(Required=false)]
        public int? PlaybackUv { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("praiseCount")]
        [Validation(Required=false)]
        public int? PraiseCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("pv")]
        [Validation(Required=false)]
        public int? Pv { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1222000</para>
        /// </summary>
        [NameInMap("totalWatchTime")]
        [Validation(Required=false)]
        public long? TotalWatchTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("uv")]
        [Validation(Required=false)]
        public int? Uv { get; set; }

    }

}

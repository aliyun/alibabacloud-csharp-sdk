// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveTranscodeJobsRequest : TeaModel {
        /// <summary>
        /// <para>The search keyword. You can search by task ID or name. Name supports fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24ecbb5c-4f98-4194-9400-f17102e27fc5</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort order. Sorts by CreateTime. Default value: desc.</para>
        /// <list type="bullet">
        /// <item><description>asc: ascending order</description></item>
        /// <item><description>desc: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start mode.</para>
        /// <list type="bullet">
        /// <item><description>0: start immediately</description></item>
        /// <item><description>1: scheduled start</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartMode")]
        [Validation(Required=false)]
        public int? StartMode { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <list type="bullet">
        /// <item><description><para>0: not started</para>
        /// </description></item>
        /// <item><description><para>1: running</para>
        /// </description></item>
        /// <item><description><para>2: stopped</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The template type corresponding to the transcoding task.</para>
        /// <list type="bullet">
        /// <item><description>normal: standard</description></item>
        /// <item><description>narrow-band: narrow bandwidth high definition</description></item>
        /// <item><description>audio-only: audio only</description></item>
        /// <item><description>origin: original quality</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

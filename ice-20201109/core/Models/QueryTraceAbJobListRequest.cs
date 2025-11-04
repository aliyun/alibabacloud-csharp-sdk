// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryTraceAbJobListRequest : TeaModel {
        /// <summary>
        /// <para>The end of the creation time range for the query, in UNIX timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627357325</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the creation time range for the query, in UNIX timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627357322</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The job ID. You can obtain the value of this parameter from the response of the SubmitTraceAbJob operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>d80e4e4044975745c14b</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The media ID for the trace watermark. You can obtain this from the response of the SubmitTraceAbJob operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>437bd2b51105d07b12a9</b></b></para>
        /// </summary>
        [NameInMap("TraceMediaId")]
        [Validation(Required=false)]
        public string TraceMediaId { get; set; }

    }

}

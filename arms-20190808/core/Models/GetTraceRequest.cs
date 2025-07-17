// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTraceRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>If the ID of the trace is 30 characters in length, this parameter is optional. Otherwise, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1623827603000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on each page. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>If the ID of the trace is 30 characters in length, this parameter is optional. Otherwise, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1623827602000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The trace ID. You can log on to the ARMS console and obtain the trace ID on the <b>Trace Query</b> page or <b>Interface Snapshot</b> tab.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac14001a15954493811405707d****</para>
        /// </summary>
        [NameInMap("TraceID")]
        [Validation(Required=false)]
        public string TraceID { get; set; }

    }

}

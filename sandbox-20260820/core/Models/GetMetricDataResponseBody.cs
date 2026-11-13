// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class GetMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>成功时为 200。失败时为对应的错误码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>本次请求的结果说明。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>各指标的查询结果及对应的时间和分组。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;period&quot;:60,&quot;startTime&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T00:02:00Z&quot;,&quot;groupBy&quot;:[&quot;teamID&quot;],&quot;results&quot;:[{&quot;metricName&quot;:&quot;cpuUsedCores&quot;,&quot;unit&quot;:&quot;Core&quot;,&quot;series&quot;:[{&quot;dimensions&quot;:{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;},&quot;points&quot;:[{&quot;timestamp&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;value&quot;:0.25},{&quot;timestamp&quot;:&quot;2026-11-05T00:01:00Z&quot;,&quot;value&quot;:0.5}]}]}]}</para>
        /// </summary>
        [NameInMap("metricData")]
        [Validation(Required=false)]
        public MetricData MetricData { get; set; }

        /// <summary>
        /// <para>本次请求的唯一标识。</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-5678-9abc-123456789abc</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

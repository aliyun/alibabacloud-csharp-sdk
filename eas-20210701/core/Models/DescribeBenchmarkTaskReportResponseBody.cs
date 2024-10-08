// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeBenchmarkTaskReportResponseBody : TeaModel {
        /// <summary>
        /// <para>If the value of ReportType is set to RAW, the details about the stress testing report are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;TimestampList&quot;: [&quot;int64&quot;],
        ///     &quot;QPSList&quot;: [&quot;float32&quot;],
        ///     &quot;RTList&quot;: [
        ///       {
        ///         &quot;AVG&quot;: &quot;float32&quot;,
        ///         &quot;TP100&quot;: &quot;float32&quot;,
        ///         &quot;TP99&quot;: &quot;float32&quot;,
        ///         &quot;TP90&quot;: &quot;float32&quot;,
        ///         &quot;TP50&quot;: &quot;float32&quot;,
        ///         &quot;TP10&quot;: &quot;float32&quot;
        ///       }
        ///     ],
        ///     &quot;TrafficList&quot;: [
        ///       {
        ///         &quot;Send&quot;: &quot;float64&quot;,
        ///         &quot;Receive&quot;: &quot;float64&quot;
        ///       }
        ///     ],
        ///     &quot;StatusCode&quot;: {
        ///       &quot;200&quot;: &quot;uint64&quot;,
        ///       &quot;450&quot;: &quot;uint64&quot;,
        ///       &quot;500&quot;: &quot;uint64&quot;
        ///     },
        ///     &quot;Count&quot;: &quot;uint64&quot;,
        ///     &quot;Total&quot;: &quot;float64&quot;,
        ///     &quot;MinRT&quot;: &quot;float32&quot;,
        ///     &quot;AvgRT&quot;: &quot;float32&quot;,
        ///     &quot;MaxRT&quot;: &quot;float32&quot;,
        ///     &quot;QPS&quot;: &quot;float32&quot;,
        ///     &quot;TotalSend&quot;: &quot;float64&quot;,
        ///     &quot;TotalReceive&quot;: &quot;float64&quot;,
        ///     &quot;RTDistribution&quot;: [
        ///       {
        ///         &quot;Latency&quot;: &quot;float32&quot;,
        ///         &quot;Percentage&quot;: &quot;int&quot;
        ///       }
        ///     ],
        ///     &quot;RTHistogram&quot;: [
        ///       {
        ///         &quot;Count&quot;: &quot;int&quot;,
        ///         &quot;Mark&quot;: &quot;float32&quot;,
        ///         &quot;Frequency&quot;: &quot;float32&quot;
        ///       }
        ///     ]
        ///   }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>If the value of ReportType is set to Report, the URL of the stress testing report is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://eas-benchmark.oss-cn-chengdu.aliyuncs.com/summary/benchmark-larec-test-015d-10007.html">http://eas-benchmark.oss-cn-chengdu.aliyuncs.com/summary/benchmark-larec-test-015d-10007.html</a></para>
        /// </summary>
        [NameInMap("ReportUrl")]
        [Validation(Required=false)]
        public string ReportUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

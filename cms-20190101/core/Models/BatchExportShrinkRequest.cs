// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class BatchExportShrinkRequest : TeaModel {
        /// <summary>
        /// <para>When you call this operation in a loop to export data, you must specify the value of <c>Cursor</c>. You can obtain the value of <c>Cursor</c> by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description><para>When you call this operation for the first time, you must first call the Cursor operation to obtain the value of <c>Cursor</c>. For more information, see <a href="https://help.aliyun.com/document_detail/2330730.html">Cursor</a>.</para>
        /// </description></item>
        /// <item><description><para>When you call this operation again, you can obtain the value of <c>Cursor</c> from the response of the last call.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJidWNrZXRzIjo0LCJjdXJzb3IiOiIxNjQxNDU0MzIwMDAwMWUxY2YxNWY0NTU0MTliZjllYTY4OWQ2ODI1OTU1Yzc1NmZjMDQ2OTMxMzczMzM2MzUzMTMxMzEzMzM0MzMzODM5MzEzMTMwMjQyYzY5MmQ3NTY2MzYzMjY3NmI2ZjM5MzU2YjY4MzAzMTYyNzg3MTcwNjkzMTM3MjQyYyIsImN1cnNvclZlcnNpb24iOiJxdWVyeSIsImVuZFRpbWUiOjE2NDE0NTQ3OTU4MjMsImV4cG9ydEVuZFRpbWUiOjE2NDE0NTQ3OTU4MjMsImV4cG9ydFN0YXJ0VGltZSI6MTY0MTQ1NDE5NTgyMywiZXhwcmVzc1JhbmdlIjpmYWxzZSwiaGFzTmV4dCI6dHJ1ZSwiaW5wdXRNZXRyaWMiOiJDUFVVdGlsaXphdGlvbiIsImlucHV0TmFtZXNwYWNlIjoiYWNzX2Vjc19kYXNoYm9hcmQiLCJsaW1pdCI6MTAwMCwibG9nVGltZU1vZGUiOnRydWUsIm1hdGNoZXJzIjp7ImNoYWluIjpbeyJsYWJlbCI6InVzZXJJZCIsIm9wZXJhdG9yIjoiRVFVQUxTIiwidmFsdWUiOiIxNzM2NTExMTM0Mzg5MTEwIn1dfSwibWV0cmljIjoiQ1BVVXRpbGl6YXRpb24iLCJtZXRyaWNUeXBlIjoiTUVUUklDIiwibmFtZXNwYWNlIjoiYWNzX2Vjc19kYXNoYm9hcmQiLCJuZXh0UGtBZGFwdGVyIjp7fSwib2Zmc2V0IjowLCJwYXJlbnRVaWQiOjEyNzA2NzY2Nzk1NDY3MDQsInN0YXJ0VGltZSI6MTY0MTQ1NDE5NTgyMywic3RlcCI6LTEsInRpbWVvdXQiOjEyMCwid2luZG93Ijo2****</para>
        /// </summary>
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries to return each time.</para>
        /// <para>Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// <para>The measurements that are used to customize the returned data. By default, all measurements are returned.</para>
        /// <para>For example, the metric <c>cpu_idle</c> of the cloud service <c>acs_ecs_dashboard</c> has three measurement columns: <c>Average</c>, <c>Maximum</c>, and <c>Minimum</c>. If you only need to return the <c>Average</c> and <c>Maximum</c> columns, set this parameter to the array <c>[&quot;Average&quot;, &quot;Maximum&quot;]</c>.</para>
        /// <para>For information about how to obtain the measurements of a metric of a cloud service, see the <c>statistics</c> column of <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// </summary>
        [NameInMap("Measurements")]
        [Validation(Required=false)]
        public string MeasurementsShrink { get; set; }

        /// <summary>
        /// <para>The name of the metric of the cloud service.</para>
        /// <para>For information about how to obtain the name of a metric of a cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <remarks>
        /// <para>This parameter must be the same as the request parameter <c>Metric</c> in the Cursor operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_idle</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The data namespace of the cloud service.</para>
        /// <para>For information about how to obtain the data namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// <remarks>
        /// <para>This parameter must be the same as the request parameter <c>Namespace</c> in the Cursor operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}

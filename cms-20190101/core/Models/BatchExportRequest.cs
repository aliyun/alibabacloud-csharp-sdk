// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class BatchExportRequest : TeaModel {
        /// <summary>
        /// <para>The value of Cursor. This parameter is required when you repeatedly call this operation to export data. You can obtain the value of Cursor by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description><para>When you call this operation for the first time, you must call the Cursor operation to obtain the value of Cursor. For more information, see <a href="https://help.aliyun.com/document_detail/2330730.html">Cursor</a>.</para>
        /// </description></item>
        /// <item><description><para>When you call this operation again, you can obtain the value of Cursor from the response of the previous call.</para>
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
        /// <para>The maximum number of data records to return each time.</para>
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
        /// <para>The measurements used to customize the returned data. By default, all measurements are returned.</para>
        /// <para>For example, the cpu_idle monitoring metric of the acs_ecs_dashboard cloud service has three measurement columns: Average, Maximum, and Minimum. If you want to return only the Average and Maximum columns, you can apply the following Settings to this parameter: [&quot;Average&quot;, &quot;Maximum&quot;].</para>
        /// <para>For more information about how to obtain the measurements of a cloud service monitoring metric, see the statistics column in <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
        /// </summary>
        [NameInMap("Measurements")]
        [Validation(Required=false)]
        public List<string> Measurements { get; set; }

        /// <summary>
        /// <para>The name of the cloud service monitoring metric.</para>
        /// <para>For more information about how to obtain the name of a cloud service monitoring metric, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
        /// <remarks>
        /// <para>This parameter must be the same as the Metric request parameter in the Cursor operation.</para>
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
        /// <para>For more information about how to obtain the data namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
        /// <remarks>
        /// <para>This parameter must be the same as the Namespace request parameter in the Cursor operation.</para>
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

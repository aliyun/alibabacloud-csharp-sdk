// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The overview data in JSON format, which corresponds to the overview data on the console. The result is returned in one of the following three formats:</para>
        /// <list type="bullet">
        /// <item><description>Basic information.</description></item>
        /// <item><description>Node runtime information within a time interval.</description></item>
        /// <item><description>Node runtime timing information within a time interval. This format returns statistics information at each time point for three data items: node triggers, successful executions, and failed executions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Basic info: {&quot;schedulerx_job_counter_disable&quot;: &quot;4&quot;,&quot;schedulerx_job_trigger_counter_running&quot;: &quot;0&quot;,&quot;schedulerx_job_counter_enable&quot;: &quot;70&quot;,&quot;schedulerx_job_counter_all&quot;: &quot;74&quot;,&quot;schedulerx_worker_counter&quot;: &quot;2&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No access permission for the namespace [***]</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39090022-1F3B-4797-8518-6B61095F1AF0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

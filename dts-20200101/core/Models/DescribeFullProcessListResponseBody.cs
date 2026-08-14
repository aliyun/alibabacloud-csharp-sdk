// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeFullProcessListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>This parameter does not return a value. The following parameters describe the rate limiting configurations:</para>
        /// <list type="bullet">
        /// <item><description><b>dts.datamove.blaster.qps.max</b>: the rate of queries per second to the source database.</description></item>
        /// <item><description><b>dts.datamove.source.rps.max</b>: the number of rows per second for full data synchronization or migration (RPS).</description></item>
        /// <item><description><b>dts.datamove.source.bps.max</b>: the amount of data per second for full data synchronization or migration, in bytes per second.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When <b>JobCode</b> is set to <b>03</b>, you must set <b>EnableLimit</b> to <b>true</b> for the three parameters to take effect.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When <b>JobCode</b> is set to <b>04</b> or <b>07</b>, you only need to configure <b>dts.datamove.source.rps.max</b> and <b>dts.datamove.source.bps.max</b>.</description></item>
        /// <item><description>A value of <b>-1</b> indicates that rate limiting is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;dts.datamove.source.rps.max&quot;: 5000,
        ///       &quot;dts.datamove.source.bps.max&quot;: 10485760
        /// }</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public Dictionary<string, object> ConfigList { get; set; }

        /// <summary>
        /// <para>The ID of the migration, synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i03e3zty16i****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The dynamic error message used to replace the <b>%s</b> variable in the <b>ErrMessage</b> parameter.</para>
        /// <remarks>
        /// <para>For example, if <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The details of the Alibaba Cloud Global Accelerator (GA) instance list.</para>
        /// </summary>
        [NameInMap("FullProcessList")]
        [Validation(Required=false)]
        public List<DescribeFullProcessListResponseBodyFullProcessList> FullProcessList { get; set; }
        public class DescribeFullProcessListResponseBodyFullProcessList : TeaModel {
            /// <summary>
            /// <para>The details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The exception status of the task. Valid values: - <b>notstarted</b>: not started. - <b>checking</b>: being checked. - <b>failed</b>: failed. - <b>finished</b>: completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>notstarted</para>
            /// </summary>
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public string Exception { get; set; }

            /// <summary>
            /// <para>The process name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>universer</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The process type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: trusted</description></item>
            /// <item><description><b>2</b>: suspicious</description></item>
            /// <item><description><b>3</b>: malicious.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProcessType")]
            [Validation(Required=false)]
            public string ProcessType { get; set; }

            /// <summary>
            /// <para>The SQL statement that is being executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RunningSQL")]
            [Validation(Required=false)]
            public string RunningSQL { get; set; }

            /// <summary>
            /// <para>The status of the log information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TaskD4E5F6</para>
            /// </summary>
            [NameInMap("TaskID")]
            [Validation(Required=false)]
            public string TaskID { get; set; }

            /// <summary>
            /// <para>The time when the log was collected, in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729650129452</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C166D79D-436B-45F0-B5A5-25E1959F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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

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
        /// <para>The throttling configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dts.datamove.blaster.qps.max</b>: The rate at which queries are made to the source database per second.</description></item>
        /// <item><description><b>dts.datamove.source.rps.max</b>: the number of rows that are fully synchronized or migrated per second.</description></item>
        /// <item><description><b>dts.datamove.source.bps.max</b>: the amount of data processed per second for full synchronization or migration. Unit: Byte/s.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>When you set the <b>JobCode</b> parameter to <b>03</b>, you need to specify the <b>EnableLimit</b> parameter as <b>true</b>. Otherwise, the configuration cannot take effect.</para>
        /// </description></item>
        /// <item><description><para>When you set the <b>JobCode</b> parameter to <b>04</b> or <b>07</b>, you only need to specify the <b>dts.datamove.source.rps.max</b> and <b>dts.datamove.source.bps.max</b> parameters.</para>
        /// </description></item>
        /// <item><description><para>A value of \<em>\</em>-1\<em>\</em> indicates no rate limit.</para>
        /// </description></item>
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
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i03e3zty16i****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace the \<em>\</em>%s\<em>\</em> variable in the <b>ErrMessage</b> parameter.</para>
        /// <remarks>
        /// <para> The request parameter <b>DtsJobId</b> is invalid if <b>The Value of Input Parameter %s is not valid</b> is returned for <b>ErrMessage</b> and <b>DtsJobId</b> is returned for <b>DynamicMessage</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The details of the GA instances.</para>
        /// </summary>
        [NameInMap("FullProcessList")]
        [Validation(Required=false)]
        public List<DescribeFullProcessListResponseBodyFullProcessList> FullProcessList { get; set; }
        public class DescribeFullProcessListResponseBodyFullProcessList : TeaModel {
            /// <summary>
            /// <para>Details</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The abnormal status of the task. Valid values:<b>notstarted</b>. -<b>checking</b>. -<b>failed</b>. -<b>finished</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>notstarted</para>
            /// </summary>
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public string Exception { get; set; }

            /// <summary>
            /// <para>The name of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>universer</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The type of the process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: trusted</description></item>
            /// <item><description><b>2</b>: suspicious</description></item>
            /// <item><description><b>3</b>: malicious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProcessType")]
            [Validation(Required=false)]
            public string ProcessType { get; set; }

            /// <summary>
            /// <para>SQL that is running</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RunningSQL")]
            [Validation(Required=false)]
            public string RunningSQL { get; set; }

            /// <summary>
            /// <para>The log status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TaskD4E5F6</para>
            /// </summary>
            [NameInMap("TaskID")]
            [Validation(Required=false)]
            public string TaskID { get; set; }

            /// <summary>
            /// <para>The time when the logs were collected. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetLifecycleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InternalError: All errors, except for parameter validation errors, are internal errors.</description></item>
        /// <item><description>ValidationError: A parameter validation error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The lifecycle details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[[{&quot;Status&quot;:&quot;Creating&quot;,&quot;GmtCreateTime&quot;:&quot;2022-09-19T22:38:00Z&quot;,&quot;Reason&quot;:&quot;&quot;,&quot;ReasonCode&quot;:&quot;&quot;}]]</para>
        /// </summary>
        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public List<List<GetLifecycleResponseBodyLifecycle>> Lifecycle { get; set; }
        public class GetLifecycleResponseBodyLifecycle : TeaModel {
            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating</description></item>
            /// <item><description>SaveFailed: The instance image failed to be saved.</description></item>
            /// <item><description>Stopped</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>ResourceAllocating</description></item>
            /// <item><description>Stopping</description></item>
            /// <item><description>Updating</description></item>
            /// <item><description>Saving</description></item>
            /// <item><description>Starting</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Saved</description></item>
            /// <item><description>EnvPreparing: Preparing environment.</description></item>
            /// <item><description>ArrearStopping: The service is being stopped due to overdue payments.</description></item>
            /// <item><description>Arrearge: The service is stopped due to overdue payments.</description></item>
            /// <item><description>Queuing</description></item>
            /// <item><description>Recovering</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Starting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason code that corresponds to an event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The reason message that corresponds to an event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <para>The time the status was created, specifically the time the instance transitioned to this status (in GMT).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-21T07:27:44Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtEndTime")]
            [Validation(Required=false)]
            public string GmtEndTime { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;XXX&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of queried sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

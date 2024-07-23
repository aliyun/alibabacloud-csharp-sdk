// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class RunCloudBenchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information, including the error codes and the number of returned entries.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunCloudBenchTaskResponseBodyData Data { get; set; }
        public class RunCloudBenchTaskResponseBodyData : TeaModel {
            [NameInMap("PreCheckItem")]
            [Validation(Required=false)]
            public List<RunCloudBenchTaskResponseBodyDataPreCheckItem> PreCheckItem { get; set; }
            public class RunCloudBenchTaskResponseBodyDataPreCheckItem : TeaModel {
                /// <summary>
                /// <para>The HTTP status code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The detailed information of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Data&quot;: { &quot;total&quot;: 1, &quot;list&quot;:[...] }, &quot;Code&quot;: 200, &quot;Success&quot;: true }</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public string Details { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// <remarks>
                /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Successful</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the check item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SqlArchiveStatusChecker</b>: checks whether SQL Explorer is available.</description></item>
                /// <item><description><b>BenchClientEnvChecker</b>: checks whether the runtime environment for programs on the stress testing client is available.</description></item>
                /// <item><description><b>SpecChecker</b>: checks whether the destination instance type and the instance type of the stress testing client support this API operation.</description></item>
                /// <item><description><b>SourceInstanceChecker</b>: checks whether the account of the source instance is available and whether the source instance is connected to the destination instance.</description></item>
                /// <item><description><b>BenchTargetChecker</b>: checks whether the account of the destination instance is available and whether the source instance is connected to the destination instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BenchTargetChecker</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The sequence number of the check item. Valid values: <b>0</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The status of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
                /// <item><description><b>IGNORED</b>: The task is ignored.</description></item>
                /// <item><description><b>RUNNING</b>: The task is running.</description></item>
                /// <item><description><b>EXCEPTION</b>: An error occurred.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
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
        public string Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInvocationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the command.</para>
        /// </summary>
        [NameInMap("InvocationResults")]
        [Validation(Required=false)]
        public ListInvocationResultsResponseBodyInvocationResults InvocationResults { get; set; }
        public class ListInvocationResultsResponseBodyInvocationResults : TeaModel {
            [NameInMap("InvocationResult")]
            [Validation(Required=false)]
            public List<ListInvocationResultsResponseBodyInvocationResultsInvocationResult> InvocationResult { get; set; }
            public class ListInvocationResultsResponseBodyInvocationResultsInvocationResult : TeaModel {
                /// <summary>
                /// <para>The ID of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-hz01v8x80o3****</para>
                /// </summary>
                [NameInMap("CommandId")]
                [Validation(Required=false)]
                public string CommandId { get; set; }

                /// <summary>
                /// <para>The exit code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExitCode")]
                [Validation(Required=false)]
                public int? ExitCode { get; set; }

                /// <summary>
                /// <para>The time at which the command entered the Finished state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-06T09:14:56Z</para>
                /// </summary>
                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                /// <summary>
                /// <para>The ID of the node on which the command was run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-uf65bh2113hlqvyr****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The status of the command. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Finished</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Failed</description></item>
                /// <item><description>Stopped</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("InvokeRecordStatus")]
                [Validation(Required=false)]
                public string InvokeRecordStatus { get; set; }

                /// <summary>
                /// <para>The output result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello world</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Indicates whether the command was run and its result was obtained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

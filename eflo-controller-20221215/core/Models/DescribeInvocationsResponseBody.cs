// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeInvocationsResponseBody : TeaModel {
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeInvocationsResponseBodyInvocations Invocations { get; set; }
        public class DescribeInvocationsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeInvocationsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeInvocationsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cnBtIC1xYSB8IGdyZXAgdnNm****</para>
                /// </summary>
                [NameInMap("CommandContent")]
                [Validation(Required=false)]
                public string CommandContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CommandTestName</para>
                /// </summary>
                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-19T09:15:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t-ind3k9ytvvduoe8</para>
                /// </summary>
                [NameInMap("InvokeId")]
                [Validation(Required=false)]
                public string InvokeId { get; set; }

                [NameInMap("InvokeNodes")]
                [Validation(Required=false)]
                public DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodes InvokeNodes { get; set; }
                public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodes : TeaModel {
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeInvocationsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Dropped")]
                        [Validation(Required=false)]
                        public int? Dropped { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>NodeNotExists：</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public bool? ErrorCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>the specified node does not exists</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ExitCode")]
                        [Validation(Required=false)]
                        public int? ExitCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Pending</para>
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>e01-cn-lbj36wkp70b</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Finished</para>
                        /// </summary>
                        [NameInMap("NodeInvokeStatus")]
                        [Validation(Required=false)]
                        public string NodeInvokeStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>OutPutTestmsg</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Repeats")]
                        [Validation(Required=false)]
                        public int? Repeats { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2019-12-20T06:15:55Z</para>
                        /// </summary>
                        [NameInMap("StopTime")]
                        [Validation(Required=false)]
                        public string StopTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Timed")]
                        [Validation(Required=false)]
                        public string Timed { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("InvokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Once</para>
                /// </summary>
                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public string RepeatMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/home</para>
                /// </summary>
                [NameInMap("WorkingDir")]
                [Validation(Required=false)]
                public string WorkingDir { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

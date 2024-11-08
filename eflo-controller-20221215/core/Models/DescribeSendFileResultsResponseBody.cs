// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeSendFileResultsResponseBody : TeaModel {
        [NameInMap("Invocations")]
        [Validation(Required=false)]
        public DescribeSendFileResultsResponseBodyInvocations Invocations { get; set; }
        public class DescribeSendFileResultsResponseBodyInvocations : TeaModel {
            [NameInMap("Invocation")]
            [Validation(Required=false)]
            public List<DescribeSendFileResultsResponseBodyInvocationsInvocation> Invocation { get; set; }
            public class DescribeSendFileResultsResponseBodyInvocationsInvocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Base64</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PlainText</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-10T10:53:46.156+08:00</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("FileGroup")]
                [Validation(Required=false)]
                public string FileGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0644</para>
                /// </summary>
                [NameInMap("FileMode")]
                [Validation(Required=false)]
                public string FileMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("FileOwner")]
                [Validation(Required=false)]
                public string FileOwner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("InvocationStatus")]
                [Validation(Required=false)]
                public string InvocationStatus { get; set; }

                [NameInMap("InvokeNodes")]
                [Validation(Required=false)]
                public DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodes InvokeNodes { get; set; }
                public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodes : TeaModel {
                    [NameInMap("InvokeNode")]
                    [Validation(Required=false)]
                    public List<DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode> InvokeNode { get; set; }
                    public class DescribeSendFileResultsResponseBodyInvocationsInvocationInvokeNodesInvokeNode : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-02-06T07:12:50Z</para>
                        /// </summary>
                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>AccountNotExists</para>
                        /// </summary>
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>the specified instance does not exists</para>
                        /// </summary>
                        [NameInMap("ErrorInfo")]
                        [Validation(Required=false)]
                        public string ErrorInfo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-04-10T10:53:46.156+08:00</para>
                        /// </summary>
                        [NameInMap("FinishTime")]
                        [Validation(Required=false)]
                        public string FinishTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Success</para>
                        /// </summary>
                        [NameInMap("InvocationStatus")]
                        [Validation(Required=false)]
                        public string InvocationStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>e01-cn-9lb3c15m81j</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-03-30T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-03-30T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Overwrite")]
                [Validation(Required=false)]
                public bool? Overwrite { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/home/user</para>
                /// </summary>
                [NameInMap("TargetDir")]
                [Validation(Required=false)]
                public string TargetDir { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

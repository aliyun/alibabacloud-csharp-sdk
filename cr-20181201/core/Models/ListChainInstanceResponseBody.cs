// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChainInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of delivery chain execution records.</para>
        /// </summary>
        [NameInMap("ChainInstances")]
        [Validation(Required=false)]
        public List<ListChainInstanceResponseBodyChainInstances> ChainInstances { get; set; }
        public class ListChainInstanceResponseBodyChainInstances : TeaModel {
            /// <summary>
            /// <para>The delivery chain execution record.</para>
            /// </summary>
            [NameInMap("Chain")]
            [Validation(Required=false)]
            public ListChainInstanceResponseBodyChainInstancesChain Chain { get; set; }
            public class ListChainInstanceResponseBodyChainInstancesChain : TeaModel {
                /// <summary>
                /// <para>The delivery chain ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chi-m42gbku0****</para>
                /// </summary>
                [NameInMap("ChainId")]
                [Validation(Required=false)]
                public string ChainId { get; set; }

                /// <summary>
                /// <para>The delivery chain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-chain</para>
                /// </summary>
                [NameInMap("ChainName")]
                [Validation(Required=false)]
                public string ChainName { get; set; }

                /// <summary>
                /// <para>The delivery chain version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <para>The delivery chain instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F4CF4DDB-BEF2-5575-<b><b>-</b></b>***</para>
            /// </summary>
            [NameInMap("ChainInstanceId")]
            [Validation(Required=false)]
            public string ChainInstanceId { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636685856000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-repo</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-ns</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

            /// <summary>
            /// <para>The execution result of the delivery chain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>SUCCESS</c>: Succeeded.</description></item>
            /// <item><description><c>FAILED</c>: Failed.</description></item>
            /// <item><description><c>CANCELED</c>: Canceled.</description></item>
            /// <item><description><c>DENIED</c>: Denied.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636685776000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The execution status of the delivery chain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>RUNNING</c>: Running.</description></item>
            /// <item><description><c>COMPLETE</c>: Complete.</description></item>
            /// <item><description><c>CANCELING</c>: Canceling.</description></item>
            /// <item><description><c>CANCELED</c>: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>838D1602-6D8F-47FB-B60A-656645D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

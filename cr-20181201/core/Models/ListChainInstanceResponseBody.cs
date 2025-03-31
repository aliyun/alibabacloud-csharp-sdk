// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChainInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// </summary>
        [NameInMap("ChainInstances")]
        [Validation(Required=false)]
        public List<ListChainInstanceResponseBodyChainInstances> ChainInstances { get; set; }
        public class ListChainInstanceResponseBodyChainInstances : TeaModel {
            /// <summary>
            /// <para>The name of the namespace.</para>
            /// </summary>
            [NameInMap("Chain")]
            [Validation(Required=false)]
            public ListChainInstanceResponseBodyChainInstancesChain Chain { get; set; }
            public class ListChainInstanceResponseBodyChainInstancesChain : TeaModel {
                /// <summary>
                /// <para>The name of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chi-m42gbku0****</para>
                /// </summary>
                [NameInMap("ChainId")]
                [Validation(Required=false)]
                public string ChainId { get; set; }

                /// <summary>
                /// <para>The number of entries returned on each page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-chain</para>
                /// </summary>
                [NameInMap("ChainName")]
                [Validation(Required=false)]
                public string ChainName { get; set; }

                /// <summary>
                /// <para>The ID of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// <para>1</para>
            /// 
            /// <b>Example:</b>
            /// <para>F4CF4DDB-BEF2-5575-<b><b>-</b></b>***</para>
            /// </summary>
            [NameInMap("ChainInstanceId")]
            [Validation(Required=false)]
            public string ChainInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636685856000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the delivery chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-repo</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The execution result of the delivery chain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>SUCCESS</c></description></item>
            /// <item><description><c>FAILED</c></description></item>
            /// <item><description><c>CANCELED</c></description></item>
            /// <item><description><c>DENIED</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test-ns</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

            /// <summary>
            /// <para>The list of the execution records of delivery chains.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>test-repo</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636685776000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the delivery chain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>RUNNING</c></description></item>
            /// <item><description><c>COMPLETE</c></description></item>
            /// <item><description><c>CANCELING</c></description></item>
            /// <item><description><c>CANCELED</c></description></item>
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
        /// <para>The version of the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The execution record of the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>30</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>838D1602-6D8F-47FB-B60A-656645D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

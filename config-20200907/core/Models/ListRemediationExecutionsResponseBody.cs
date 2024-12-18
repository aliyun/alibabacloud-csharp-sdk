// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRemediationExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried remediation records.</para>
        /// </summary>
        [NameInMap("RemediationExecutionData")]
        [Validation(Required=false)]
        public ListRemediationExecutionsResponseBodyRemediationExecutionData RemediationExecutionData { get; set; }
        public class ListRemediationExecutionsResponseBodyRemediationExecutionData : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries to return for a single request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cMbjqNaYs0Ps7zSNiu37****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The queried remediation records.</para>
            /// </summary>
            [NameInMap("RemediationExecutions")]
            [Validation(Required=false)]
            public List<ListRemediationExecutionsResponseBodyRemediationExecutionDataRemediationExecutions> RemediationExecutions { get; set; }
            public class ListRemediationExecutionsResponseBodyRemediationExecutionDataRemediationExecutions : TeaModel {
                /// <summary>
                /// <para>The time when the remediation record was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-25T11:48:15Z</para>
                /// </summary>
                [NameInMap("ExecutionCreateDate")]
                [Validation(Required=false)]
                public string ExecutionCreateDate { get; set; }

                /// <summary>
                /// <para>The invocation ID of the remediation record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exec-befded3781994ccf****</para>
                /// </summary>
                [NameInMap("ExecutionInvocationId")]
                [Validation(Required=false)]
                public string ExecutionInvocationId { get; set; }

                /// <summary>
                /// <para>The IDs of the resources to which the remediation belongs. Separate multiple resource IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-0jlk629z240l8****</para>
                /// </summary>
                [NameInMap("ExecutionResourceIds")]
                [Validation(Required=false)]
                public string ExecutionResourceIds { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::RDS::DBInstance</para>
                /// </summary>
                [NameInMap("ExecutionResourceType")]
                [Validation(Required=false)]
                public string ExecutionResourceType { get; set; }

                /// <summary>
                /// <para>The status of the remediation record. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Success</description></item>
                /// <item><description>Failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ExecutionStatus")]
                [Validation(Required=false)]
                public string ExecutionStatus { get; set; }

                /// <summary>
                /// <para>The error message returned when the remediation fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Invocation time out.</para>
                /// </summary>
                [NameInMap("ExecutionStatusMessage")]
                [Validation(Required=false)]
                public string ExecutionStatusMessage { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13E67493-3165-529A-A961-BE9E4B11BA11</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

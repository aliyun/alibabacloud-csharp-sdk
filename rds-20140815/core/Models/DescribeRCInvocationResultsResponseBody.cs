// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInvocationResultsResponseBody : TeaModel {
        [NameInMap("InvocationResults")]
        [Validation(Required=false)]
        public List<DescribeRCInvocationResultsResponseBodyInvocationResults> InvocationResults { get; set; }
        public class DescribeRCInvocationResultsResponseBodyInvocationResults : TeaModel {
            [NameInMap("CommandId")]
            [Validation(Required=false)]
            public string CommandId { get; set; }

            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            [NameInMap("Dropped")]
            [Validation(Required=false)]
            public int? Dropped { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public int? ExitCode { get; set; }

            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InvocationStatus")]
            [Validation(Required=false)]
            public string InvocationStatus { get; set; }

            [NameInMap("InvokeId")]
            [Validation(Required=false)]
            public string InvokeId { get; set; }

            [NameInMap("InvokeRecordStatus")]
            [Validation(Required=false)]
            public string InvokeRecordStatus { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            [NameInMap("Repeats")]
            [Validation(Required=false)]
            public string Repeats { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeRCInvocationResultsResponseBodyInvocationResultsTags> Tags { get; set; }
            public class DescribeRCInvocationResultsResponseBodyInvocationResultsTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

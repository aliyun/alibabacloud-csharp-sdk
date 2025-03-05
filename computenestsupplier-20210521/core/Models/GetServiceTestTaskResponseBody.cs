// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceTestTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution details.</para>
        /// </summary>
        [NameInMap("ExecutionDetails")]
        [Validation(Required=false)]
        public List<GetServiceTestTaskResponseBodyExecutionDetails> ExecutionDetails { get; set; }
        public class GetServiceTestTaskResponseBodyExecutionDetails : TeaModel {
            /// <summary>
            /// <para>The service test case name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>case1</para>
            /// </summary>
            [NameInMap("CaseName")]
            [Validation(Required=false)]
            public string CaseName { get; set; }

            /// <summary>
            /// <para>The execution report</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// <para>Region: cn-qingdao
            /// StackName: iact3-default-cn-qingd
            /// StackId: 009d2991-f494-d</para>
            /// <hr>
            /// </summary>
            [NameInMap("ExecutionReport")]
            [Validation(Required=false)]
            public string ExecutionReport { get; set; }

            /// <summary>
            /// <para>The sub task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub task id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stt-xxxx</para>
            /// </summary>
            [NameInMap("SubTaskId")]
            [Validation(Required=false)]
            public string SubTaskId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A361BA9E-xxxx-xxxx-xxxx-C26E5180456E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the service test task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Success</description></item>
        /// <item><description>Failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The task execution region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("TaskRegionId")]
        [Validation(Required=false)]
        public string TaskRegionId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupOperationsResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stack group operations.</para>
        /// </summary>
        [NameInMap("StackGroupOperations")]
        [Validation(Required=false)]
        public List<ListStackGroupOperationsResponseBodyStackGroupOperations> StackGroupOperations { get; set; }
        public class ListStackGroupOperationsResponseBodyStackGroupOperations : TeaModel {
            /// <summary>
            /// <para>The operation type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATE</description></item>
            /// <item><description>UPDATE</description></item>
            /// <item><description>DELETE</description></item>
            /// <item><description>DETECT_DRIFT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The time when the operation was initiated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-20T09:22:36.000000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the operation ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-20T09:22:41.000000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The description of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create stack instance in hangzhou</para>
            /// </summary>
            [NameInMap("OperationDescription")]
            [Validation(Required=false)]
            public string OperationDescription { get; set; }

            /// <summary>
            /// <para>The operation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14A07460-EBE7-47CA-9757-12CC4761****</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The ID of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd0ddef9-9540-4b42-a464-94f77835****</para>
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// <para>The name of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStackGroup</para>
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// <para>The state of the operation.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING</description></item>
            /// <item><description>SUCCEEDED</description></item>
            /// <item><description>FAILED</description></item>
            /// <item><description>STOPPING</description></item>
            /// <item><description>STOPPED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of stack group operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

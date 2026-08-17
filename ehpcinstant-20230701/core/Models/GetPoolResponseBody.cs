// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the resource pool.</para>
        /// </summary>
        [NameInMap("PoolInfo")]
        [Validation(Required=false)]
        public GetPoolResponseBodyPoolInfo PoolInfo { get; set; }
        public class GetPoolResponseBodyPoolInfo : TeaModel {
            /// <summary>
            /// <para>The time when the resource pool was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-01 20:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The number of executors that are in use in the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ExecutorUsage")]
            [Validation(Required=false)]
            public int? ExecutorUsage { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource pool is the default resource pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent executors per user in the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxExecutorNum")]
            [Validation(Required=false)]
            public int? MaxExecutorNum { get; set; }

            /// <summary>
            /// <para>The name of the resource pool.</para>
            /// <list type="bullet">
            /// <item><description><para>The name can be up to 15 characters long.</para>
            /// </description></item>
            /// <item><description><para>The name can contain letters, digits, underscores (_), and periods (.).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PoolTest</para>
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public string PoolName { get; set; }

            /// <summary>
            /// <para>The priority of the resource pool.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values: 1 to 99. A larger value indicates a higher priority. Default value: 1.</para>
            /// </description></item>
            /// <item><description><para>Jobs in a resource pool with a higher priority are scheduled before pending jobs in a resource pool with a lower priority. The priority of the resource pool takes precedence over the priority of a job.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The reason for the error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fails to *** pool: ***.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy-xxx</para>
            /// </summary>
            [NameInMap("SchedulingPolicyId")]
            [Validation(Required=false)]
            public string SchedulingPolicyId { get; set; }

            /// <summary>
            /// <para>The status of the resource pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Creating</c>: The resource pool is being created.</para>
            /// </description></item>
            /// <item><description><para><c>Updating</c>: The resource pool is being updated.</para>
            /// </description></item>
            /// <item><description><para><c>Deleting</c>: The resource pool is being deleted.</para>
            /// </description></item>
            /// <item><description><para><c>Working</c>: The resource pool is active.</para>
            /// </description></item>
            /// <item><description><para><c>Deleted</c>: The resource pool has been deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the resource pool was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-01 20:00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

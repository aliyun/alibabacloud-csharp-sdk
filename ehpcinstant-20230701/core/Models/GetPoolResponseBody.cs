// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource pool information.</para>
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
            /// <para>The ID of the resource pool creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200428053788xxxx</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The number of executor nodes that are currently running in the resource pool.</para>
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
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The maximum number of executor nodes that can run concurrently in the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxExecutorNum")]
            [Validation(Required=false)]
            public int? MaxExecutorNum { get; set; }

            /// <summary>
            /// <para>The resource pool name.</para>
            /// <list type="bullet">
            /// <item><description>The name can be up to 15 characters in length.</description></item>
            /// <item><description>The name can contain digits, uppercase letters, lowercase letters, underscores (_), and periods (.).</description></item>
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
            /// <item><description>Valid values: 1 to 99. Default value: 1, which indicates the lowest priority.</description></item>
            /// <item><description>Jobs submitted to a resource pool with a higher priority value are scheduled before pending jobs in a resource pool with a lower priority value. The resource pool priority takes precedence over the job priority.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The error reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fails to *** pool: ***.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The scheduling policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy-xxx</para>
            /// </summary>
            [NameInMap("SchedulingPolicyId")]
            [Validation(Required=false)]
            public string SchedulingPolicyId { get; set; }

            /// <summary>
            /// <para>The resource pool status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The resource pool is being created.</description></item>
            /// <item><description>Updating: The resource pool is being updated.</description></item>
            /// <item><description>Deleting: The resource pool is being deleted.</description></item>
            /// <item><description>Working: The resource pool is running.</description></item>
            /// <item><description>Deleted: The resource pool has been deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetPoolResponseBodyPoolInfoTags> Tags { get; set; }
            public class GetPoolResponseBodyPoolInfoTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

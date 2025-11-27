// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the resource pool.</para>
        /// </summary>
        [NameInMap("PoolInfo")]
        [Validation(Required=false)]
        public GetPoolResponseBodyPoolInfo PoolInfo { get; set; }
        public class GetPoolResponseBodyPoolInfo : TeaModel {
            /// <summary>
            /// <para>The time when the resource pool is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-01 20:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The usage of execution nodes that are running in a resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExectorUsage")]
            [Validation(Required=false)]
            public int? ExectorUsage { get; set; }

            /// <summary>
            /// <para>Indices whether the resource pool is the default resource pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The maximum number of execution nodes that can run concurrently in a resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("MaxExectorNum")]
            [Validation(Required=false)]
            public int? MaxExectorNum { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// <list type="bullet">
            /// <item><description>The value can be up to 15 characters in length.</description></item>
            /// <item><description>It can contain digits, uppercase letters, lowercase letters, underscores (_), and dots (.).</description></item>
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
            /// <item><description>You can set a priority in the range of 1 to 99. The default value is 1, which is the lowest priority.</description></item>
            /// <item><description>Jobs submitted to a resource pool with a higher priority level value will be scheduled before pending jobs in a resource pool with a lower priority level value, and the priority level of the resource pool takes precedence over the priority of the job.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The cause of the error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fails to *** pool: ***.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the resource pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The resource pool is being created.</description></item>
            /// <item><description>Updating: The resource pool is being updated.</description></item>
            /// <item><description>Deleting: The resource pool is being deleted.</description></item>
            /// <item><description>Working: The resource pool is working.</description></item>
            /// <item><description>Deleted: The resource pool is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the resource pool was updated.</para>
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

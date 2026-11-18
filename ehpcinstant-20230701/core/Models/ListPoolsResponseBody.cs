// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Maximum value: 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of resource pools.</para>
        /// </summary>
        [NameInMap("PoolList")]
        [Validation(Required=false)]
        public List<ListPoolsResponseBodyPoolList> PoolList { get; set; }
        public class ListPoolsResponseBodyPoolList : TeaModel {
            /// <summary>
            /// <para>The time when the resource pool was created. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20 11:09:59</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the resource pool is the default resource pool. Valid values:</para>
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
            /// <para>The number of running executor nodes in a resource pool.</para>
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
            /// <item><description>Jobs submitted to a resource pool with a higher priority level are scheduled before pending jobs in a resource pool with a lower priority level. The priority level of a resource pool takes precedence over the priority of a job.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

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
            /// <para>The resource pool status. Valid values:</para>
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
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPoolsResponseBodyPoolListTags> Tags { get; set; }
            public class ListPoolsResponseBodyPoolListTags : TeaModel {
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
            /// <para>The time when the resource pool was updated. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20 11:09:59</para>
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

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>An array of resource pools.</para>
        /// </summary>
        [NameInMap("PoolList")]
        [Validation(Required=false)]
        public List<ListPoolsResponseBodyPoolList> PoolList { get; set; }
        public class ListPoolsResponseBodyPoolList : TeaModel {
            /// <summary>
            /// <para>The time when the resource pool was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20 11:09:59</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource pool is the default pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The resource pool is the default pool.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The resource pool is not the default pool.</para>
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
            /// <para>The number of running executor nodes in the resource pool.</para>
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
            /// <item><description><para>Maximum length: 15 characters.</para>
            /// </description></item>
            /// <item><description><para>Allowed characters: digits, letters, underscores (_), and periods (.).</para>
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
            /// <item><description><para>Valid values: 1 to 99. Default value: 1 (lowest priority).</para>
            /// </description></item>
            /// <item><description><para>Jobs in a resource pool with a higher priority are scheduled before those in a pool with a lower priority. The pool\&quot;s priority overrides the priority of an individual job.</para>
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
            /// <item><description><para>Creating: The resource pool is being created.</para>
            /// </description></item>
            /// <item><description><para>Updating: The resource pool is being updated.</para>
            /// </description></item>
            /// <item><description><para>Deleting: The resource pool is being deleted.</para>
            /// </description></item>
            /// <item><description><para>Working: The resource pool is operational.</para>
            /// </description></item>
            /// <item><description><para>Deleted: The resource pool has been deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPoolsResponseBodyPoolListTags> Tags { get; set; }
            public class ListPoolsResponseBodyPoolListTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
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
            /// <para>2026-04-20 11:09:59</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
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

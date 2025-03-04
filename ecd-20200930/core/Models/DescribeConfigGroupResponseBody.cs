// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeConfigGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeConfigGroupResponseBodyData> Data { get; set; }
        public class DescribeConfigGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of resources that are bound to the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public int? BindCount { get; set; }

            /// <summary>
            /// <para>The number of bound cloud computers.</para>
            /// </summary>
            [NameInMap("BindCountMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> BindCountMap { get; set; }

            /// <summary>
            /// <para>The description of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScheduledTask</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccg-0cid8v30an12****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScheduledTask</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The service type of the configuration group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CLOUD_DESKTOP: the cloud computer service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The state of the configuration group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AVAILABLE: The configuration group is available.</description></item>
            /// <item><description>UNAVAILABLE: The configuration group is deleted.</description></item>
            /// <item><description>DELETING: The configuration group is being deleted.</description></item>
            /// <item><description>UPDATING: The configuration group is being modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the configuration group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Timer: the scheduled task type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Timer</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

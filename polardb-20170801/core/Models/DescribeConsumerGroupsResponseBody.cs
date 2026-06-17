// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeConsumerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of consumer groups.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeConsumerGroupsResponseBodyItems> Items { get; set; }
        public class DescribeConsumerGroupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of supported models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[]&quot;</para>
            /// </summary>
            [NameInMap("AllowedModels")]
            [Validation(Required=false)]
            public string AllowedModels { get; set; }

            /// <summary>
            /// <para>The ID of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-xxxxxxxx</para>
            /// </summary>
            [NameInMap("ConsumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The name of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ConsumerGroupName")]
            [Validation(Required=false)]
            public string ConsumerGroupName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-28T09:56:03+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-04T16:09:29+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the consumer group is the default group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: No</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Yes</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The nickname of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

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
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of records returned per page. Valid values: 30, 50, and 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

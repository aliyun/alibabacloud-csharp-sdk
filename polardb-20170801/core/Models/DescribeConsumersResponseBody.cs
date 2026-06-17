// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeConsumersResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of consumers.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeConsumersResponseBodyItems> Items { get; set; }
        public class DescribeConsumersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The models that the consumer is allowed to access, specified as a JSON array in string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[]&quot;</para>
            /// </summary>
            [NameInMap("AllowedModels")]
            [Validation(Required=false)]
            public string AllowedModels { get; set; }

            /// <summary>
            /// <para>The full API key. This value is returned only by this operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The consumer group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-xxxxxx</para>
            /// </summary>
            [NameInMap("ConsumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The consumer group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ConsumerGroupName")]
            [Validation(Required=false)]
            public string ConsumerGroupName { get; set; }

            /// <summary>
            /// <para>The consumer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-mqveroemc***</para>
            /// </summary>
            [NameInMap("ConsumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The time when the consumer was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-28T09:56:03+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the consumer was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-04T16:09:29+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The total usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("LifetimeCostCount")]
            [Validation(Required=false)]
            public long? LifetimeCostCount { get; set; }

            /// <summary>
            /// <para>The total number of tokens consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("LifetimeTokenCount")]
            [Validation(Required=false)]
            public long? LifetimeTokenCount { get; set; }

            /// <summary>
            /// <para>The month-to-date usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MtdCostCount")]
            [Validation(Required=false)]
            public long? MtdCostCount { get; set; }

            /// <summary>
            /// <para>The number of tokens consumed month-to-date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MtdTokenCount")]
            [Validation(Required=false)]
            public long? MtdTokenCount { get; set; }

            /// <summary>
            /// <para>The consumer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The consumer nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yonghu</para>
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
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: 30, 50, and 100. The default value is 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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

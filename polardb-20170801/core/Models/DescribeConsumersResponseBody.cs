// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeConsumersResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeConsumersResponseBodyItems> Items { get; set; }
        public class DescribeConsumersResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;[]&quot;</para>
            /// </summary>
            [NameInMap("AllowedModels")]
            [Validation(Required=false)]
            public string AllowedModels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxxxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cg-xxxxxx</para>
            /// </summary>
            [NameInMap("ConsumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ConsumerGroupName")]
            [Validation(Required=false)]
            public string ConsumerGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c-mqveroemc***</para>
            /// </summary>
            [NameInMap("ConsumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-28T09:56:03+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-04T16:09:29+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("LifetimeCostCount")]
            [Validation(Required=false)]
            public long? LifetimeCostCount { get; set; }

            [NameInMap("LifetimeTokenCount")]
            [Validation(Required=false)]
            public long? LifetimeTokenCount { get; set; }

            [NameInMap("MtdCostCount")]
            [Validation(Required=false)]
            public long? MtdCostCount { get; set; }

            [NameInMap("MtdTokenCount")]
            [Validation(Required=false)]
            public long? MtdTokenCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yonghu</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}

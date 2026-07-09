// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostCenterResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of financial unit data.</para>
        /// </summary>
        [NameInMap("CostCenterDtoList")]
        [Validation(Required=false)]
        public List<QueryCostCenterResponseBodyCostCenterDtoList> CostCenterDtoList { get; set; }
        public class QueryCostCenterResponseBodyCostCenterDtoList : TeaModel {
            /// <summary>
            /// <para>The code of the financial unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15945703968#</para>
            /// </summary>
            [NameInMap("CostCenterCode")]
            [Validation(Required=false)]
            public string CostCenterCode { get; set; }

            /// <summary>
            /// <para>The ID of the financial unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>485938</para>
            /// </summary>
            [NameInMap("CostCenterId")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The name of the financial unit. The name must be unique within the same account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>资源组</para>
            /// </summary>
            [NameInMap("CostCenterName")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>The level of the financial unit node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>loose</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            /// <summary>
            /// <para>The ID of the user who owns the financial unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1314839403940987</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

            /// <summary>
            /// <para>The ID of the parent financial unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentCostCenterId")]
            [Validation(Required=false)]
            public long? ParentCostCenterId { get; set; }

            /// <summary>
            /// <para>The ID of the previous financial unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>485996</para>
            /// </summary>
            [NameInMap("PrevCostCenterId")]
            [Validation(Required=false)]
            public long? PrevCostCenterId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The metadata of the response struct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

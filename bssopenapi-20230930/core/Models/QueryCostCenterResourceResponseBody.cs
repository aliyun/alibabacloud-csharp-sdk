// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostCenterResourceResponseBody : TeaModel {
        [NameInMap("CostCenterResourceDtoList")]
        [Validation(Required=false)]
        public List<QueryCostCenterResourceResponseBodyCostCenterResourceDtoList> CostCenterResourceDtoList { get; set; }
        public class QueryCostCenterResourceResponseBodyCostCenterResourceDtoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApportionItemCode")]
            [Validation(Required=false)]
            public string ApportionItemCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ApportionItemName")]
            [Validation(Required=false)]
            public string ApportionItemName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>otsbag</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("CostCenterCode")]
            [Validation(Required=false)]
            public string CostCenterCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-18 12:12:25</para>
            /// </summary>
            [NameInMap("CostCenterCreateTime")]
            [Validation(Required=false)]
            public string CostCenterCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CostCenterId")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CostCenterName")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-18 16:12:25</para>
            /// </summary>
            [NameInMap("CostCenterUpdateTime")]
            [Validation(Required=false)]
            public string CostCenterUpdateTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567812345678</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

            [NameInMap("OwnerAccountName")]
            [Validation(Required=false)]
            public string OwnerAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ParentCostCenterId")]
            [Validation(Required=false)]
            public long? ParentCostCenterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("PipCode")]
            [Validation(Required=false)]
            public string PipCode { get; set; }

            [NameInMap("PipName")]
            [Validation(Required=false)]
            public string PipName { get; set; }

            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSSBAG-cn-v0h1s4hma018</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testResource</para>
            /// </summary>
            [NameInMap("ResourceNick")]
            [Validation(Required=false)]
            public string ResourceNick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MANUAL_ALLOCATE</para>
            /// </summary>
            [NameInMap("ResourceSource")]
            [Validation(Required=false)]
            public string ResourceSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("ResourceTag")]
            [Validation(Required=false)]
            public string ResourceTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FPT_ossbag_absolute_Storage_bj</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-18 16:12:25</para>
            /// </summary>
            [NameInMap("ResourceUpdateTime")]
            [Validation(Required=false)]
            public string ResourceUpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567812345678</para>
            /// </summary>
            [NameInMap("ResourceUserId")]
            [Validation(Required=false)]
            public long? ResourceUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyun.com">test@test.aliyun.com</a></para>
            /// </summary>
            [NameInMap("ResourceUserName")]
            [Validation(Required=false)]
            public string ResourceUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("RootCostCenterId")]
            [Validation(Required=false)]
            public long? RootCostCenterId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6MTB9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

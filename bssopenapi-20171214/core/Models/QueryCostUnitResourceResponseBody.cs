// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCostUnitResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCostUnitResourceResponseBodyData Data { get; set; }
        public class QueryCostUnitResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The financial unit information.</para>
            /// </summary>
            [NameInMap("CostUnit")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnit CostUnit { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnit : TeaModel {
                /// <summary>
                /// <para>The user ID of the financial unit owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>321432</para>
                /// </summary>
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public long? OwnerUid { get; set; }

                /// <summary>
                /// <para>The ID of the parent financial unit. A value of -1 indicates the root financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23421</para>
                /// </summary>
                [NameInMap("ParentUnitId")]
                [Validation(Required=false)]
                public long? ParentUnitId { get; set; }

                /// <summary>
                /// <para>The ID of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123412</para>
                /// </summary>
                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                /// <summary>
                /// <para>The name of the financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("UnitName")]
                [Validation(Required=false)]
                public string UnitName { get; set; }

            }

            /// <summary>
            /// <para>The statistics information of the financial unit.</para>
            /// </summary>
            [NameInMap("CostUnitStatisInfo")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo CostUnitStatisInfo { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo : TeaModel {
                /// <summary>
                /// <para>The number of resource instances in the current financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public long? ResourceCount { get; set; }

                /// <summary>
                /// <para>The number of resource groups in the current financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResourceGroupCount")]
                [Validation(Required=false)]
                public long? ResourceGroupCount { get; set; }

                /// <summary>
                /// <para>The number of sub-units in the current financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SubUnitCount")]
                [Validation(Required=false)]
                public long? SubUnitCount { get; set; }

                /// <summary>
                /// <para>The total number of resource instances in the current financial unit, including those in sub-financial units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalResourceCount")]
                [Validation(Required=false)]
                public long? TotalResourceCount { get; set; }

                /// <summary>
                /// <para>The total number of resource groups in the current financial unit, including those in sub-financial units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalResourceGroupCount")]
                [Validation(Required=false)]
                public long? TotalResourceGroupCount { get; set; }

                /// <summary>
                /// <para>The total number of linked accounts in the current financial unit, including those in sub-financial units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalUserCount")]
                [Validation(Required=false)]
                public long? TotalUserCount { get; set; }

                /// <summary>
                /// <para>The number of sub-units in the current financial unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UserCount")]
                [Validation(Required=false)]
                public long? UserCount { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

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
            /// <para>The list of resource instances.</para>
            /// </summary>
            [NameInMap("ResourceInstanceDtoList")]
            [Validation(Required=false)]
            public List<QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList> ResourceInstanceDtoList { get; set; }
            public class QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList : TeaModel {
                /// <summary>
                /// <para>The attached resource code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApportionCode")]
                [Validation(Required=false)]
                public string ApportionCode { get; set; }

                /// <summary>
                /// <para>The attached resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApportionName")]
                [Validation(Required=false)]
                public string ApportionName { get; set; }

                /// <summary>
                /// <para>The commodity code of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The commodity name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB</para>
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                /// <summary>
                /// <para>The product code, which is the same as the product code in User Center bills.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("PipCode")]
                [Validation(Required=false)]
                public string PipCode { get; set; }

                /// <summary>
                /// <para>The resources related to the resource instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("RelatedResources")]
                [Validation(Required=false)]
                public string RelatedResources { get; set; }

                /// <summary>
                /// <para>The resource group to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default resource group</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <para>The instance ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSSBAG-cn-v0h1s4hma018</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The custom nickname of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testResource</para>
                /// </summary>
                [NameInMap("ResourceNick")]
                [Validation(Required=false)]
                public string ResourceNick { get; set; }

                /// <summary>
                /// <para>The source of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AUTO_ALLOCATE: automatic allocation.</description></item>
                /// <item><description>MANUAL_ALLOCATE: manual allocation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MANUAL_ALLOCATE</para>
                /// </summary>
                [NameInMap("ResourceSource")]
                [Validation(Required=false)]
                public string ResourceSource { get; set; }

                /// <summary>
                /// <para>The status of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// <para>The tag of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testResource</para>
                /// </summary>
                [NameInMap("ResourceTag")]
                [Validation(Required=false)]
                public string ResourceTag { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FPT_ossbag_absolute_Storage_bj</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The user ID of the resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2424242134</para>
                /// </summary>
                [NameInMap("ResourceUserId")]
                [Validation(Required=false)]
                public long? ResourceUserId { get; set; }

                /// <summary>
                /// <para>The username of the resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@test.aliyun.com">test@test.aliyun.com</a></para>
                /// </summary>
                [NameInMap("ResourceUserName")]
                [Validation(Required=false)]
                public string ResourceUserName { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04332CB7-9A57-4461-97E0-02821D044414</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

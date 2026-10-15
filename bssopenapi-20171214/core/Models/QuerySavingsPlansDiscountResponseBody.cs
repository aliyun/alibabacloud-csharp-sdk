// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDiscountResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDiscountResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDiscountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The request IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.180.109</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The list of discount information.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDiscountResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDiscountResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The product details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云服务器ECS-按量付费</para>
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                /// <summary>
                /// <para>The contract discount rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.85</para>
                /// </summary>
                [NameInMap("ContractDiscountRate")]
                [Validation(Required=false)]
                public string ContractDiscountRate { get; set; }

                /// <summary>
                /// <para>The query cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1:Year</para>
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public string Cycle { get; set; }

                /// <summary>
                /// <para>The official discount rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.85</para>
                /// </summary>
                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public string DiscountRate { get; set; }

                /// <summary>
                /// <para>The name of the pricing module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>实例</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>The payment mode.</para>
                /// <list type="bullet">
                /// <item><description><para>total: All upfront</para>
                /// </description></item>
                /// <item><description><para>half: Partial upfront</para>
                /// </description></item>
                /// <item><description><para>zero: No upfront</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>total</para>
                /// </summary>
                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张家口</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the region where the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/26231.html">DescribeDBInstanceAttribute</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionCode")]
                [Validation(Required=false)]
                public string RegionCode { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The type of the savings plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>universal</para>
                /// </summary>
                [NameInMap("SpnType")]
                [Validation(Required=false)]
                public string SpnType { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This API is not applicable for caller.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
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

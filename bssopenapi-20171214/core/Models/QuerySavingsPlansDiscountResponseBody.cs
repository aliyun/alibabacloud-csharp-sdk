// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDiscountResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDiscountResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDiscountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The IP address of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.180.109</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The information about the discounts on saving plans.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDiscountResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDiscountResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The details of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pay-as-you-go Elastic Compute Service (ECS) instance</para>
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                /// <summary>
                /// <para>The contracted discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.85</para>
                /// </summary>
                [NameInMap("ContractDiscountRate")]
                [Validation(Required=false)]
                public string ContractDiscountRate { get; set; }

                /// <summary>
                /// <para>The cycle based on which queries were performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1:Year</para>
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public string Cycle { get; set; }

                /// <summary>
                /// <para>The discount provided by the official website.</para>
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
                /// <para>Instance</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>The payment mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>total: all upfront</description></item>
                /// <item><description>half: half upfront</description></item>
                /// <item><description>zero: no upfront</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>total</para>
                /// </summary>
                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou-na62-a01</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/26231.html">DescribeDBInstanceAttribute</a> operation to query the region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionCode")]
                [Validation(Required=false)]
                public string RegionCode { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
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
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This API is not applicable for caller.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

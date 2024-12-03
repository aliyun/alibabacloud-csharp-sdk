// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCommodityListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotApplicable</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCommodityListResponseBodyData Data { get; set; }
        public class QueryCommodityListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the service.</para>
            /// </summary>
            [NameInMap("CommodityList")]
            [Validation(Required=false)]
            public List<QueryCommodityListResponseBodyDataCommodityList> CommodityList { get; set; }
            public class QueryCommodityListResponseBodyDataCommodityList : TeaModel {
                /// <summary>
                /// <para>The payment type. Valid values: POSTPAY (pay-as-you-go) and PREPAY (subscription).</para>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAY</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The code of the service, which is the same as that on the Billing Management page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS (Pay-As-You-Go)</para>
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC706AAC-75A6-55B5-9AB7-7D171C6C7655</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the information about the service was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryDPUtilizationDetailResponseBody : TeaModel {
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
        public QueryDPUtilizationDetailResponseBodyData Data { get; set; }
        public class QueryDPUtilizationDetailResponseBodyData : TeaModel {
            [NameInMap("DetailList")]
            [Validation(Required=false)]
            public QueryDPUtilizationDetailResponseBodyDataDetailList DetailList { get; set; }
            public class QueryDPUtilizationDetailResponseBodyDataDetailList : TeaModel {
                [NameInMap("DetailList")]
                [Validation(Required=false)]
                public List<QueryDPUtilizationDetailResponseBodyDataDetailListDetailList> DetailList { get; set; }
                public class QueryDPUtilizationDetailResponseBodyDataDetailListDetailList : TeaModel {
                    [NameInMap("DeductDate")]
                    [Validation(Required=false)]
                    public string DeductDate { get; set; }

                    [NameInMap("DeductFactorTotal")]
                    [Validation(Required=false)]
                    public float? DeductFactorTotal { get; set; }

                    [NameInMap("DeductHours")]
                    [Validation(Required=false)]
                    public float? DeductHours { get; set; }

                    [NameInMap("DeductMeasure")]
                    [Validation(Required=false)]
                    public float? DeductMeasure { get; set; }

                    [NameInMap("DeductQuantity")]
                    [Validation(Required=false)]
                    public float? DeductQuantity { get; set; }

                    [NameInMap("DeductedCommodityCode")]
                    [Validation(Required=false)]
                    public string DeductedCommodityCode { get; set; }

                    [NameInMap("DeductedInstanceId")]
                    [Validation(Required=false)]
                    public string DeductedInstanceId { get; set; }

                    [NameInMap("DeductedProductDetail")]
                    [Validation(Required=false)]
                    public string DeductedProductDetail { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public string InstanceSpec { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("ResCode")]
                    [Validation(Required=false)]
                    public string ResCode { get; set; }

                    [NameInMap("ShareUid")]
                    [Validation(Required=false)]
                    public long? ShareUid { get; set; }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

            }

            /// <summary>
            /// <para>The token that specifies the start position of the next query. Pass this value to the LastToken parameter in the next request. If this parameter is returned as null, the query is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESF***zNTAw</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

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
        /// <para>DF58589C-A06C-4224-8615-7797E6474FA3</para>
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
